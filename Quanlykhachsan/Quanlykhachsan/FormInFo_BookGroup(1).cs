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
    public partial class FormInFo_BookGroup : Form
    {
        Employee empl = ProcessingEmployee.CrrEmployee;
        List<Room> listRoom;
        ComboBox cbbListRoom;
        Thread thread;
        bool flag = false;
        DateTime min = DateTime.Parse("1,1,1753");
        private void addListRoom()
        {
            for (int i = 0; i < cbbListRoom.Items.Count; i++)
            {
                Room room = new Room();
                room = ProcessingRoom.DicRoom[cbbListRoom.Items[i].ToString()];
                listRoom.Add(room);
            }
            cbbListRoom.Items.Clear();
        }
        private void FormInFo_BookGroup_Load(object sender, EventArgs e)
        {
            dtpTimeCheckin.Format = DateTimePickerFormat.Custom;
            dtpTimeCheckin.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dtpTimeCheckout.Format = DateTimePickerFormat.Custom;
            dtpTimeCheckout.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            lbNameEmployee.Text = empl.Name;
            dtpTimeCheckin.MinDate = DateTime.Now.AddMinutes(-1);
            dtpTimeCheckout.MinDate = min;
            dtpTimeCheckin.Value = DateTime.Now;
            dtpTimeCheckout.Value = dtpTimeCheckin.Value;
            ProcessingRentalGroup.readFileRentalGroup();
            ProcessingRentalGroup.readFileRentalGroupSub();
            showListRental();
        }
        private void refresh()
        {
            txtName.Text = string.Empty;
            txtID.Text = string.Empty;
            lbSize.Text = string.Empty;
            txtSize.Text = string.Empty;
            lbRooms.Text = string.Empty;
            txtNODay.Text = string.Empty;
            dtpTimeCheckin.MinDate = DateTime.Now.Add(new TimeSpan(0, -1, 0));
            dtpTimeCheckout.MinDate = min;
            dtpTimeCheckin.Value = DateTime.Now;
            dtpTimeCheckout.Value = dtpTimeCheckin.Value;
        }
        public FormInFo_BookGroup(ComboBox lr)
        {
            InitializeComponent();
            cbbListRoom = lr;
            listRoom = new List<Room>();
            Control.CheckForIllegalCrossThreadCalls = false;
            thread = new Thread(run);
            thread.IsBackground = true;
            thread.Start();
            Thread.Sleep(TimeSpan.FromSeconds(0.5));
        }
        void run()
        {
            while (!false)
            {
                if (btnCheckin.Text == "Checkin")
                    cameGroup();
                if (btnCheckin.Text != "Apply" && !flag)
                    runTimeCheckin();
                //if (btnCheckin.Text !="Apply"&& !flag)
                //    runTimeCheckout();
            }
        }
        void cameGroup()
        {
            foreach (RentalGroup rg in ProcessingRentalGroup.DicRenGroupSub.Values)
            {
                DateTime cin = rg.TimeCheckin;
                DateTime cout = rg.TimeCheckout;
                if (DateTime.Compare(DateTime.Now, cin.Add(new TimeSpan(-24, 0, 0))) >= 0)
                {
                    List<Room> rooms = rg.ListRoomBook;
                    changeStatusRoom("COMING", ref rooms);
                    rg.ListRoomBook = rooms;
                }
                if (DateTime.Compare(DateTime.Now, cin) >= 0)
                {
                    List<Room> rooms = rg.ListRoomBook;
                    changeStatusRoom("FULL", ref rooms);
                    rg.ListRoomBook = rooms;
                }
            }
        }
        void runTimeCheckin()
        {
            dtpTimeCheckin.MinDate = DateTime.Now.Add(new TimeSpan(0, -1, 0));
            dtpTimeCheckin.Value = DateTime.Now;
        }
        //void runTimeCheckout()
        //{
        //    dtpTimeCheckout.Value = DateTime.Now;
        //}
        private void changeStatusRoom(string status, ref List<Room> lr)
        {
            foreach (Room room in lr)
            {
                room.Status = status;
            }
        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (btnCheckin.Text == "Check in")
            {
                cbbListRoom.Items.Clear();
                refresh();
                btnCheckin.Text = "Apply";
                btnCheckin.ForeColor = Color.Red;
                btnCheckin.Font = new Font(btnCheckin.Font, FontStyle.Bold);
                //
                txtName.Enabled = true;
                txtID.Enabled = true;
                txtSize.Enabled = true;
                dtpTimeCheckin.Enabled = true;
                txtNODay.Enabled = true;
                btnCancel.BringToFront();
            }
            else
            {
                addListRoom();
                if (txtName.Text == "" || txtID.Text == "" || txtSize.Text == "")
                {
                    lbStatus.Text = "You must enter all infomation!!!";
                }
                else if (txtID.Text.Length < 12)
                {
                    lbStatus.Text = "ID must have 12 characters!!!";
                }
                else if (txtNODay.Text == "")
                {
                    lbStatus.Text = "You must enter Number of Day!!!";
                }
                else if (lbSize.Text == "")
                {
                    lbStatus.Text = "You must choose Room!!!";
                }
                else if (int.Parse(lbSize.Text) < int.Parse(txtSize.Text))
                {
                    lbStatus.Text = "Size is not enough!!!";
                }
                else
                {
                    RentalGroup rg = new RentalGroup();
                    rg.NameCustomer = txtName.Text;
                    rg.IDCustomer = txtID.Text;
                    rg.NOP = int.Parse(txtSize.Text);
                    rg.SizeListRoom = int.Parse(lbSize.Text);
                    rg.TimeCheckin = dtpTimeCheckin.Value;
                    rg.TimeCheckout = dtpTimeCheckout.Value;
                    rg.EmployeeBook.Name = lbNameEmployee.Text;
                    rg.Nod = int.Parse(txtNODay.Text);
                    rg.ListRoomBook = listRoom;
                    // KT phòng ko đủ điều kiện để vào RentalSub
                    List<Room> ListRoomEsixt = new List<Room>();
                    foreach (RentalGroup a in ProcessingRentalGroup.DicRenGroupSub.Values)
                    {
                        if (DateTime.Compare(a.TimeCheckin.Add(new TimeSpan(-25, 0, 0)), rg.TimeCheckout) <= 0)
                        {
                            foreach (Room room in a.ListRoomBook)
                            {
                                foreach (Room room1 in rg.ListRoomBook)
                                {
                                    if (room1.RoomCode==room.RoomCode)
                                    {
                                        ListRoomEsixt.Add(room1);
                                    }    
                                }
                            }
                        }
                    }
                    if(ListRoomEsixt.Count>0)
                    {
                        foreach (Room a in ListRoomEsixt)
                        {
                            if (ListRoomEsixt.IndexOf(a) == 0)
                                lbStatus.Text += a.RoomCode;
                            else lbStatus.Text += ", " + a.RoomCode;
                        }
                        lbStatus.Text += " Is Full!!!";
                    }
                    else
                    {
                        if (DateTime.Compare(DateTime.Now, rg.TimeCheckin.Add(new TimeSpan(-24, 0, 0))) < 0)
                        {
                            if (!ProcessingRentalGroup.DicRenGroupSub.ContainsKey(rg.IDCustomer))
                            {
                                ProcessingRentalGroup.DicRenGroupSub.Add(rg.IDCustomer, rg);
                                ProcessingRentalGroup.writeFileRentalGroupSub();
                            }
                        }
                        else
                        {
                            List<Room> lr = rg.ListRoomBook;
                            changeStatusRoom("FULL", ref lr);
                            rg.ListRoomBook = lr;
                            ProcessingRentalGroup.addRentalGroup(rg);
                            ProcessingRentalGroup.writeFileRentalGroup();
                            ProcessingRoom.writeFile_DicRoom();
                        }
                        btnCheckin.Text = "Check in";
                        btnCheckin.ForeColor = Color.Black;
                        btnCheckin.Font = new Font(btnCheckin.Font, FontStyle.Regular);
                    }
                    showListRental();
                }
            }
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            showListRental();
            //
            refresh();
            //
            lbStatus.Text = "";
            //
            txtID.Enabled = false;
            txtName.Enabled = false;
            txtSize.Enabled = false;
            dtpTimeCheckin.Enabled = false;
            txtNODay.Enabled = false;
            //
            btnCheckin.Text = "Check in";
            btnCheckin.ForeColor = Color.Black;
            btnCheckin.Font = new Font(btnCheckin.Font, FontStyle.Regular);
            //
            btnSreach.ForeColor = Color.Black;
            btnSreach.Font = new Font(btnSreach.Font, FontStyle.Regular);
            btnCheckin.Enabled = true;
            //
        }
        private void btnSreach_Click(object sender, EventArgs e)
        {
            if (btnSreach.ForeColor == Color.Black)
            {
                refresh();
                txtID.Enabled = true;
                btnCheckin.Enabled = false;
                btnSreach.ForeColor = Color.Red;
                btnSreach.Font = new Font(btnSreach.Font, FontStyle.Bold);
            }
            else
            {
                if (ProcessingRentalGroup.DicRenGroup.ContainsKey(txtID.Text)
                    || ProcessingRentalGroup.DicRenGroupSub.ContainsKey(txtID.Text))
                {
                    RentalGroup rg = new RentalGroup();
                    if (ProcessingRentalGroup.DicRenGroup.ContainsKey(txtID.Text))
                        rg = ProcessingRentalGroup.DicRenGroup[txtID.Text];
                    if (ProcessingRentalGroup.DicRenGroupSub.ContainsKey(txtID.Text))
                        rg = ProcessingRentalGroup.DicRenGroupSub[txtID.Text];
                    txtID.Text = rg.IDCustomer.ToString();
                    txtName.Text = rg.NameCustomer.ToString();
                    txtSize.Text = rg.NOP.ToString();
                    lbSize.Text = rg.SizeListRoom.ToString();
                    foreach (Room a in rg.ListRoomBook)
                    {
                        if (rg.ListRoomBook.IndexOf(a) == 0)
                            lbRooms.Text += a.RoomCode;
                        else lbRooms.Text += ", " + a.RoomCode;
                    }
                    dtpTimeCheckin.MinDate = rg.TimeCheckin.Add(new TimeSpan(0, -1, 0));
                    dtpTimeCheckout.MinDate = min;
                    dtpTimeCheckin.Value = rg.TimeCheckin;
                    dtpTimeCheckout.Value = rg.TimeCheckout;
                    txtNODay.Text = rg.Nod.ToString();
                    lbNameEmployee.Text = rg.EmployeeBook.Name.ToString();
                    lbStatus.Text = "Had found!!!";
                    txtID.Enabled = false;
                    btnSreach.ForeColor = Color.Black;
                    btnSreach.Font = new Font(btnSreach.Font, FontStyle.Regular);
                }
                else
                {
                    lbStatus.Text = "ID is not EXiST!!!";
                }
            }
        }
        private void txtNODay_TextChanged(object sender, EventArgs e)
        {
            if (txtNODay.Text != "")
            {
                dtpTimeCheckout.MinDate = dtpTimeCheckin.Value.Add(new TimeSpan(0, -1, 0));
                dtpTimeCheckout.Value = dtpTimeCheckin.Value;
                dtpTimeCheckout.Value = dtpTimeCheckout.Value.AddDays(int.Parse(txtNODay.Text));
            }
            else
            {
                dtpTimeCheckout.MinDate = dtpTimeCheckin.Value.Add(new TimeSpan(0, -1, 0));
                dtpTimeCheckout.Value = dtpTimeCheckin.Value;
            }
        }
        private void dtpTimeCheckin_ValueChanged(object sender, EventArgs e)
        {
            if (txtNODay.Text != "")
            {
                dtpTimeCheckout.MinDate = dtpTimeCheckin.Value.Add(new TimeSpan(0, -1, 0));
                dtpTimeCheckout.Value = dtpTimeCheckin.Value;
                dtpTimeCheckout.Value = dtpTimeCheckout.Value.AddDays(int.Parse(txtNODay.Text));
            }
            else
            {
                dtpTimeCheckout.MinDate = dtpTimeCheckin.Value.Add(new TimeSpan(0, -1, 0));
                dtpTimeCheckout.Value = dtpTimeCheckin.Value;
            }
        }
        private void showListRental()
        {
            ProcessingRentalGroup.readFileRentalGroup();
            //dgvDsRental.DataSource = ProcessingRentalGroup.DicRenGroup.Values.ToList();
            int i = 0;
            dgvListMain.Rows.Clear();
            foreach (RentalGroup rg in ProcessingRentalGroup.DicRenGroup.Values)
            {
                dgvListMain.Rows.Add(1);
                dgvListMain.Rows[i].Cells["IDCell"].Value = rg.IDCustomer.ToString();
                dgvListMain.Rows[i++].Cells["NameCell"].Value = rg.NameCustomer.ToString();
            }
            i = 0;
            dgvListSub.Rows.Clear();
            foreach (RentalGroup rg in ProcessingRentalGroup.DicRenGroupSub.Values)
            {
                dgvListSub.Rows.Add(1);
                dgvListSub.Rows[i].Cells["IDCellSub"].Value = rg.IDCustomer.ToString();
                dgvListSub.Rows[i++].Cells["NameCellSub"].Value = rg.NameCustomer.ToString();
            }
        }
        private void dgvDsRental_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refresh();
            if (e.RowIndex != -1)
            {
                txtName.Text = dgvListMain.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtID.Text = dgvListMain.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtSize.Text = ProcessingRentalGroup.DicRenGroup[txtID.Text].NOP.ToString();
                lbSize.Text = ProcessingRentalGroup.DicRenGroup[txtID.Text].SizeListRoom.ToString();
                foreach (Room b in ProcessingRentalGroup.DicRenGroup[txtID.Text].ListRoomBook)
                {
                    if (ProcessingRentalGroup.DicRenGroup[txtID.Text].ListRoomBook.IndexOf(b) == 0)
                        lbRooms.Text += b.RoomCode;
                    else lbRooms.Text += ", " + b.RoomCode;
                }
                dtpTimeCheckin.MinDate = ProcessingRentalGroup.DicRenGroup[txtID.Text].TimeCheckin.Add(new TimeSpan(0, -1, 0));
                dtpTimeCheckout.MinDate = min;
                dtpTimeCheckin.Value = ProcessingRentalGroup.DicRenGroup[txtID.Text].TimeCheckin;
                dtpTimeCheckout.Value = ProcessingRentalGroup.DicRenGroup[txtID.Text].TimeCheckout;
                txtNODay.Text = ProcessingRentalGroup.DicRenGroup[txtID.Text].Nod.ToString();
                lbNameEmployee.Text = ProcessingRentalGroup.DicRenGroup[txtID.Text].EmployeeBook.Name.ToString();
                flag = true;
            }
            //
            txtID.Enabled = false;
            btnSreach.ForeColor = Color.Black;
            btnSreach.Font = new Font(btnSreach.Font, FontStyle.Regular);
            //
            btnCheckin.Text = "Check in";
            btnCheckin.ForeColor = Color.Black;
            btnCheckin.Font = new Font(btnCheckin.Font, FontStyle.Regular);
        }
        private void dgvListSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            refresh();
            if (e.RowIndex != -1)
            {
                txtID.Text = dgvListSub.Rows[e.RowIndex].Cells[0].Value.ToString();
                RentalGroup rg = ProcessingRentalGroup.DicRenGroupSub[txtID.Text];
                txtName.Text = dgvListSub.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtSize.Text = rg.NOP.ToString();
                lbSize.Text = rg.SizeListRoom.ToString();
                foreach (Room b in rg.ListRoomBook)
                {
                    if (rg.ListRoomBook.IndexOf(b) == 0)
                        lbRooms.Text += b.RoomCode;
                    else lbRooms.Text += ", " + b.RoomCode;
                }
                dtpTimeCheckin.MinDate = rg.TimeCheckin.Add(new TimeSpan(0, -1, 0));
                dtpTimeCheckout.MinDate = min;
                dtpTimeCheckin.Value = rg.TimeCheckin;
                dtpTimeCheckout.Value = rg.TimeCheckout;
                txtNODay.Text = rg.Nod.ToString();
                lbNameEmployee.Text = rg.EmployeeBook.Name.ToString();
                flag = true;
            }
            //
            txtID.Enabled = false;
            btnSreach.ForeColor = Color.Black;
            btnSreach.Font = new Font(btnSreach.Font, FontStyle.Regular);
            //
            btnCheckin.Text = "Check in";
            btnCheckin.ForeColor = Color.Black;
            btnCheckin.Font = new Font(btnCheckin.Font, FontStyle.Regular);
        }
        private void FormInFo_BookGroup_FormClosing(object sender, FormClosingEventArgs e)
        {
            thread.Abort();
        }
        private void FormInFo_BookGroup_EnabledChanged(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
                e.Handled = true;
        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
        private void txtNODay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void lbSize_TextChanged(object sender, EventArgs e)
        {
            Label tb = (Label)sender;
            if (tb.Text != "" && int.Parse(tb.Text) < 0)
                tb.Text = "0";
        }

        private void btnCheckin_TextChanged(object sender, EventArgs e)
        {
          
        }
    }
}
