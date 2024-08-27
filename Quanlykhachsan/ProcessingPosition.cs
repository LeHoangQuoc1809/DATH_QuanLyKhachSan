using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Quanlykhachsan
{
    [Serializable]
    internal class ProcessingPosition
    {
        private static List<string> m_ListPosition = new List<string>();
        public static List<string> ListPosition
        {
            get { return m_ListPosition; }
            set { m_ListPosition = value; }
        }
        public static bool readFilePosition()
        {
            try
            {
                FileStream fs = new FileStream("Position.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_ListPosition = bf.Deserialize(fs) as List<string>;
                fs.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool writeFilePosition()
        {
            FileStream fs = new FileStream("Position.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs,m_ListPosition);
            fs.Close();
            return true;
        }
    }
}
