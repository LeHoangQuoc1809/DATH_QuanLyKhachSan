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
    internal class ProcessingRoom
    {

        private static Dictionary<string, Room> m_DicRoom = new Dictionary<string, Room>();
        public static Dictionary<string, Room> DicRoom
        {
            get { return m_DicRoom; }
            set { m_DicRoom = value; }
        }
        public static Dictionary<string, Room> sortDicRoom()
        {
            Dictionary<string, Room> dicRoom = new Dictionary<string, Room>();
            for (int i = 0; i < m_DicRoom.Count; i++)
            {
                string min = m_DicRoom.ToList()[i].Key;
                for (int j = 0; j < m_DicRoom.Count; j++)
                {
                    if (string.Compare(min, m_DicRoom.ToList()[j].Key) > 0)
                    {
                        if (!dicRoom.ContainsKey(m_DicRoom.ToList()[j].Key))
                            min = m_DicRoom.ToList()[j].Key;
                    }
                }
                if (!dicRoom.ContainsKey(min))
                {
                    Room r = new Room();
                    r.RoomCode = min;
                    dicRoom.Add(min, r);
                    i--;
                }

            }
            foreach (string s in dicRoom.Keys)
            {
                dicRoom[s].RoomCode = m_DicRoom[s].RoomCode;
                dicRoom[s].TypeRoom.Size = m_DicRoom[s].TypeRoom.Size;
                dicRoom[s].TypeRoom.Rank = m_DicRoom[s].TypeRoom.Rank;
                dicRoom[s].Status = m_DicRoom[s].Status;
            }
            return dicRoom;
        }
        public static Room search_Room(string roomCode)
        {
            try
            {
                return m_DicRoom[roomCode];
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool addRoom(string roomCode, TypeRoom typeRoom, string status)
        {
            Room room = new Room();
            room.RoomCode = roomCode;
            room.TypeRoom = typeRoom;
            room.Status = status;
            if (search_Room(roomCode) != null)
            {
                m_DicRoom.Add(roomCode, room);
                return true;
            }
            else return false;
        }

        public static bool writeFile_DicRoom()
        {
            FileStream fs = new FileStream("ListRoom.bin", FileMode.Create);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, m_DicRoom);
            fs.Close();
            return true;
        }
        public static bool readFile_DicRoom()
        {
            try
            {
                //
                FileStream fs = new FileStream("ListRoom.bin", FileMode.Open);
                BinaryFormatter bf = new BinaryFormatter();
                m_DicRoom = bf.Deserialize(fs) as Dictionary<string, Room>;
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
