using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    [Serializable]
    public class SingleBill
    {
        private RentalSingle m_reatalsingle_bill;
        private Employee m_employeePayment;
        private DateTime m_timePayment;
        public RentalSingle RentalSingle_Bill
        {
            get { return m_reatalsingle_bill;}
            set { m_reatalsingle_bill = value;}
        }
        public Employee EmployeePayment
        {
            get { return m_employeePayment;}
            set { m_employeePayment = value;}
        }
        public DateTime TimePayment
        {
            get { return m_timePayment;}
            set { m_timePayment = value;}
        }
        public double Totalmoney
        {
            get { return ProcessingSingleBill.calculateMoney(this); }
        }
        public SingleBill()
        {
            m_reatalsingle_bill = new RentalSingle();
            m_employeePayment = new Employee();
            m_timePayment = DateTime.Now;
        }
    }
}
