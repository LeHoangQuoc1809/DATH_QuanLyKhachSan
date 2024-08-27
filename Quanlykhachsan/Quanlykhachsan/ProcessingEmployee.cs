using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Quanlykhachsan
{
    internal class ProcessingEmployee
    {
        private static Dictionary<string, Employee> m_DicEmployee = new Dictionary<string, Employee>();
        private static Employee m_CrrEmployee = new Employee();
        private static List<string> m_ListType = new List<string>();
        public static Employee CrrEmployee
        {
            get { return m_CrrEmployee; }
            set { m_CrrEmployee = value; }
        }
        public static List<string> ListType
        {
            get { return m_ListType; }
            set { m_ListType = value; }
        }
        public static Dictionary<string, Employee> DicEmployee
        {
            get { return m_DicEmployee; }
            set { m_DicEmployee = value; }
        }
        public static bool readFileEmployee()
        {
            try
            {
                FileStream fs = new FileStream("Employee.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_DicEmployee = bf.Deserialize(fs) as Dictionary<string, Employee>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool writeFileEmployee()
        {
            FileStream fs = new FileStream("Employee.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m_DicEmployee);
            fs.Close();
            return true;
        }
    }
}
