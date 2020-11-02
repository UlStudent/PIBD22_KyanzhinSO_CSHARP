using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSau
{
    class ParkingCollection
    {
        readonly Dictionary<string, Parking<Vehicle>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;
        private readonly int pictureHeight;
        private readonly char separator = ';';

        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight));
        }

        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Parking<Vehicle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                return null;
            }
        }

        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                WriteToFile($"ParkingCollection{Environment.NewLine}", fs);
                foreach (var level in parkingStages)
                {
                    //Начинаем парковку
                    WriteToFile($"Parking{separator}{level.Key}{Environment.NewLine}",
                    fs);
                    ITransport vehicle = null;
                    for (int i = 0; (vehicle = level.Value.GetNext(i)) != null; i++)
                    {
                        if (vehicle != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (vehicle.GetType().Name == "ArmorVehicle")
                            {
                                WriteToFile($"ArmorVehicle{separator}", fs);
                            }
                            if (vehicle.GetType().Name == "Sau")
                            {
                                WriteToFile($"Sau{separator}", fs);
                            }
                            //Записываемые параметры
                            WriteToFile(vehicle + Environment.NewLine, fs);
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            string bufferTextFromFile = "";
            using (StreamReader sr = new StreamReader(filename))
            {
                char[] b = new byte[sr.Length];
                UTF8Encoding temp = new UTF8Encoding(true);
                while (sr.Read(b, 0, b.Length) > 0)
                {
                    bufferTextFromFile += temp.GetString(b);
                }
            }
            bufferTextFromFile = bufferTextFromFile.Replace("\r", "");
            var strs = bufferTextFromFile.Split('\n');
            if (strs[0].Contains("ParkingCollection"))
            {
                //очищаем записи
                parkingStages.Clear();
            }
            else
            {
                //если нет такой записи, то это не те данные
                return false;
            }
            Vehicle vehicle = null;
            string key = string.Empty;
            for (int i = 1; i < strs.Length; ++i)
            {
                //идем по считанным записям
                if (strs[i].Contains("Parking"))
                {
                    //начинаем новую парковку
                    key = strs[i].Split(separator)[1];
                    parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    continue;
                }
                if (string.IsNullOrEmpty(strs[i]))
                {
                    continue;
                }
                if (strs[i].Split(separator)[0] == "ArmorVehicle")
                {
                    vehicle = new ArmorVehicle(strs[i].Split(separator)[1]);
                }
                else if (strs[i].Split(separator)[0] == "Sau")
                {
                    vehicle = new Sau(strs[i].Split(separator)[1]);
                }
                var result = parkingStages[key] + vehicle;
                if (!result)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
