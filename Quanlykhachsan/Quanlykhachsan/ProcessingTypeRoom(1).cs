using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Quanlykhachsan
{
    internal class ProcessingTypeRoom
    {
        private static List<int> m_ListSize = new List<int>();
        private static List<string> m_ListRank = new List<string>();
        private static Dictionary<string, RentalPrice> m_DicRePr = new Dictionary<string, RentalPrice>();
        public static List<int> ListSize
        {
            get { return m_ListSize; }
            set { m_ListSize = value; }
        }
        public static List<string> ListRank
        {
            get { return m_ListRank; }
            set { m_ListRank = value; }
        }
        public static Dictionary<string, RentalPrice> DicRentalPrice
        {
            get { return m_DicRePr; }
            set { m_DicRePr = value; }
        }
        public static void init_DicRePr()
        {
            foreach (int i in m_ListSize)
            {
                foreach (string s in m_ListRank)
                {
                    RentalPrice rp = new RentalPrice();
                    m_DicRePr.Add(i.ToString()+'-'+s, rp);
                }
            }
        }
        
        public static Dictionary<string, RentalPrice> sortDicRentalPrice()
        {
            Dictionary<string, RentalPrice> dic = new Dictionary<string, RentalPrice>();
            foreach (int i in m_ListSize)
            {
                foreach (string s in m_ListRank)
                {
                    RentalPrice rp = new RentalPrice();
                    dic.Add(i.ToString()+'-'+s, rp);
                }
            }
            foreach (string s in dic.Keys)
            {
                dic[s].FirstHour = m_DicRePr[s].FirstHour;
                dic[s].NormalHour = m_DicRePr[s].NormalHour;
                dic[s].Day=m_DicRePr[s].Day;
                dic[s].OverNight = m_DicRePr[s].OverNight;
            }
            return dic;
        }
        public static void changeValue_ListSize(int oldvalue, int newvalue)
        {
            m_ListSize[oldvalue] = newvalue;
        }
        public static int add_ListSize(int size)
        {
            foreach (int i in m_ListSize)
            {
                if (i == size)
                    return -1;
            }
            m_ListSize.Add(size);
            return size;
        }
        public static void changeValue_ListRank(string oldvalue, string newvalue)
        {
            m_ListRank[m_ListRank.LastIndexOf(oldvalue)] = newvalue;
        }
        public static string add_ListRank(string rank)
        {
            foreach (string i in m_ListRank)
            {
                if (i == rank)
                    return null;
            }
            m_ListRank.Add(rank);
            return rank;
        }
        //FILE SIZE
        public static bool writeFileTypeRooms_Size()
        {
            FileStream fs = new FileStream("Size_TypeRooms.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m_ListSize);
            fs.Close();
            return true;
        }
        public static bool readFileTypeRooms_Size()
        {
            try
            {
                FileStream fs = new FileStream("Size_TypeRooms.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_ListSize=bf.Deserialize(fs) as List<int>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //FIlE RANK
        public static bool writeFileTypeRooms_Rank()
        {
            FileStream fs = new FileStream("Rank_TypeRooms.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m_ListRank);
            fs.Close();
            return true;
        }
        public static bool readFileTypeRooms_Rank()
        {
            try
            {
                FileStream fs = new FileStream("Rank_TypeRooms.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_ListRank=bf.Deserialize(fs) as List<string>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //FIlE PRICE
        public static bool writeFileTypeRooms_Price()
        {
            FileStream fs = new FileStream("Price.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m_DicRePr);
            fs.Close();
            return true;
        }
        public static bool readFileTypeRooms_Price()
        {
            try
            {
                FileStream fs = new FileStream("Price.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_DicRePr = bf.Deserialize(fs) as Dictionary<string, RentalPrice>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
