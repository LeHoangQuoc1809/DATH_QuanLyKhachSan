using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    [Serializable]
    public class GroupBill
    {
        private RentalGroup m_rentalgroup_bill;
        private Employee m_employeePayment;
        private DateTime m_timePayment;
        private double m_totalmoney;
        public RentalGroup RentalGroup_Bill
        {
            get { return m_rentalgroup_bill; }
            set { m_rentalgroup_bill = value; }
        }
        public Employee EmployeePayment
        {
            get { return m_employeePayment; }
            set { m_employeePayment = value; }
        }
        public DateTime TimePayment
        {
            get { return m_timePayment; }
            set { m_timePayment = value; }
        }
        public double Totalmoney
        {
            get { return ProcessingRentalGroup.calculateMoneyDay(m_rentalgroup_bill); }
        }
        public GroupBill()
        {
            m_rentalgroup_bill = new RentalGroup();
            m_employeePayment = new Employee();
            m_timePayment = DateTime.Now;
        }
    }
}
