using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsSau
{
    class VehicleComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Sau && y is Sau)
            {
                return ComparerSau((Sau)x, (Sau)y);
            }
            if (x is Sau && y is ArmorVehicle)
            {
                return -1;
            }
            if (x is ArmorVehicle && y is Sau)
            {
                return -1;
            }
            if (x is ArmorVehicle && y is ArmorVehicle)
            {
                return ComparerArmorVehicle((ArmorVehicle)x, (ArmorVehicle)y);
            }
            return 0;
        }

        private int ComparerArmorVehicle(ArmorVehicle x, ArmorVehicle y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerSau(Sau x, Sau y)
        {
            var res = ComparerArmorVehicle (x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.DopPushka != y.DopPushka)
            {
                return x.DopPushka.CompareTo(y.DopPushka);
            }
            if (x.Man != y.Man)
            {
                return x.Man.CompareTo(y.Man);
            }
            if (x.AntiRadar != y.AntiRadar)
            {
                return x.AntiRadar.CompareTo(y.AntiRadar);
            }
            return 0;
        }
    }
}
