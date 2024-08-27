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
    public partial class FormBookSingle : Form
    {
        DateTime dtMinDate = new DateTime(1753, 1, 1);
        public Dictionary<string, Button> DicButton = new Dictionary<string, Button>();
        Thread thread;
        // string roomcode = "";
        public FormBookSingle()
        {
            ProcessingRoom.readFile_DicRoom();

            ProcessingRentalSingle.readFileRentalSingle();
            ProcessingRentalSingle.readFileRentalSingleSub();

            ProcessingRentalGroup.readFileRentalGroup();
            ProcessingRentalGroup.readFileRentalGroupSub();
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
            thread = new Thread(run);
            thread.IsBackground = true;
            thread.Start();
            //Thread.Sleep(TimeSpan.FromSeconds(2));
            //roomcode = lbRoomCode.Text;
        }
        //<run>
        void run()
        {
            while (true)
            {
                if (lbRoomCode.Text != "")
                {
                    came();
                    if (ProcessingRentalSingle.findRentalSingle(lbRoomCode.Text) == null)
                    {
                        runTimeIn();
                        runTimeOut();
                    }
                    else
                        showProvisionalMoeny();
                }

            }
        }
        void runTimeIn()
        {
            if (ProcessingRentalSingle.findRentalSingle(lbRoomCode.Text) == null && !cbTimeCheckin.Checked)
            {
                dtpTimeCheckin.Value = DateTime.Now;
            }
        }
        void runTimeOut()
        {

            if (!rdoDay.Checked)
            {
                dtpTimeCheckout.Value = DateTime.Now;
            }
        }
        double oldmoney = 0;
        void showProvisionalMoeny()
        {
            string str = "0";
            string rc = lbRoomCode.Text;

            if (ProcessingRentalSingle.findRentalSingle(rc) != null)
            {
                RentalSingle rs = ProcessingRentalSingle.DicRenSin[rc];
                if (rdoDay.Checked)
                {
                    str = ProcessingRentalSingle.calculateMoneyDay(rs).ToString();
                }
                else if (rdoHour.Checked)
                {
                    str = ProcessingRentalSingle.calculateMoneyHour(rs).ToString();
                }
                else
                {
                    str = ProcessingRentalSingle.calculateMoneyOverNight(rs).ToString();
                }
                if (oldmoney != double.Parse(str))
                {
                    oldmoney = double.Parse(str);
                    lbProvisionalMoney.Text = str;
                }

            }
            else
                lbProvisionalMoney.Text = "";
        }
        void came()
        {
            string str = "";
            List<string> deletewill = new List<string>();
            int d = 0, h = 0, m = 0, s = 0;
            if (ProcessingRentalSingle.DicRenSinSub != null && ProcessingRentalSingle.DicRenSinSub.Count > 0)
            {
                foreach (RentalSingle rs in ProcessingRentalSingle.DicRenSinSub.Values)
                {
                    TimeSpan ts = new TimeSpan();
                    ts = rs.TimeCheckin - DateTime.Now;
                    d = ts.Days;
                    //
                    if (d < 1)
                    {
                        rs.RoomBook.Status = "COMING";
                        ProcessingRoom.DicRoom[rs.RoomBook.RoomCode].Status = "COMING";
                        ProcessingRentalSingle.addRentalSingle(rs);
                        ProcessingRentalSingle.writeFileRentalSingle();
                        ProcessingRoom.writeFile_DicRoom();
                        str = rs.RoomBook.RoomCode;
                        deletewill.Add(str);
                    }
                }

                foreach (string strg in deletewill)
                {
                    ProcessingRentalSingle.DicRenSinSub.Remove(strg);
                }
            }
            if (ProcessingRentalSingle.DicRenSin.Count > 0)
                foreach (RentalSingle rs in ProcessingRentalSingle.DicRenSin.Values)
                {
                    if (rs.RoomBook.Status == "FULL")
                        continue;
                    TimeSpan ts = new TimeSpan();
                    ts = DateTime.Now - rs.TimeCheckin;
                    d = ts.Days;
                    h = ts.Hours;
                    m = ts.Minutes;
                    s = ts.Seconds;
                    s += m * 60 + h * 60 * 60 + d * 24 * 60 * 60;
                    if (s >= 0 && rs.RoomBook.Status == "COMING")
                    {
                        rs.RoomBook.Status = "FULL";
                        ProcessingRoom.DicRoom[rs.RoomBook.RoomCode].Status = "FULL";
                        ProcessingRoom.readFile_DicRoom();
                        ProcessingRentalSingle.writeFileRentalSingle();
                        break;
                    }
                    else break;
                }
        }
        //</run>
        #region
        private void cbTimeCheckin_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbTimeCheckin = (CheckBox)sender;
            if (cbTimeCheckin.Checked)
                dtpTimeCheckin.Enabled = true;
            else
                dtpTimeCheckin.Enabled = false;
        }
        private void cbTimeCheckout_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cbTimeCheckout = (CheckBox)sender;
            if (cbTimeCheckout.Checked)
                dtpTimeCheckout.Enabled = true;
            else
                dtpTimeCheckout.Enabled = false;
        }
        private void processingRadioButton(RentalSingle rs)
        {
            if (rs.TypeRental == "Hour")
                rdoHour.Checked = true;
            else if (rs.TypeRental == "Day")
            {
                rdoDay.Checked = true;
                txtNODay.Text = rs.Nod.ToString();
            }
            else rdoOverNight.Checked = true;
        }
        public void showInFoRoom(string roomcode)
        {
            if (ProcessingRentalSingle.findRentalSingle(roomcode) != null)
            {
                RentalSingle rs = new RentalSingle();
                rs = ProcessingRentalSingle.DicRenSin[roomcode];
                lbRoomCode.Text = roomcode;
                txtName.Text = rs.NameCustomer;
                txtID.Text = rs.IDCustomer;
                lbSize.Text = rs.RoomBook.TypeRoom.Size.ToString();
                lbRank.Text = rs.RoomBook.TypeRoom.Rank;
                dtpTimeCheckin.Value = rs.TimeCheckin;
                dtpTimeCheckout.Value = rs.TimeCheckout;
                for (int i = 0; i < cbbStatus.Items.Count; i++)
                {
                    if (cbbStatus.Items[i].ToString() == rs.RoomBook.Status)
                    {
                        cbbStatus.SelectedIndex = i;
                        break;
                    }
                }
                lbNameEmployee.Text = rs.EmployeeBook.Name;
                processingRadioButton(rs);
                //processing3Radio(rdoHour, rdoOverNight, rdoDay);
                //
                RentalPrice price = ProcessingRentalSingle.DicRenSin[roomcode].Price;
                lbDay.Text = price.Day.ToString();
                lbOverNight.Text = price.OverNight.ToString();
                lbFirstHour.Text = price.FirstHour.ToString();
                lbNormalHour.Text = price.NormalHour.ToString();
                txtNODay.Text = rs.Nod.ToString();

            }
            else
            {
                lbRoomCode.Text = roomcode;
                lbSize.Text = ProcessingRoom.DicRoom[roomcode].TypeRoom.Size.ToString();
                lbRank.Text = ProcessingRoom.DicRoom[roomcode].TypeRoom.Rank;
                for (int i = 0; i < cbbStatus.Items.Count; i++)
                {
                    if (cbbStatus.Items[i].ToString() == ProcessingRoom.DicRoom[roomcode].Status)
                    {
                        cbbStatus.SelectedIndex = i;
                        break;
                    }
                }
                //
                RentalPrice price = ProcessingTypeRoom.DicRentalPrice[ProcessingRoom.DicRoom[roomcode].TypeRoom.Name];
                lbDay.Text = price.Day.ToString();
                lbOverNight.Text = price.OverNight.ToString();
                lbFirstHour.Text = price.FirstHour.ToString();
                lbNormalHour.Text = price.NormalHour.ToString();
                //
                lbNameEmployee.Text = string.Empty;
                txtNODay.Text = "";
            }
        }

        private void FormInFoRoom_EnabledChanged(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdoDay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoDay.Checked)
            {
                cbTimeCheckin.Enabled = true;
                label12.Visible = true;
                txtNODay.Visible = true;
            }
            else
            {
                cbTimeCheckin.Enabled = true;
                label12.Visible = false;
                txtNODay.Visible = false;
            }
            if (cbbStatus.SelectedIndex == 0)
                rdoDay.Enabled = true;
            else rdoDay.Enabled = false;
        }

        private void txtNODay_TextChanged(object sender, EventArgs e)
        {
            if (txtNODay.Text != "")
            {
                if (cbTimeCheckin.Checked)
                {
                    dtpTimeCheckout.Value = dtpTimeCheckin.Value;
                }
                dtpTimeCheckout.Value = dtpTimeCheckout.Value.AddDays(int.Parse(txtNODay.Text));
            }
            else
            {
                dtpTimeCheckout.Value = DateTime.Now;
            }
        }

        private void dtpTimeCheckin_ValueChanged(object sender, EventArgs e)
        {
            if (dtpTimeCheckin.Value.Hour >= 23 || dtpTimeCheckin.Value.Hour <= 4)
            {
                rdoOverNight.Enabled = true;
                rdoHour.Enabled = false;
            }
            else
            {
                rdoHour.Enabled = true;
                rdoOverNight.Enabled = false;
            }
        }

        private void dtpTimeCheckout_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNODay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !(char.IsDigit(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void rdoHour_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
                e.Handled = true;
        }
        #endregion

        #region
        public void refreshBtn()
        {
            //BTN checkin
            if (cbbStatus.SelectedIndex == 0)
                btnCheckin.Enabled = true;
            else
                btnCheckin.Enabled = false;
            //
            if (cbbStatus.SelectedIndex != 2 && cbbStatus.SelectedIndex != 5)
                btnCheckout.Enabled = false;
            else if (cbbStatus.SelectedIndex != 1)
            {
                btnCheckout.Enabled = true;
            }
            if (cbbStatus.SelectedIndex != 3 && cbbStatus.SelectedIndex != 4 && cbbStatus.SelectedIndex !=0)
                btnModify.Enabled = false;
            else
                btnModify.Enabled = true;
        }
        private void btnCheckin_Click(object sender, EventArgs e)
        {
            if (btnCheckin.Text == "Check in")
            {
                if (cbbStatus.Text == "EMPTY" && ProcessingRentalSingle.findRentalSingle(lbRoomCode.Text) == null)
                {
                    ////
                    btnModify.Enabled = false;
                    btnCheckout.Enabled = false;
                    //
                    btnCheckin.Text = "Apply";
                    btnCheckin.ForeColor = Color.Red;
                    btnCheckin.Font = new Font(btnCheckin.Font, FontStyle.Bold);
                    //
                    txtName.Enabled = true;
                    txtID.Enabled = true;
                    grbTypeRental.Enabled = true;
                    if (ProcessingRentalSingle.DicRenSinSub.ContainsKey(lbRoomCode.Text))
                    {
                        dtpTimeCheckin.MaxDate = ProcessingRentalSingle.DicRenSinSub[lbRoomCode.Text].TimeCheckin;
                    }
                }
            }
            else
            {

                if (txtName.Text == "" || txtID.Text == "")
                {
                    lbStatus.Text = "You must enter all infomation!!!";
                }
                else if (txtID.Text.Length < 12)
                {
                    lbStatus.Text = "ID must have 12 characters!!!";
                }
                else if (rdoDay.Checked && txtNODay.Text == "")
                {
                    lbStatus.Text = "You must enter Number of Day!!!";
                }
                else
                {

                    RentalSingle rs = new RentalSingle();
                    //
                    Room room = new Room();
                    room = ProcessingRoom.DicRoom[lbRoomCode.Text];
                    rs.RoomBook = room;
                    rs.EmployeeBook = ProcessingEmployee.CrrEmployee;
                    rs.IDCustomer = txtID.Text;
                    rs.NameCustomer = txtName.Text;
                    rs.TimeCheckin = dtpTimeCheckin.Value;
                    if (rdoDay.Checked)
                        rs.TimeCheckout = dtpTimeCheckout.Value;


                    bool flag = false;
                    //Kiem tra Reatal Single Sub
                    foreach (RentalSingle rsb in ProcessingRentalSingle.DicRenSinSub.Values)
                    {
                        if (rsb.RoomBook.RoomCode == rs.RoomBook.RoomCode && DateTime.Compare(rsb.TimeCheckin.Add(new TimeSpan(-25, 0, 0)), rs.TimeCheckout) <= 0)
                        {
                            lbStatus.Text = "Room will be COMING at " + rsb.TimeCheckin.Add(new TimeSpan(-25, 0, 0));
                            flag = true;
                        }
                    }
                    // KT  RentalGroupSub
                    foreach (RentalGroup a in ProcessingRentalGroup.DicRenGroupSub.Values)
                    {
                        if (DateTime.Compare(a.TimeCheckin.Add(new TimeSpan(-25, 0, 0)), rs.TimeCheckout) <= 0)
                        {
                            foreach (Room rom in a.ListRoomBook)
                            {
                                if (rom.RoomCode == rs.RoomBook.RoomCode)
                                {
                                    lbStatus.Text = "Room will be COMING at " + a.TimeCheckin.Add(new TimeSpan(-25, 0, 0));
                                    flag = true;
                                }
                            }
                        }
                    }
                    if (!flag)
                    {
                        //
                        string status = "EMPTY";
                        if (cbTimeCheckin.Checked)
                        {
                            status = "EMPTY";
                        }
                        else
                        {
                            status = "FULL";
                            modifyLabel(lbFULL, lbEMPTY);
                        }
                        rs.RoomBook.Status = status;

                        //CheckBoxDay


                        //RadioButton
                        if (rdoHour.Checked)
                            rs.TypeRental = rdoHour.Text;
                        else if (rdoOverNight.Checked)
                            rs.TypeRental = rdoOverNight.Text;
                        else
                        {
                            rs.TypeRental = rdoDay.Text;
                            rs.Nod = int.Parse(txtNODay.Text);
                        }
                        //
                        RentalPrice price = new RentalPrice();
                        price = ProcessingTypeRoom.DicRentalPrice[rs.RoomBook.TypeRoom.Name];
                        rs.Price = price;
                        //
                        if (cbTimeCheckin.Checked)
                        //set ngay nhan phong thi them phieu thue vao 1 danh sach CON
                        {
                            if (!ProcessingRentalSingle.DicRenSinSub.ContainsKey(rs.RoomBook.RoomCode))
                            {
                                ProcessingRentalSingle.DicRenSinSub.Add(rs.RoomBook.RoomCode, rs);
                                ProcessingRentalSingle.writeFileRentalSingleSub();
                            }
                        }
                        else
                        //nhan phong ngay lap tuc thi them phieu thue vao danh sach chinh thuc
                        {
                            //Thay doi trong dicRoom
                            ProcessingRoom.DicRoom[lbRoomCode.Text].Status = status;
                            //Thay doi trong rental
                            rs.RoomBook.Status = status;
                            lbNameEmployee.Text = rs.EmployeeBook.Name;
                            ProcessingRoom.writeFile_DicRoom();
                            ProcessingRentalSingle.addRentalSingle(rs);
                            ProcessingRentalSingle.writeFileRentalSingle();
                        }
                        //
                        btnCheckin.Text = "Check in";
                        btnCheckin.ForeColor = Color.Black;
                        btnCheckin.Font = new Font(btnCheckin.Font, FontStyle.Regular);
                        //
                        grbTypeRental.Enabled = false;
                        txtName.Enabled = false;
                        txtID.Enabled = false;
                        lbStatus.Text = "Check in SUCCESSFULLY!!!";
                        refreshBtn();
                    }
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (btnCheckin.Text != "Check in")
            {
                btnCheckin.Text = "Check in";
                btnCheckin.ForeColor = Color.Black;
                btnCheckin.Font = new Font(btnCheckin.Font, FontStyle.Regular);
                //
                refreshBtn();
                rdoHour.Checked = true;
                grbTypeRental.Enabled = false;
                txtNODay.Enabled = false;
                label12.Visible = false;
                txtNODay.Visible = false;
                //
            }
            else if (btnCheckout.Text != "Check out")
            {
                btnCheckout.Text = "Check out";
                btnCheckout.ForeColor = Color.Black;
                btnCheckout.Font = new Font(btnCheckin.Font, FontStyle.Regular);
                //
                btnModify.Enabled = true;
                btnCheckin.Enabled = true;
            }
            else if (btnModify.Text != "Modify")
            {
                btnModify.Text = "Modify";
                btnModify.ForeColor = Color.Black;
                btnModify.Font = new Font(btnCheckin.Font, FontStyle.Regular);
                //
                btnCheckout.Enabled = true;
                btnCheckin.Enabled = true;
                fpnRoomDiagram.Enabled = true;
                cbbStatus.Items.Clear();
                cbbStatus.Items.Add("EMPTY");
                cbbStatus.Items.Add("COMING");
                cbbStatus.Items.Add("FULL");
                cbbStatus.Items.Add("DIRTY");
                cbbStatus.Items.Add("REPAIR");
                cbbStatus.Items.Add("TIME'S UP");
            }
            else
            {
               
            }
            refreshBtn();
        }



        private void btnModify_Click(object sender, EventArgs e)
        {
            bool flag = false;

            if (ProcessingRentalSingle.DicRenSin.ContainsKey(lbRoomCode.Text))
            {
                flag = true;
            }
            if (btnModify.Text == "Modify")
            {
                fpnRoomDiagram.Enabled = false;
                if (cbbStatus.SelectedIndex == 3 || cbbStatus.SelectedIndex == 4)
                {
                    cbbStatus.Items.Clear();
                    cbbStatus.Items.Add("EMPTY");

                }
                else if (cbbStatus.SelectedIndex == 0)
                {
                    cbbStatus.Items.Clear();
                    cbbStatus.Items.Add("REPAIR");
                }
                //
                btnCheckin.Enabled = false;
                btnCheckout.Enabled = false;
                //
                btnModify.Text = "Apply";
                btnModify.ForeColor = Color.Red;
                btnModify.Font = new Font(btnCheckin.Font, FontStyle.Bold);
                //
                if (flag)
                {

                    cbbStatus.Enabled = false;
                }
                else
                {
                    cbbStatus.Enabled = true;
                }
            }
            else
            {
                fpnRoomDiagram.Enabled = true;

                cbbStatus.Items.Add("EMPTY");
                cbbStatus.Items.Add("COMING");
                cbbStatus.Items.Add("FULL");
                cbbStatus.Items.Add("DIRTY");   
                cbbStatus.Items.Add("REPAIR");
                cbbStatus.Items.Add("TIME'S UP");

                btnModify.Text = "Modify";
                btnModify.ForeColor = Color.Black;
                btnModify.Font = new Font(btnCheckin.Font, FontStyle.Regular);
                cbbStatus.Enabled = false;
                //
                string crrStatus = ProcessingRoom.DicRoom[lbRoomCode.Text].Status;
                ProcessingRoom.DicRoom[lbRoomCode.Text].Status = cbbStatus.Text;
                //Processing Label Show
                List<Label> listLB = new List<Label>();
                listLB.Add(lbEMPTY);
                listLB.Add(lbDIRTY);
                listLB.Add(lbREPAIR);
                int i = 0, j = 0;
                foreach (Label label in listLB)
                {
                    if (label.Name == ("lb" + crrStatus))
                        i = listLB.IndexOf(label);
                    else if (label.Name == ("lb" + cbbStatus.Text))
                        j = listLB.IndexOf(label);
                }
                modifyLabel(listLB[j], listLB[i]);
                fpnRoomDiagram.Enabled = true;


                //Processing Rental
                if (flag)
                {
                    ProcessingRentalSingle.DicRenSin[lbRoomCode.Text].TimeCheckout = dtpTimeCheckout.Value;
                }
                ProcessingRoom.writeFile_DicRoom();
                ProcessingRentalSingle.writeFileRentalSingle();
                refreshBtn();
                showInFoRoom(lbRoomCode.Text);
            }
        }
        public string reverseString(string str)
        {
            string rs = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                rs = rs + str[i];
            }
            return rs;
        }
        public void modifyLabel(Label increase, Label reduce)
        {
            string incr = increase.Text;
            string red = reduce.Text;
            int i = red.Length - 1;
            string s = "";
            for (; i >= 0; i--)
            {
                if (red[i] >= '0' && red[i] <= '9')
                {

                    while (red[i] >= '0' && red[i] <= '9')
                    {
                        s = s + red[i--];
                    }
                    break;
                }
            }
            s = reverseString(s);
            int j = int.Parse(s);
            if (j > 0)
                j--;
            red = red.Substring(0, i + 1) + j.ToString() + "]";
            //
            i = incr.Length - 1;
            s = "";
            for (; i >= 0; i--)
            {
                if (incr[i] >= '0' && incr[i] <= '9')
                {

                    while (incr[i] >= '0' && incr[i] <= '9')
                    {
                        s = s + incr[i--];
                    }
                    break;
                }
            }
            s = reverseString(s);
            j = int.Parse(s);
            if (j >= 0)
                j++;
            incr = incr.Substring(0, i + 1) + j.ToString() + "]";
            //
            increase.Text = incr;
            reduce.Text = red;
        }
        private void btnCheckout_Click(object sender, EventArgs e)
        {
            CheckBox cb = new CheckBox();
            cb.Checked = false;
            SingleBill sb = new SingleBill();
            sb.RentalSingle_Bill = ProcessingRentalSingle.DicRenSin[lbRoomCode.Text];
            sb.EmployeePayment = ProcessingEmployee.CrrEmployee;
            sb.TimePayment = DateTime.Now;
            FormSingleBill fi = new FormSingleBill(sb, cb);
            fi.ShowDialog();
            if (cb.Checked)
            {
                txtID.Text = string.Empty;
                txtName.Text = string.Empty;
                RentalPrice price = ProcessingTypeRoom.DicRentalPrice[ProcessingRoom.DicRoom[lbRoomCode.Text].TypeRoom.Name];
                lbSize.Text = ProcessingRoom.DicRoom[lbRoomCode.Text].TypeRoom.Size.ToString();
                lbRank.Text = ProcessingRoom.DicRoom[lbRoomCode.Text].TypeRoom.Rank;
                lbFirstHour.Text = price.FirstHour.ToString();
                lbNormalHour.Text = price.NormalHour.ToString();
                lbOverNight.Text = price.OverNight.ToString();
                lbDay.Text = price.Day.ToString();
                dtpTimeCheckin.Value = DateTime.Now;
                dtpTimeCheckout.Value = DateTime.Now;
                cbbStatus.SelectedIndex = 3;//DIRTY
                lbNameEmployee.Text = string.Empty;
                ProcessingRoom.DicRoom[lbRoomCode.Text].Status = "DIRTY";
                modifyLabel(lbDIRTY, lbFULL);
                ProcessingRoom.writeFile_DicRoom();
                refreshBtn();
            }
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

        private void FormBookSingle_Load(object sender, EventArgs e)
        {
            showDiagramRoom("<none>");
            updateNumberRoom();
            dtpTimeFilter.Format = DateTimePickerFormat.Custom;
            dtpTimeFilter.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            cbbStatusFilter.SelectedIndex = 0;
            dtpTimeFilter.MinDate = DateTime.Now;

            //InFo
            dtpTimeCheckin.Format = DateTimePickerFormat.Custom;
            dtpTimeCheckin.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dtpTimeCheckout.Format = DateTimePickerFormat.Custom;
            dtpTimeCheckout.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            if (ProcessingRentalSingle.findRentalSingle(lbRoomCode.Text) == null)
            {
                dtpTimeCheckin.MinDate = DateTime.Now;
                dtpTimeCheckout.MinDate = dtMinDate;
            }
            //
            ProcessingRoom.readFile_DicRoom();
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
        private void refreshInFo()
        {
            cbbStatus.Enabled = false;
            lbRoomCode.Text = string.Empty;
            txtName.Text = String.Empty;
            txtID.Text = String.Empty;
            lbSize.Text = String.Empty;
            lbRank.Text = String.Empty;
            lbFirstHour.Text = String.Empty;
            lbNormalHour.Text = String.Empty;
            lbOverNight.Text = String.Empty;
            lbDay.Text = String.Empty;
            cbbStatus.SelectedIndex = -1;
            dtpTimeCheckin.MinDate = DateTime.Now.AddMinutes(-1);
            dtpTimeCheckin.Value = DateTime.Now;
            dtpTimeCheckout.Value = DateTime.Now;
            lbNameEmployee.Text = String.Empty;
            rdoHour.Checked = true;
            rdoOverNight.Checked = false;
            rdoDay.Checked = false;
            txtNODay.Enabled = false;
            lbProvisionalMoney.Text = string.Empty;
            lbProvisionalMoney.Text = string.Empty;

        }
        private void CreBtn_Click(object sender, EventArgs e)
        {
            oldmoney = 0;
            pnInFoSingle.Visible = true;
            Button btn = (Button)sender;
            if (pnInFoSingle.Controls.Count != 0)
            {
                refreshInFo();
                lbRoomCode.Text = btn.Text;
                Room room = new Room();
                RentalSingle rs = new RentalSingle();
                RentalPrice rp = new RentalPrice();
                bool flg = false;

                foreach (RentalGroup rg in ProcessingRentalGroup.DicRenGroup.Values)
                {
                    foreach (Room rm in rg.ListRoomBook)
                        if (rm.RoomCode == lbRoomCode.Text)
                        {
                            rp = ProcessingTypeRoom.DicRentalPrice[rm.TypeRoom.Name];
                            txtName.Text = rg.NameCustomer;
                            txtID.Text = rg.IDCustomer;
                            txtNODay.Text = rg.Nod.ToString();
                            lbSize.Text = rm.TypeRoom.Size.ToString();
                            lbRank.Text = rm.TypeRoom.Rank;
                            lbFirstHour.Text = rp.FirstHour.ToString();
                            lbNormalHour.Text = rp.NormalHour.ToString();
                            lbOverNight.Text = rp.OverNight.ToString();
                            lbDay.Text = rp.Day.ToString();
                            cbbStatus.SelectedIndex = cbbStatus.Items.IndexOf(rm.Status);
                            rdoDay.Checked = true;
                            dtpTimeCheckin.MinDate = rg.TimeCheckin.Add(new TimeSpan(0, -1, 0));
                            dtpTimeCheckin.Value = rg.TimeCheckin;
                            dtpTimeCheckout.Value = rg.TimeCheckout;
                            lbNameEmployee.Text = rg.EmployeeBook.Name;
                            grbTypeRental.Enabled = false;
                            btnCheckout.Enabled = false;
                            btnCheckin.Enabled = false;
                            btnModify.Enabled = false;
                            btnCancel.Enabled = false;
                            flg = true;
                            break;
                        }
                }
                if (ProcessingRentalSingle.findRentalSingle(btn.Text) != null)
                {
                    rs = ProcessingRentalSingle.DicRenSin[btn.Text];
                    room = rs.RoomBook;
                    rp = rs.Price;
                    txtName.Text = rs.NameCustomer;
                    txtID.Text = rs.IDCustomer;
                    lbSize.Text = room.TypeRoom.Size.ToString();
                    lbRank.Text = room.TypeRoom.Rank;
                    lbFirstHour.Text = rp.FirstHour.ToString();
                    lbNormalHour.Text = rp.NormalHour.ToString();
                    lbOverNight.Text = rp.OverNight.ToString();
                    lbDay.Text = rp.Day.ToString();
                    cbbStatus.SelectedIndex = cbbStatus.Items.IndexOf(room.Status);
                    processingRadioButton(rs);
                    dtpTimeCheckin.MinDate = rs.TimeCheckin.Add(new TimeSpan(0, -1, 0));
                    dtpTimeCheckin.Value = rs.TimeCheckin;
                    dtpTimeCheckout.Value = rs.TimeCheckout;
                    lbNameEmployee.Text = rs.EmployeeBook.Name;
                    grbTypeRental.Enabled = false;
                    lbProvisionalMoney.Text = ProcessingRentalSingle.calculateMoney(rs).ToString();
                }
                else
                {
                    room = ProcessingRoom.DicRoom[btn.Text];
                    rp = ProcessingTypeRoom.DicRentalPrice[room.TypeRoom.Name];
                    lbSize.Text = room.TypeRoom.Size.ToString();
                    lbRank.Text = room.TypeRoom.Rank;
                    lbFirstHour.Text = rp.FirstHour.ToString();
                    lbNormalHour.Text = rp.NormalHour.ToString();
                    lbOverNight.Text = rp.OverNight.ToString();
                    lbDay.Text = rp.Day.ToString();
                    cbbStatus.SelectedIndex = cbbStatus.Items.IndexOf(room.Status);
                    rdoHour.Enabled = true;
                    rdoDay.Enabled = true;
                }

                if (!flg)
                {

                    refreshBtn();
                }
            }
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
                    if (status == "<none>")
                    {
                        if (getFloor(room.RoomCode) == f)
                        {
                            flag = true;
                            createButtonVIP(flowLayoutPanel_ListRoomOfFloor, room);
                        }
                    }
                    else
                    {
                        if (room.Status == status)
                            if (getFloor(room.RoomCode) == f)
                            {
                                flag = true;
                                createButtonVIP(flowLayoutPanel_ListRoomOfFloor, room);
                            }
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
        private void btnFilterStatus_Click(object sender, EventArgs e)
        {
            showDiagramRoom(cbbStatusFilter.Items[cbbStatusFilter.SelectedIndex].ToString());
            lbBorderStatus.Visible = true;
        }


        private void createButtonVIP(FlowLayoutPanel flowLayoutPanel, Room room)
        {
            // 1
            //panel chứ phòng và loại phòng
            Panel panel = new Panel();
            panel.Size = new Size(105, 50);
            panel.BackColor = Color.Green;
            flowLayoutPanel.Controls.Add(panel);
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
            //
            string status = cbbStatusFilter.Items[cbbStatusFilter.SelectedIndex].ToString();
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
                else if (status == "COMING")
                {
                    //SGSub
                    foreach (RentalSingle rs in ProcessingRentalSingle.DicRenSinSub.Values)
                    {
                        if (DateTime.Compare(rs.TimeCheckin.AddHours(-26), dt) < 0
                            && DateTime.Compare(rs.TimeCheckin, dt) > 0)
                        {
                            Room rm = rs.RoomBook;
                            listRoomWillCreate.Add(rm.RoomCode, rm);
                        }
                    }
                    //GrpSub
                    foreach (RentalGroup rg in ProcessingRentalGroup.DicRenGroupSub.Values)
                    {
                        if (DateTime.Compare(rg.TimeCheckin.AddHours(-26), dt) < 0
                            && DateTime.Compare(rg.TimeCheckin, dt) > 0)
                        {
                            foreach (Room rm in rg.ListRoomBook)
                            {
                                listRoomWillCreate.Add(rm.RoomCode, rm);
                            }
                        }
                    }
                }
                else if (status == "FULL")
                {
                    //SG
                    foreach (RentalSingle rs in ProcessingRentalSingle.DicRenSin.Values)
                    {
                        if (DateTime.Compare(rs.TimeCheckin, dt) < 0
                            && DateTime.Compare(rs.TimeCheckout, dt) > 0)
                        {
                            Room rm = rs.RoomBook;
                            listRoomWillCreate.Add(rm.RoomCode, rm);
                        }
                    }
                    //SGSub
                    foreach (RentalSingle rs in ProcessingRentalSingle.DicRenSinSub.Values)
                    {
                        if (DateTime.Compare(rs.TimeCheckin, dt) < 0
                         && DateTime.Compare(rs.TimeCheckout, dt) > 0)
                        {
                            Room rm = rs.RoomBook;
                            listRoomWillCreate.Add(rm.RoomCode, rm);
                        }
                    }
                    //Grp
                    foreach (RentalGroup rg in ProcessingRentalGroup.DicRenGroup.Values)
                    {
                        if (DateTime.Compare(rg.TimeCheckin, dt) < 0
                         && DateTime.Compare(rg.TimeCheckout, dt) > 0)
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
                        if (DateTime.Compare(rg.TimeCheckin, dt) < 0
                         && DateTime.Compare(rg.TimeCheckout, dt) > 0)
                        {
                            foreach (Room rm in rg.ListRoomBook)
                            {
                                listRoomWillCreate.Add(rm.RoomCode, rm);
                            }
                        }
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

        private void FormBookSingle_EnabledChanged(object sender, EventArgs e)
        {
            thread.Abort();
            this.Close();
        }

        private void rdoDay_Click(object sender, EventArgs e)
        {
            txtNODay.Enabled = true;
            txtNODay.Text = "";
        }
    }
}
