using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlykhachsan
{
    public partial class FormSingleBill : Form
    {
        SingleBill sb = new SingleBill();
        CheckBox check;
        public FormSingleBill(SingleBill sbo , CheckBox cb)
        {
            InitializeComponent();
            sb = sbo;
            check = cb;
        }
        public void showBill()
        {
            int day = 0, hour = 0;
            ProcessingSingleBill.calculateRentalTime(sb, ref day, ref hour);
            RentalSingle rs = sb.RentalSingle_Bill;
            lbRoomCode_Bill.Text = rs.RoomBook.RoomCode;
            lbTimePayment.Text = sb.TimePayment.ToString();
            lbID_Bill.Text = rs.IDCustomer;
            lbName_Bill.Text= rs.NameCustomer;
            lbSize_Bill.Text= rs.RoomBook.TypeRoom.Size.ToString();
            lbRank_Bill.Text = rs.RoomBook.TypeRoom.Rank;
            lbTypeRental.Text = rs.TypeRental;
            lbTimeCheckin_Bill.Text = rs.TimeCheckin.ToString();
            if (rs.TypeRental == "Hour" || rs.TypeRental=="OverNight")
            {
                lbTimeCheckout_Bill.Text = sb.TimePayment.ToString();
            }
            else 
            {
                lbTimeCheckout_Bill.Text = sb.RentalSingle_Bill.TimeCheckout.ToString();
            }
            lbRentalTime.Text = "Day: "+day.ToString()+", Hour: "+hour.ToString();
            lbEmployeeBook.Text = rs.EmployeeBook.Name;
            lbEmployeePayment.Text = ProcessingEmployee.CrrEmployee.Name;
            lbTotalMoney.Text = sb.Totalmoney.ToString();

        }


        private void FormSingleBill_Load(object sender, EventArgs e)
        {
            showBill();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            ProcessingRentalSingle.DicRenSin.Remove(lbRoomCode_Bill.Text);
            ProcessingRentalSingle.writeFileRentalSingle();
            check.Checked = true;
            ProcessingSingleBill.addBillHistory(sb);

            this.Close();
        }
    }
}
