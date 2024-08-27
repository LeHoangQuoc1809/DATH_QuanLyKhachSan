using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    [Serializable]
    public class RentalSingle 
    {
        private Room m_RoomBook;
        private string m_NameCustomer;
        private string m_IDCustomer;
        private DateTime m_TimeCheckin;
        private DateTime m_TimeCheckout;
        private Employee m_EmployeeBook;
        private RentalPrice m_Price;
        private string m_TypeRental;
        private int m_nod;

        public RentalSingle()
        {
            m_RoomBook = new Room();
            m_NameCustomer =string.Empty;
            m_IDCustomer =string.Empty;
            m_TimeCheckin=DateTime.Now;
            m_TimeCheckout=DateTime.Now;
            m_EmployeeBook = new Employee();
            m_Price = new RentalPrice();
            m_TypeRental = string.Empty;
            m_nod = 0;
        }
        public RentalSingle(string name, string id, Room rb, DateTime tc, DateTime tco,  Employee em, RentalPrice rp, string tr, int n)
        {
            m_NameCustomer=name;
            m_IDCustomer=id;
            m_TimeCheckin=tc;
            m_RoomBook=rb;
            m_TimeCheckout = tco;
            m_EmployeeBook = em;
            m_Price = rp;
            m_TypeRental = tr;
            m_nod = n;
        }
        public string NameCustomer { get => m_NameCustomer; set => m_NameCustomer=value; }
        public string IDCustomer { get => m_IDCustomer; set => m_IDCustomer=value; }
        public DateTime TimeCheckin { get => m_TimeCheckin; set => m_TimeCheckin=value; }
        public DateTime TimeCheckout { get => m_TimeCheckout; set => m_TimeCheckout=value; }
        public Employee EmployeeBook { get => m_EmployeeBook; set => m_EmployeeBook=value; }
        public string TypeRental { get => m_TypeRental; set => m_TypeRental=value; }
        public int Nod { get => m_nod; set => m_nod=value; }
        internal Room RoomBook { get => m_RoomBook; set => m_RoomBook=value; }
        internal RentalPrice Price { get => m_Price; set => m_Price=value; }
    }
}
