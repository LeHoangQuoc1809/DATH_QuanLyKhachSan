using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Quanlykhachsan
{
    internal class ProcessingSingleBill
    {
        private static List<SingleBill> m_ListSingleBill = new List<SingleBill>();
        public static List<SingleBill> ListSingleBill
        {
            get { return m_ListSingleBill; }
            set { m_ListSingleBill = value; }
        }
        public static void writeFileSingleBill()
        {
            FileStream fs = new FileStream("SingleBill.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m_ListSingleBill);
            fs.Close();
        }
        public static bool readFileSingleBill()
        {
            try
            {
                FileStream fs = new FileStream("SingleBill.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_ListSingleBill = bf.Deserialize(fs) as List<SingleBill>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static SingleBill search(string roomcode, DateTime timepayment)
        {
            foreach(SingleBill sb in ListSingleBill)
            {
                if (sb.RentalSingle_Bill.RoomBook.RoomCode == roomcode && DateTime.Compare(sb.TimePayment, timepayment)==0)
                    return sb;
            }
            return null;
        }
        public static void addBillHistory(SingleBill sb)
        {
            readFileSingleBill();
            m_ListSingleBill.Add(sb);
            writeFileSingleBill();
        }

        public static void ch(SingleBill sb, ref int Day, ref int Hour)
        {
            int d = 0, h = 0, m = 0, s = 0;
            TimeSpan ts = new TimeSpan();
            ts = sb.TimePayment - sb.RentalSingle_Bill.TimeCheckin;
            if (ts.Seconds>0)
                m++;
            if (ts.Minutes>0)
                h++;
            if (ts.Hours>=24)
                d++;
            Day =d;
            Hour =h;
        }
        public static void calculateRentalTime(SingleBill sb, ref int Day, ref int Hour)
        {
            string str = sb.RentalSingle_Bill.TypeRental;
            if (str=="Hour" || str=="OverNight")
            {
                ch(sb, ref Day, ref Hour);   
            }
            else if (str =="Day")
            {
                Day = sb.RentalSingle_Bill.Nod;
                Hour = 0;
            }
        }
        public static double calculateMoney(SingleBill sb)
        {
            double result = 0;
            RentalSingle rs = sb.RentalSingle_Bill;
            if (rs.TypeRental == "Hour")
                result += ProcessingRentalSingle.calculateMoneyHour(rs);
            else if (rs.TypeRental =="Day")
            {
                result += ProcessingRentalSingle.calculateMoneyDay(rs);
            }
            else
                result += ProcessingRentalSingle.calculateMoneyOverNight(rs);
            return result;
        }
    }
}
