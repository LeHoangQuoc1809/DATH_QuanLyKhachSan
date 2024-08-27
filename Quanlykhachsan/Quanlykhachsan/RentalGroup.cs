using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    [Serializable]
    public class RentalGroup
    {
        private List<Room> m_ListRoomBook;
        private string m_NameCustomer;
        private string m_IDCustomer;//Key
        private int m_NOP;
        private int m_SizeListRoom;
        private DateTime m_TimeCheckin;
        private DateTime m_TimeCheckout;
        private Employee m_EmployeeBook;
        private int m_nod;
        public string getListBook()
        {
            string str = "";
            foreach (Room a in m_ListRoomBook)
            {
                if (m_ListRoomBook.IndexOf(a) == 0)
                    str += a.RoomCode;
                else str += ", " + a.RoomCode;
            }
            return str;
        }
        public List<Room> ListRoomBook
        {
            get { return m_ListRoomBook; }
            set { m_ListRoomBook = value; }
        }
        public string NameCustomer
        {
            get { return m_NameCustomer; }
            set { m_NameCustomer = value; }
        }
        public string IDCustomer
        {
            get { return m_IDCustomer; }
            set { m_IDCustomer = value; }
        }
        public int NOP
        {
            get { return m_NOP; }
            set { m_NOP = value; }
        }
        public int SizeListRoom
        {
            get { return m_SizeListRoom; }
            set { m_SizeListRoom = value; }
        }
        public DateTime TimeCheckin
        {
            get { return m_TimeCheckin; }
            set { m_TimeCheckin = value; }
        }
        public DateTime TimeCheckout
        {
            get { return m_TimeCheckout; }
            set { m_TimeCheckout = value; }
        }
        public Employee EmployeeBook 
        { get => m_EmployeeBook; 
            set => m_EmployeeBook = value; 
        }
        public int Nod
        { 
            get => m_nod; 
            set => m_nod = value; 
        }
        public RentalGroup()
        {
            m_ListRoomBook = new List<Room>();
            m_NameCustomer = string.Empty;
            m_IDCustomer = string.Empty;
            m_NOP = 0;
            m_SizeListRoom = 0;
            m_TimeCheckin = DateTime.Now;
            m_TimeCheckout = DateTime.Now;
            m_EmployeeBook = new Employee();
            m_nod = 0;
        }
        public RentalGroup(string name, string id,int nop,int slr, List<Room> rb, DateTime tci, DateTime tco, Employee em, int n)
        {
            m_NameCustomer = name;
            m_IDCustomer = id;
            m_NOP = nop;
            m_SizeListRoom = slr;
            m_TimeCheckin = tci;
            m_TimeCheckout = tco;
            m_ListRoomBook = rb;
            m_EmployeeBook = em;
            m_nod = n;
        }
    }
}
