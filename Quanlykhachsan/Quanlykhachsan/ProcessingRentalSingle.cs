using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Quanlykhachsan
{
    internal class ProcessingRentalSingle
    {
        public static Dictionary<string, RentalSingle> DicRenSin = new Dictionary<string, RentalSingle>();
        public static Dictionary<string, RentalSingle> DicRenSinSub = new Dictionary<string, RentalSingle>();


        public static RentalSingle findRentalSingle(string roomcode)
        {
            if (DicRenSin.ContainsKey(roomcode))
                return DicRenSin[roomcode];
            else
            {
                return null;
            }
        }
        public static void addRentalSingle(RentalSingle rs)
        {
            if (!DicRenSin.ContainsKey(rs.RoomBook.RoomCode))
                DicRenSin.Add(rs.RoomBook.RoomCode, rs);
        }
        public static void deleteRentalSingle(RentalSingle rs)
        {
            if (!DicRenSin.ContainsKey(rs.RoomBook.RoomCode))
                DicRenSin.Remove(rs.RoomBook.RoomCode);
        }
        public static void changeRentalSingle(RentalSingle rs)
        {
            if (!DicRenSin.ContainsKey(rs.RoomBook.RoomCode))
            {
                DicRenSin.Remove(rs.RoomBook.RoomCode);
                DicRenSin.Add(rs.RoomBook.RoomCode, rs);
            }
        }
        public static void writeFileRentalSingle()
        {
            try
            {
                FileStream fs = new FileStream("RentalSingle.bin", FileMode.Create);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, DicRenSin);
                fs.Close();
            }
            catch
            {
                return;
            }
        }
        public static bool readFileRentalSingle()
        {
            try
            {
                FileStream fs = new FileStream("RentalSingle.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DicRenSin = bf.Deserialize(fs) as Dictionary<string, RentalSingle>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static void writeFileRentalSingleSub()
        {
            FileStream fs = new FileStream("RentalSingleSub.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, DicRenSinSub);
            fs.Close();
        }
        public static bool readFileRentalSingleSub()
        {
            try
            {
                FileStream fs = new FileStream("RentalSingleSub.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                DicRenSinSub = bf.Deserialize(fs) as Dictionary<string, RentalSingle>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //
        public static double calculateMoneyHour(RentalSingle rs)
        {
            double result = 0;
            string tr = rs.TypeRental;
            double firsthour = rs.Price.FirstHour;
            double norhour = rs.Price.NormalHour;
            double overprice = rs.Price.OverNight;
            double dayprice = rs.Price.Day;
            if (tr == "Hour")
            {
                TimeSpan ts = new TimeSpan();
                DateTime dtNow = DateTime.Now;
                ts = dtNow - rs.TimeCheckin;
                int d = ts.Days;
                int h = ts.Hours;
                int m = ts.Minutes;
                int s = ts.Seconds;
                int runH = d*24+h;
                if (m>0||s>0)
                    runH++;
                if (runH > 24) runH=24;
                DateTime timecrr = rs.TimeCheckin;


                if (runH < 5 && timecrr.Hour+runH < 23)
                //tinh tien gio it hon 5 tieng
                {
                    runH-=1;
                    if (runH<0) runH=0;
                    result += (firsthour + (runH)*norhour);
                    runH-=runH;
                }
                else if (runH>=5 && timecrr.Hour + 4 < 23)
                // tinh tien gio du 5 tieng thanh gia ngay
                {
                    result += dayprice;
                    TimeSpan temp = new TimeSpan(1, 0, 0, 0);
                    timecrr = timecrr.Add(temp);
                    runH-=24;
                }
                else if (runH >= 5 && timecrr.Hour +runH >= 23)
                //Thue lo qua gio dem (23h)
                {
                    //Tinh gio truoc 23h qua dem
                    int prehour = 23 -timecrr.Hour;
                    if (timecrr.Minute>0) prehour--;
                    result += (firsthour + (prehour-1)*norhour);
                    //cong tien voi gio qua dem overnight
                    result += overprice;
                    //tru di so gio da tinh cho tong gio o 
                    runH -=prehour;
                    runH -=11;
                    TimeSpan temp = new TimeSpan(0, prehour+11, 0, 0);
                    timecrr = timecrr.Add(temp);
                }
            }
            return result;
        }
        //
        public static double calculateMoneyOverNight(RentalSingle rs)
        {
            double result = 0;
            string tr = rs.TypeRental;
            double firsthour = rs.Price.FirstHour;
            double norhour = rs.Price.NormalHour;
            double overprice = rs.Price.OverNight;
            double dayprice = rs.Price.Day;
            if (tr == "OverNight")
            {
                result+=overprice;

                DateTime dtNow = DateTime.Now;

                if (DateTime.Compare(dtNow, rs.TimeCheckin) > 0)
                {
                    RentalSingle rsn = new RentalSingle();
                    rsn = rs;
                    rsn.TimeCheckin = dtNow;
                    result += calculateMoneyHour(rsn);
                }
            }
            return result;
        }
        //
        public static double calculateMoneyDay(RentalSingle rs)
        {
            double result = 0;
            string tr = rs.TypeRental;
            double firsthour = rs.Price.FirstHour;
            double norhour = rs.Price.NormalHour;
            double overprice = rs.Price.OverNight;
            double dayprice = rs.Price.Day;
            int nday = rs.Nod;
            if (tr == "Day")
            {
                int nd = nday;
                TimeSpan ts = new TimeSpan();
                DateTime dtNow = DateTime.Now;
                ts = rs.TimeCheckout - rs.TimeCheckin;
                int d = ts.Days;
                int h = ts.Hours;
                int m = ts.Minutes;
                int s = ts.Seconds;
                if (s>0)
                    m++;
                if (m>0)
                    h++;
                int runH = d*24+h;
                if (h>0)
                    d++;
                //
                result+=nd*dayprice;
                if (DateTime.Compare(DateTime.Now, rs.TimeCheckout) > 0)
                {
                    RentalSingle rsn = new RentalSingle();
                    rsn.TimeCheckin = rs.TimeCheckout;

                    double db = calculateMoneyHour(rs);
                    result+=db;
                }
            }
            return result;
        }
        public static double calculateMoney(RentalSingle rs)
        {
            double result = 0;
            if (rs.TypeRental == "Hour")
                result += ProcessingRentalSingle.calculateMoneyHour(rs);
            else if (rs.TypeRental == "Day")
            {
                result += ProcessingRentalSingle.calculateMoneyDay(rs);
            }
            else
                result += ProcessingRentalSingle.calculateMoneyOverNight(rs);
            return result;
        }
    }
}
