using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlykhachsan
{
    public class ViewUnitSingle
    {
        private string roomcode;
        private DateTime timePayment;
        public string Roomcode { get => roomcode; set => roomcode=value; }
        public DateTime TimePayment { get => timePayment; set => timePayment=value; }
    }
}
