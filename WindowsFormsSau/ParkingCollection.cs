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

        public bool SaveData(string filename)
        {
            using (StreamWriter streamWriter = new StreamWriter
            (filename, false, System.Text.Encoding.Default))
            {
                streamWriter.WriteLine("ParkingCollection");
                foreach (var level in parkingStages)
                {
                    streamWriter.WriteLine("Parking" + separator + level.Key);

                    ITransport vehicle;
                    for (int i = 0; (vehicle = level.Value.GetNext(i)) != null; i++)
                    {
                        if (vehicle.GetType().Name == "Sau")
                        {
                            streamWriter.Write("Sau" + separator);
                        }
                        else if (vehicle.GetType().Name == "ArmorVehicle")
                        {
                            streamWriter.Write("ArmorVehicle" + separator);
                        }
                        streamWriter.WriteLine(vehicle);
                    }
                }
                return true;
            }
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }

            using (StreamReader streamReader = new StreamReader
            (filename, System.Text.Encoding.Default))
            {
                if (streamReader.ReadLine().Contains("ParkingCollection"))
                {
                    parkingStages.Clear();
                }
                else
                {
                    return false;
                }
                Vehicle transport = null;
                string key = string.Empty;
                string line;
                for (int i = 0; (line = streamReader.ReadLine()) != null; i++)
                {
                    if (line.Contains("Parking"))
                    {
                        key = line.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                    }
                    else if (line.Contains(separator))
                    {
                        if (line.Contains("Sau"))
                        {
                            transport = new Sau(line.Split(separator)[1]);
                        }
                        else if (line.Contains("ArmorVehicle"))
                        {
                            transport = new ArmorVehicle(line.Split(separator)[1]);
                        }
                        if (!(parkingStages[key] + transport))
                        {
                            return false;
                        }
                    }
                }
                return true;
            }
        }
    }
}
