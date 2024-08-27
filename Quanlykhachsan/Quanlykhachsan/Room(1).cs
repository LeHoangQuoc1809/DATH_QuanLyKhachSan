using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    [Serializable]
    public class Room
    {
        private string m_RoomCode;
        private TypeRoom m_TypeRoom;
        private string m_Status;
        public string RoomCode
        {
            get { return m_RoomCode; }
            set { m_RoomCode = value; }
        }
        public TypeRoom TypeRoom
        {
            get { return m_TypeRoom; }
            set { m_TypeRoom = value; }
        }
        public string Status
        {
            get { return m_Status; }
            set { m_Status = value; }
        }
        public Room()
        {
            m_RoomCode = string.Empty;
            m_TypeRoom = new TypeRoom();
            m_Status = string.Empty;
        }
    }
}
