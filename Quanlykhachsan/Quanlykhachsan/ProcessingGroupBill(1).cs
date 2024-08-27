using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Quanlykhachsan
{
    public class ProcessingGroupBill
    {
        public static List<GroupBill> ListGroupBill = new List<GroupBill>();
        public static void writeFileGroupBill()
        {
            FileStream fs = new FileStream("GroupBill.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ListGroupBill);
            fs.Close();
        }
        public static bool readFileGroupBill()
        {
            try
            {
                FileStream fs = new FileStream("GroupBill.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                ListGroupBill = bf.Deserialize(fs) as List<GroupBill>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static GroupBill search(string id, DateTime timepayment)
        {
            foreach (GroupBill gb in ListGroupBill)
            {
                if (gb.RentalGroup_Bill.IDCustomer == id && DateTime.Compare(gb.TimePayment, timepayment) == 0)
                    return gb;
            }
            return null;
        }
        public static void addBillHistory(GroupBill gb)
        {
            ListGroupBill.Add(gb);
            writeFileGroupBill();
        }
    }
}
