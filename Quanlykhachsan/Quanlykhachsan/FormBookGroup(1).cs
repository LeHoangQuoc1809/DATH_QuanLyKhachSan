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
    public partial class FormBookGroup : Form
    {
        public Dictionary<string, Button> DicButton = new Dictionary<string, Button>();
        #region
        Employee empl = ProcessingEmployee.CrrEmployee;
        List<Room> listRoom = new List<Room>();
        Thread thread;
        bool flag = false;
        DateTime min = DateTime.Parse("1,1,1753");

        public FormBookGroup()
        {
            InitializeComponent();
            dtpTimeCheckin.Format = DateTimePickerFormat.Custom;
            dtpTimeCheckin.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dtpTimeCheckout.Format = DateTimePickerFormat.Custom;
            dtpTimeCheckout.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            lbNameEmployee.Text = empl.Name;
            dtpTimeCheckin.MinDate = DateTime.Now.AddMinutes(-1);
            dtpTimeCheckout.MinDate = min;
            dtpTimeCheckin.Value = DateTime.Now;
            dtpTimeCheckout.Value = dtpTimeCheckin.Value;
            ProcessingRoom.readFile_DicRoom();
            ProcessingRentalSingle.readFileRentalSingle();
            ProcessingRentalSingle.readFileRentalSingleSub();
            ProcessingRentalGroup.readFileRentalGroup();
            ProcessingRentalGroup.readFileRentalGroupSub();
            showListRental();
            //
            Control.CheckForIllegalCrossThreadCalls = false;
            thread = new Thread(run);
            thread.IsBackground = true;
            thread.Start();
            Thread.Sleep(TimeSpan.FromSeconds(0.5));
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
        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
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
                btnCheckout.Enabled = false;
                btnSreach.Enabled = false;
                btnCancel.BringToFront();
            }
            else
            {
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
                    // KT RentalSingleSub
                    List<Room> ListRoomEsixt = new List<Room>();
                    foreach (RentalSingle rs in ProcessingRentalSingle.DicRenSinSub.Values)
                    {
                        if (DateTime.Compare(rs.TimeCheckin.Add(new TimeSpan(-25, 0, 0)), rg.TimeCheckout) <= 0)
                        {
                            foreach (Room rm in rg.ListRoomBook)
                            {
                                if (rs.RoomBook.RoomCode == rm.RoomCode)
                                {
                                    ListRoomEsixt.Add(rm);
                                }
                            }
                        }
                    }
                    // KT RentalGroupSub
                    foreach (RentalGroup a in ProcessingRentalGroup.DicRenGroupSub.Values)
                    {
                        if (DateTime.Compare(a.TimeCheckin.Add(new TimeSpan(-25, 0, 0)), rg.TimeCheckout) <= 0)
                        {
                            foreach (Room room in a.ListRoomBook)
                            {
                                foreach (Room room1 in rg.ListRoomBook)
                                {
                                    if (room1.RoomCode == room.RoomCode)
                                    {
                                        ListRoomEsixt.Add(room1);
                                    }
                                }
                            }
                        }
                    }
                    if (ListRoomEsixt.Count > 0)
                    {
                        lbStatus.Text = "";
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
        CheckBox cb = new CheckBox();
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                lbStatus.Text = "Please Enter ID!!!";
            }
            else if (!ProcessingRentalGroup.DicRenGroup.ContainsKey(txtID.Text)
                    && !ProcessingRentalGroup.DicRenGroupSub.ContainsKey(txtID.Text))
            {
                lbStatus.Text = "ID is not ESIXT!!!";
            }
            else
            {
                string id = txtID.Text;
                List<Room> listRoomWillChangeStt = new List<Room>();
                if (!ProcessingRentalGroup.DicRenGroupSub.ContainsKey(id))
                {
                    listRoomWillChangeStt = ProcessingRentalGroup.DicRenGroup[id].ListRoomBook;
                }
                GroupBill gb = new GroupBill();
                cb.Checked = false;
                if(ProcessingRentalGroup.DicRenGroup.ContainsKey(id))
                {
                    gb.RentalGroup_Bill = ProcessingRentalGroup.DicRenGroup[id];
                }  
                else gb.RentalGroup_Bill = ProcessingRentalGroup.DicRenGroupSub[id];
                gb.EmployeePayment = ProcessingEmployee.CrrEmployee;
                gb.TimePayment = DateTime.Now;
                FormGroupBill fi = new FormGroupBill(gb, cb);
                fi.ShowDialog();
                if (cb.Checked)
                {
                    if(!ProcessingRentalGroup.DicRenGroupSub.ContainsKey(id))
                    {
                        foreach (Room room in listRoomWillChangeStt)
                        {
                            ProcessingRoom.DicRoom[room.RoomCode].Status = "DIRTY";
                        }
                        ProcessingRoom.writeFile_DicRoom();
                        ProcessingRentalGroup.DicRenGroup.Remove(id);
                        ProcessingRentalGroup.writeFileRentalGroup();
                    }
                    else
                    {
                        ProcessingRentalGroup.DicRenGroupSub.Remove(id);
                        ProcessingRentalGroup.writeFileRentalGroupSub();
                    }
                    txtID.Text = string.Empty;
                    txtName.Text = string.Empty;
                    txtSize.Text = string.Empty;
                    lbSize.Text = string.Empty;
                    lbRooms.Text = string.Empty;
                    dtpTimeCheckin.MinDate = DateTime.Now.AddMinutes(-1);
                    dtpTimeCheckin.Value = DateTime.Now;
                    dtpTimeCheckout.Value = DateTime.Now;
                    txtNODay.Text = string.Empty;
                    lbStatus.Text = string.Empty;
                    showListRental();
                }
            }
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
            btnCheckout.Enabled = true;
            btnSreach.Enabled = true;
        }
        private void btnSreach_Click(object sender, EventArgs e)
        {
            if (btnSreach.ForeColor == Color.Black)
            {
                refresh();
                txtID.Enabled = true;
                //
                btnCheckin.Enabled = false;
                btnCheckin.Text = "Check in";
                btnCheckin.ForeColor = Color.Black;
                btnCheckin.Font = new Font(btnCheckin.Font, FontStyle.Regular);
                //
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
            //
            btnCheckout.Enabled = true;
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
        #endregion

        public int getFloor(string RoomCode)
        {
            return RoomCode[0] - 48;
        }
        public List<int> getListFloor()
        {
            List<int> floor = new List<int>();
            foreach (Room r in ProcessingRoom.DicRoom.Values)
            {
                int f = getFloor(r.RoomCode);
                if (!floor.Contains(f))
                    floor.Add(f);
            }
            floor.Sort();
            return floor;
        }
        private void FormBookGroup_Load(object sender, EventArgs e)
        {
            ProcessingRoom.readFile_DicRoom();
            ProcessingRentalSingle.readFileRentalSingle();
            ProcessingRentalGroup.readFileRentalGroup();
            showDiagramRoom("EMPTY");
            updateNumberRoom();
            dtpTimeFilter.Format = DateTimePickerFormat.Custom;
            dtpTimeFilter.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            dtpTimeFilter.MinDate = DateTime.Now;
            //
        }
        public Button createButtonRoom(string RoomCode)
        {
            Button creBtn = new Button();
            creBtn.Size = new Size(105, 33);
            creBtn.Name = "btn" + RoomCode;
            creBtn.Text = RoomCode;
            creBtn.Font = new Font("Microsoft Sans Serif", 18.9F, System.Drawing.FontStyle.Bold);
            creBtn.ForeColor = Color.LightGoldenrodYellow;
            creBtn.BackColor = Color.Green;
            creBtn.TabStop = false;
            creBtn.FlatStyle = FlatStyle.Flat;
            creBtn.FlatAppearance.BorderSize = 0;
            creBtn.Click += CreBtn_Click;
            return creBtn;
        }
        private void CreBtn_Click(object sender, EventArgs e)
        {
            lbRooms.Text = "";
            Button btn = sender as Button;
            dicCB[btn.Text].Checked = !dicCB[btn.Text].Checked;
            int size = ProcessingRoom.DicRoom[btn.Text].TypeRoom.Size;
            Room a = new Room();
            a = ProcessingRoom.DicRoom[btn.Text];
            if (dicCB[btn.Text].Checked)
            {
                listRoom.Add(a);
                if (lbSize.Text == "") lbSize.Text = size.ToString();
                else
                {
                    int lbs = int.Parse(lbSize.Text);
                    lbs += size;
                    lbSize.Text = lbs.ToString();
                }
            }
            else
            {
                int lbs = int.Parse(lbSize.Text);
                lbs -= size;
                lbSize.Text = lbs.ToString();
                listRoom.Remove(a);
            }
            foreach (Room b in listRoom)
            {
                if (listRoom.IndexOf(b) == 0) lbRooms.Text += b.RoomCode;
                else lbRooms.Text += ", " + b.RoomCode;
            }
        }
        Dictionary<string, CheckBox> dicCB = new Dictionary<string, CheckBox>();
        private void createButtonVIP(FlowLayoutPanel flowLayoutPanel, Room room)
        {
            // 1
            //panel chứ phòng và loại phòng
            Panel panel = new Panel();
            panel.Size = new Size(105, 50);
            panel.BackColor = Color.Green;
            flowLayoutPanel.Controls.Add(panel);
            // checkbox
            CheckBox cb = new CheckBox();
            cb.AutoSize = false;
            cb.Size = new Size(15, 14);
            cb.Enabled = false;
            panel.Controls.Add(cb);
            cb.BringToFront();
            //
            dicCB.Add(room.RoomCode, cb);
            // phòng trong panel
            Button button = createButtonRoom(room.RoomCode);
            if (!DicButton.ContainsKey(room.RoomCode))
                DicButton.Add(room.RoomCode, button);
            panel.Controls.Add(button);
            // loại phòng trong panel
            Label labelR = new Label();
            labelR.Text = room.TypeRoom.Size.ToString() + "-" + room.TypeRoom.Rank.ToString();
            labelR.AutoSize = false;
            labelR.Size = new Size(105, 50);
            labelR.TextAlign = ContentAlignment.BottomCenter;
            labelR.Font = new Font("Microsoft Sans Serif", 10.9F, FontStyle.Bold);
            labelR.ForeColor = Color.Orchid;
            panel.Controls.Add(labelR);
        }


        public void showDiagramRoom(string status)
        {
            fpnRoomDiagram.Controls.Clear();
            List<int> floor = getListFloor();
            foreach (int f in floor)
            {
                bool flag = false;
                //
                FlowLayoutPanel fpanel_OnceFloor = new FlowLayoutPanel();
                FlowLayoutPanel flowLayoutPanel_ListRoomOfFloor = new FlowLayoutPanel();
                Label label_OrderFloor = new Label();
                createFlowLayoutPN_OnceFloor(fpanel_OnceFloor, f, flowLayoutPanel_ListRoomOfFloor, label_OrderFloor);
                //
                foreach (Room room in ProcessingRoom.DicRoom.Values)
                {
                    if (room.Status == status)
                        if (getFloor(room.RoomCode) == f)
                        {
                            flag = true;
                            createButtonVIP(flowLayoutPanel_ListRoomOfFloor, room);
                        }
                }
                if (flag)
                {
                    fpanel_OnceFloor.Controls.Add(label_OrderFloor);
                    fpanel_OnceFloor.Controls.Add(flowLayoutPanel_ListRoomOfFloor);
                    fpnRoomDiagram.Controls.Add(fpanel_OnceFloor);
                }
            }
        }
        private void updateNumberRoom()
        {
            lbFULL.Text = string.Empty;
            lbEMPTY.Text = string.Empty;
            lbREPAIR.Text = string.Empty;
            lbDIRTY.Text = string.Empty;
            lbCOMING.Text = string.Empty;
            lbAOT.Text = string.Empty;
            int ety = 0, dir = 0, rep = 0, full = 0, cmg = 0, tu = 0;
            foreach (Room r in ProcessingRoom.DicRoom.Values)
            {
                if (r.Status == "EMPTY") ety++;
                else if (r.Status == "DIRTY") dir++;
                else if (r.Status == "REPAIR") rep++;
                else if (r.Status == "COMING") cmg++;
                else if (r.Status == "TIME'S UP") tu++;
                else full++;
            }
            lbFULL.Text = "FULL";
            lbEMPTY.Text = "EMPTY";
            lbREPAIR.Text = "REPAIR";
            lbDIRTY.Text = "DIRTY";
            lbCOMING.Text = "COMING";
            lbAOT.Text = "TIME'S UP";
            lbFULL.Text = lbFULL.Text + " [" + full.ToString() + "]";
            lbEMPTY.Text = lbEMPTY.Text + " [" + ety.ToString() + "]";
            lbREPAIR.Text = lbREPAIR.Text + " [" + rep.ToString() + "]";
            lbDIRTY.Text = lbDIRTY.Text + " [" + dir.ToString() + "]";
            lbCOMING.Text = lbCOMING.Text + " [" + cmg.ToString() + "]";
            lbAOT.Text = lbAOT.Text + " [" + tu.ToString() + "]";
        }


        private void createFlowLayoutPN_OnceFloor(FlowLayoutPanel fpanel, int f, FlowLayoutPanel flowLayoutPanel, Label label)
        {
            fpanel.Size = new Size(905, 140);
            fpanel.BackColor = Color.Khaki;
            //
            label.Text = "FLOOR " + f.ToString();
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.AutoSize = false;
            label.Size = new Size(905, 20);
            label.TextAlign = ContentAlignment.MiddleCenter;
            label.Font = new Font(label.Font, FontStyle.Bold);
            label.ForeColor = Color.Violet;
            //
            flowLayoutPanel.Size = new Size(905, 110);
            flowLayoutPanel.AutoScroll = true;
        }
        private void btnFilterTime_Click(object sender, EventArgs e)
        {
            dicCB.Clear();
            //
            string status = "EMPTY";
            fpnRoomDiagram.Controls.Clear();
            List<int> floor = getListFloor();
            DateTime dt = dtpTimeFilter.Value;
            Dictionary<string, Room> listRoomWillCreate = new Dictionary<string, Room>();
            ProcessingRentalSingle.readFileRentalSingleSub();
            if (status == "<none>" || status == "DIRTY" || status == "REPAIR")
                showDiagramRoom(status);
            else
            {
                if (status == "EMPTY")
                {
                    //SG
                    foreach (RentalSingle rs in ProcessingRentalSingle.DicRenSin.Values)
                    {
                        if (DateTime.Compare(rs.TimeCheckout.AddHours(2), dt) <= 0)
                        {
                            Room rm = rs.RoomBook;
                            listRoomWillCreate.Add(rm.RoomCode, rm);
                        }
                    }
                    //SGSub
                    foreach (RentalSingle rs in ProcessingRentalSingle.DicRenSinSub.Values)
                    {
                        if (DateTime.Compare(rs.TimeCheckout.AddHours(2), dt) <= 0)
                        {
                            Room rm = rs.RoomBook;
                            listRoomWillCreate.Add(rm.RoomCode, rm);
                        }
                    }
                    //Grp
                    foreach (RentalGroup rg in ProcessingRentalGroup.DicRenGroup.Values)
                    {
                        if (DateTime.Compare(rg.TimeCheckout.AddHours(2), dt) <= 0)
                        {
                            foreach (Room rm in rg.ListRoomBook)
                            {
                                listRoomWillCreate.Add(rm.RoomCode, rm);
                            }
                        }
                    }
                    //GrpSub
                    foreach (RentalGroup rg in ProcessingRentalGroup.DicRenGroupSub.Values)
                    {
                        if (DateTime.Compare(rg.TimeCheckout.AddHours(2), dt) <= 0)
                        {
                            foreach (Room rm in rg.ListRoomBook)
                            {
                                listRoomWillCreate.Add(rm.RoomCode, rm);
                            }
                        }
                    }
                    //Ngoai cac rental
                    foreach (Room room in ProcessingRoom.DicRoom.Values)
                    {
                        if (!listRoomWillCreate.ContainsKey(room.RoomCode)
                            && !ProcessingRentalSingle.DicRenSin.ContainsKey(room.RoomCode)
                            && !ProcessingRentalSingle.DicRenSinSub.ContainsKey(room.RoomCode)
                            && !ProcessingRentalGroup.DicRenGroup.ContainsKey(room.RoomCode)
                            && !ProcessingRentalGroup.DicRenGroupSub.ContainsKey(room.RoomCode))
                            listRoomWillCreate.Add(room.RoomCode, room);
                    }
                }
            }
            foreach (int f in floor)
            {
                bool flag = false;

                //
                FlowLayoutPanel fpanel_OnceFloor = new FlowLayoutPanel();
                FlowLayoutPanel flowLayoutPanel_ListRoomOfFloor = new FlowLayoutPanel();
                Label label_OrderFloor = new Label();
                createFlowLayoutPN_OnceFloor(fpanel_OnceFloor, f, flowLayoutPanel_ListRoomOfFloor, label_OrderFloor);
                //
                //Check DicRenSinSub
                foreach (Room rm in listRoomWillCreate.Values)
                {
                    if (f == getFloor(rm.RoomCode))
                    {
                        if (!flag)
                        {
                            flag = true;
                            createButtonVIP(flowLayoutPanel_ListRoomOfFloor, rm);
                        }
                        else
                            createButtonVIP(flowLayoutPanel_ListRoomOfFloor, rm);
                    }
                }
                if (flag)
                {
                    fpanel_OnceFloor.Controls.Add(label_OrderFloor);
                    fpanel_OnceFloor.Controls.Add(flowLayoutPanel_ListRoomOfFloor);
                    fpnRoomDiagram.Controls.Add(fpanel_OnceFloor);
                    flag = false;
                }
                lbBorderTime.Visible = true;
            }
        }
        //
        private void FormBookGroup_EnabledChanged(object sender, EventArgs e)
        {
            thread.Abort();
            this.Close();
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan();
            bool flag = false;
            foreach (RentalSingle rs in ProcessingRentalSingle.DicRenSin.Values)
            {
                DateTime dt = DateTime.Now;
                if (rs.TypeRental == "Hour")
                {
                    ts = dt - rs.TimeCheckin;
                    if (ts.Days >= 1)
                    {
                        flag = true;
                        rs.TimeCheckout = rs.TimeCheckin.Add(new TimeSpan(1, 0, 0, 0));
                    }
                }
                else if (rs.TypeRental == "OverNight")
                {
                    if (dt.Hour >= 10)
                        flag = true;
                }
                else
                {
                    if (DateTime.Compare(dt, rs.TimeCheckout) >= 0)
                        flag = true;
                }
                if (flag)
                {
                    rs.RoomBook.Status = "TIME'S UP";
                    ProcessingRoom.DicRoom[rs.RoomBook.RoomCode].Status = "TIME'S UP";
                    ProcessingRoom.writeFile_DicRoom();
                    ProcessingRentalSingle.writeFileRentalSingle();
                    flag = false;
                }
            }
            updateNumberRoom();
        }
        private void btnCheckin_TextChanged(object sender, EventArgs e)
        {
            if (btnCheckin.Text != "Check in")
            {
                fpnRoomDiagram.Enabled = true;
            }
            else
            {
                listRoom.Clear();
                foreach (CheckBox cb in dicCB.Values)
                {
                    cb.Checked = false;
                }
                fpnRoomDiagram.Enabled = false;
            }
        }
    }
}

