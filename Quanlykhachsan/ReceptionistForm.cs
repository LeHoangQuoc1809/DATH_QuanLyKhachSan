using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace Quanlykhachsan
{
    public partial class ReceptionistForm : Form
    {
        public ReceptionistForm()
        {
            InitializeComponent();
        }
        public void showRoom()
        {

        }
        private void ReceptionistForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            for (int i = 0; i < pnToTalBookGroup.Controls.Count; i++)
                pnToTalBookGroup.Controls[i].Enabled = false;
        }
        private void ReceptionistForm_Load(object sender, EventArgs e)
        {
            ProcessingRoom.readFile_DicRoom();
            ProcessingRentalSingle.readFileRentalSingle();
            ProcessingRentalSingle.readFileRentalSingleSub();
            ProcessingTypeRoom.readFileTypeRooms_Price();
        }
        private void btnHistoryBill_Click(object sender, EventArgs e)
        {
            changeForm(pnToTalBookGroup);
           
            lbWelcome.Visible = false;
            FormHistoryBill frm = new FormHistoryBill();
            frm.TopLevel = false;
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            pnToTalBookGroup.Controls.Add(frm);
            frm.Show();
        }
        void changeForm(Panel pn)
        {
            for (int i = 0; i < pn.Controls.Count; i++)
            {
                pn.Controls[i].Enabled = false;
            }
            pn.Controls.Clear();
        }
        private void btnBookSingle_Click(object sender, EventArgs e)
        {
            changeForm(pnToTalBookGroup);
            lbWelcome.Visible = false;
            FormBookSingle frm = new FormBookSingle();
            frm.TopLevel = false;
            pnToTalBookGroup.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void btnBookSingle_MouseMove(object sender, MouseEventArgs e)
        {
            btnBookSingle.BackColor = Color.LightSkyBlue;
        }
        private void btnBookSingle_MouseLeave(object sender, EventArgs e)
        {
            btnBookSingle.BackColor = Color.DodgerBlue;
        }
        private void btnBookSingle_MouseDown(object sender, MouseEventArgs e)
        {
            btnBookSingle.BackColor = Color.Red;
        }
        List<Room> listRoom = new List<Room>();
        ComboBox cbbListRoom = new ComboBox();


        private void btnBookGroup_Click(object sender, EventArgs e)
        {
            changeForm(pnToTalBookGroup);
            lbWelcome.Visible = false;
            //
            FormBookGroup frm = new FormBookGroup();
            frm.TopLevel = false;
            pnToTalBookGroup.Controls.Add(frm);
            frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.Show();
        }
        private void btnBookGroup_MouseDown(object sender, MouseEventArgs e)
        {
            btnBookGroup.BackColor = Color.Red;
        }
        private void btnBookGroup_MouseMove(object sender, MouseEventArgs e)
        {
            btnBookGroup.BackColor = Color.LightSkyBlue;
        }
        private void btnBookGroup_MouseLeave(object sender, EventArgs e)
        {
            btnBookGroup.BackColor = Color.DodgerBlue;
        }

        private void pnToTalBookGroup_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHistoryBill_MouseDown(object sender, MouseEventArgs e)
        {
            btnHistoryBill.BackColor = Color.Red;
        }

        private void btnHistoryBill_MouseLeave(object sender, EventArgs e)
        {
            btnHistoryBill.BackColor = Color.DodgerBlue;
        }

        private void btnHistoryBill_MouseMove(object sender, MouseEventArgs e)
        {
            btnHistoryBill.BackColor = Color.LightSkyBlue;
        }
    }
}
