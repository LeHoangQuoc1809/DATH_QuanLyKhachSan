using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Quanlykhachsan
{
    internal class ProcessingRentalGroup
    {
        public static Dictionary<string, RentalGroup> DicRenGroup = new Dictionary<string, RentalGroup>();
        public static Dictionary<string, RentalGroup> DicRenGroupSub = new Dictionary<string, RentalGroup>();

        public static RentalGroup findRentalGroup(string id)
        {
            if (DicRenGroup.ContainsKey(id))
                return DicRenGroup[id];
            else
            {
                return null;
            }
        }
        public static void addRentalGroup(RentalGroup rg)
        {
            if (!DicRenGroup.ContainsKey(rg.IDCustomer))
                DicRenGroup.Add(rg.IDCustomer, rg);
        }
        public static void deleteRentalGroup(RentalGroup rg)
        {
            if (!DicRenGroup.ContainsKey(rg.IDCustomer))
                DicRenGroup.Remove(rg.IDCustomer);
        }
        public static void changeRentalGroup(RentalGroup rg)
        {
            if (!DicRenGroup.ContainsKey(rg.IDCustomer))
            {
                DicRenGroup.Remove(rg.IDCustomer);
                DicRenGroup.Add(rg.IDCustomer, rg);
            }
        }
        public static void writeFileRentalGroup()
        {
            try
            {
                FileStream fs = new FileStream("RentalGroup.bin", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, DicRenGroup);
                fs.Close();
            }
            catch
            {
                return;
            }
        }
        public static bool readFileRentalGroup()
        {
            try
            {
                FileStream fs = new FileStream("RentalGroup.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DicRenGroup = bf.Deserialize(fs) as Dictionary<string, RentalGroup>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void writeFileRentalGroupSub()
        {
            FileStream fs = new FileStream("RentalGroupSub.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, DicRenGroupSub);
            fs.Close();
        }
        public static bool readFileRentalGroupSub()
        {
            try
            {
                FileStream fs = new FileStream("RentalGroupSub.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DicRenGroupSub = bf.Deserialize(fs) as Dictionary<string, RentalGroup>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static double calculateMoneyDay(RentalGroup rg)
        {
            double result = 0;
            foreach(Room a in rg.ListRoomBook)
            {
                RentalPrice rr = ProcessingTypeRoom.DicRentalPrice[a.TypeRoom.Name];
                double nod = rg.Nod;
                result += nod * rr.Day;
            }
            return result;
        }
    }
}
