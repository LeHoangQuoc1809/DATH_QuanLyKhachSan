using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlykhachsan
{
    public partial class FormGroupBill : Form
    {
        GroupBill gb = new GroupBill();
        CheckBox cb;
        RentalGroup rg;
        public FormGroupBill(GroupBill GB, CheckBox CB)
        {
            InitializeComponent();
            gb = GB;
            cb = CB;
            rg = gb.RentalGroup_Bill;
        }
        public void showBill()
        {
            lbTimePayment.Text = gb.TimePayment.ToString();
            lbID_Bill.Text = rg.IDCustomer;
            lbName_Bill.Text = rg.NameCustomer;
            lbListRoom.Text = rg.getListBook();
            lbRentalTime.Text = rg.Nod.ToString();
            lbTimeCheckin_Bill.Text = rg.TimeCheckin.ToString();
            lbTimeCheckout_Bill.Text = rg.TimeCheckout.ToString();
            lbEmployeeBook.Text = rg.EmployeeBook.Name;
            lbEmployeePayment.Text = ProcessingEmployee.CrrEmployee.Name;
            lbTotalMoney.Text = gb.Totalmoney.ToString();
        }
        private void FormGroupBill_Load(object sender, EventArgs e)
        {
            showBill();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            ProcessingGroupBill.addBillHistory(gb);
            cb.Checked = true;
            this.Close();
        }
    }
}
