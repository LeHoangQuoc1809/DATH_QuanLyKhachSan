using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    public class ViewUnitGroup
    {
        private string m_idcustomer;
        private DateTime m_timepayment;
        public string IDCustomer { get => m_idcustomer; set => m_idcustomer = value; }
        public DateTime TimePayment { get => m_timepayment; set => m_timepayment = value; }
        public ViewUnitGroup()
        {
            m_idcustomer = "";
            m_timepayment = DateTime.Now;
        }
        public ViewUnitGroup(string idcustomer, DateTime timepayment)
        {
            m_idcustomer = idcustomer;
            m_timepayment = timepayment;
        }
    }
}
