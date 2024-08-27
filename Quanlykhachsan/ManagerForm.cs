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
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }
        private void ManagerForm_Load(object sender, EventArgs e)
        {
            //Room
            ProcessingTypeRoom.readFileTypeRooms_Size();
            ProcessingTypeRoom.readFileTypeRooms_Rank();
            ProcessingRoom.readFile_DicRoom();
            refresh_Room();
            //Accout
            ProcessingAccounts.readFileAccount();
            ProcessingAccounts.readFileTypeAccount();
            refresh_Account();
            //Price
            ProcessingTypeRoom.readFileTypeRooms_Price();
            refresh_Price();
            //User
            ProcessingAccounts.readFileTypeAccount();
            ProcessingEmployee.readFileEmployee();
            refresh_Employee();
        }
        private void tabCtrl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ManagerForm_Load(sender, e);
            refresh_Room();
            refresh_Account();
            refresh_Price();
            refresh_Employee();
        }
        public static string get_ID_From_UserName(string userName)
        {
            foreach (Employee s in ProcessingEmployee.DicEmployee.Values)
            {
                if (s.UserName==userName)
                {
                    return s.ID;
                }
            }
            return string.Empty;
        }

        //<TabRoom>
        public void show_Room()
        {
            ProcessingRoom.DicRoom = ProcessingRoom.sortDicRoom();
            dgvRoom.DataSource = ProcessingRoom.DicRoom.Values.ToList();
            int i = 0, j;
            foreach (Room room in ProcessingRoom.DicRoom.Values)
            {
                j = i + 1;
                dgvRoom.Rows[i].Cells[0].Value = j.ToString();
                dgvRoom.Rows[i].Cells[1].Value = dgvRoom.Rows[i].Cells[4].Value.ToString()[0];
                dgvRoom.Rows[i].Cells[2].Value = room.TypeRoom.Size.ToString();
                dgvRoom.Rows[i++].Cells[3].Value = room.TypeRoom.Rank.ToString();
            }
            dgvRoom.Columns[0].ReadOnly = true;
            dgvRoom.Columns[1].ReadOnly = true;
            dgvRoom.Columns[2].ReadOnly = true;
            dgvRoom.Columns[3].ReadOnly = true;
            dgvRoom.Columns[4].ReadOnly = true;
            dgvRoom.Columns[6].ReadOnly = true;
            dgvRoom.Columns.RemoveAt(5);
        }
        private void refresh_Room()
        {
            txtRoomCode.Text = "Please Enter 3 numbers";
            cbbTypeRoom_Size.SelectedIndex = -1;
            cbbTypeRoom_Rank.SelectedIndex = -1;
            lbStatus_Room.Text = "";
            cbbTypeRoom_Size.Items.Clear();
            foreach (int i in ProcessingTypeRoom.ListSize)
            {
                string str = i.ToString();
                cbbTypeRoom_Size.Items.Add(str);
            }
            cbbTypeRoom_Rank.Items.Clear();
            foreach (string s in ProcessingTypeRoom.ListRank)
            {
                cbbTypeRoom_Rank.Items.Add(s);
            }
            show_Room();
        }
        private void txtRoomCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void txtRoomCode_Click(object sender, EventArgs e)
        {
            txtRoomCode.Clear();
        }
        private void lbLinkFormTypeRoomMng_Click(object sender, EventArgs e)
        {
            this.Hide();
            TypeRoomMngForm typeRoomMngForm = new TypeRoomMngForm();
            typeRoomMngForm.ShowDialog();
            this.Show();
            refresh_Room();
        }
        private void dgvRoom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtRoomCode.Text = dgvRoom.Rows[e.RowIndex].Cells[4].Value.ToString();
                cbbTypeRoom_Size.Text = dgvRoom.Rows[e.RowIndex].Cells[2].Value.ToString();
                cbbTypeRoom_Rank.Text = dgvRoom.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
        }
        private void btnAdd_Room_Click(object sender, EventArgs e)
        {
            if (cbbTypeRoom_Size.Text == ""
                || cbbTypeRoom_Rank.Text == ""
                || txtRoomCode.Text == "Please Enter 3 numbers"
                || txtRoomCode.Text == "")
            {
                lbStatus_Room.Text = "Please complete all information!!!";
            }
            else if (txtRoomCode.Text.Length == 1 || txtRoomCode.Text.Length == 2)
            {
                txtRoomCode.Text = "Please Enter 3 numbers";
                lbStatus_Room.Text = "Please Enter 3 numbers";
            }
            else if (txtRoomCode.Text[0] == '0')
            {
                txtRoomCode.Text = "Please Enter 3 numbers";
                lbStatus_Room.Text = "RoomCode must not start with 0";
            }
            else
            {
                Room room = new Room();
                room.RoomCode = txtRoomCode.Text;
                room.TypeRoom.Size = int.Parse(cbbTypeRoom_Size.Text);
                room.TypeRoom.Rank = cbbTypeRoom_Rank.Text;
                room.Status = "EMPTY";
                if (ProcessingRoom.search_Room(txtRoomCode.Text) == null)
                {
                    ProcessingRoom.DicRoom.Add(txtRoomCode.Text, room);
                    ProcessingRoom.writeFile_DicRoom();
                    refresh_Room();
                    lbStatus_Room.Text = "ADD Room SUCCESSFULLY!!!";
                }
                else
                {
                    lbStatus_Room.Text = "Room was EXIST!!!";
                }
            }
        }
        private void btnSearch_Room_Click(object sender, EventArgs e)
        {
            if (ProcessingRoom.search_Room(txtRoomCode.Text) != null)
            {
                txtRoomCode.Text = ProcessingRoom.DicRoom[txtRoomCode.Text].RoomCode.ToString();
                cbbTypeRoom_Size.Text = ProcessingRoom.DicRoom[txtRoomCode.Text].TypeRoom.Size.ToString();
                cbbTypeRoom_Rank.Text = ProcessingRoom.DicRoom[txtRoomCode.Text].TypeRoom.Rank.ToString();
                lbStatus_Room.Text = "Had found!!!";
            }
            else
            {
                refresh_Room();
                lbStatus_Room.Text = "RoomCode is NOT EXIST!!!";
            }
        }
        private void btnDelete_Room_Click(object sender, EventArgs e)
        {
            if (ProcessingRoom.search_Room(txtRoomCode.Text) != null)
            {
                ProcessingRoom.DicRoom.Remove(txtRoomCode.Text);
                ProcessingRoom.writeFile_DicRoom();
                refresh_Room();
                lbStatus_Room.Text = "Delete SUCCESSFULLY!!!";
            }
            else lbStatus_Room.Text = "RoomCode is NOT EXIST!!!";
        }
        private void btnModify_Room_Click(object sender, EventArgs e)
        {
            if (cbbTypeRoom_Size.Text == "" || cbbTypeRoom_Rank.Text == "")
            {
                lbStatus_Room.Text = "Please complete all information!!!";
            }
            else if (ProcessingRoom.search_Room(txtRoomCode.Text) != null)
            {
                ProcessingRoom.DicRoom[txtRoomCode.Text].TypeRoom.Size = int.Parse(cbbTypeRoom_Size.Text);
                ProcessingRoom.DicRoom[txtRoomCode.Text].TypeRoom.Rank = cbbTypeRoom_Rank.Text;
                ProcessingRoom.writeFile_DicRoom();
                refresh_Room();
                lbStatus_Room.Text = "Modify SUCCESSFULLY!!!";
            }
            else
            {
                lbStatus_Room.Text = "RoomCode is NOT EXIST!!!";
            }
        }
        private void btnSave_Room_Click(object sender, EventArgs e)
        {
            if (ProcessingRoom.writeFile_DicRoom())
            {
                lbStatus_Room.Text = "Saved!!!";
            }
        }
        //</TabRoom>


        //<TabPrice>
        private void txtFirstHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtNormalHour_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtOverNight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void dgvPrice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                cbbTypeRoom.Text = dgvPrice.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        public void refresh_Price()
        {
            cbbTypeRoom.SelectedIndex = -1;
            txtFirstHour.Text = "";
            txtNormalHour.Text = "";
            txtOverNight.Text = "";
            txtDay.Text = "";
            lbStatus_Price.Text = "";
            show_Price();
        }
        public void show_Price()
        {
            try
            {
                ProcessingTypeRoom.DicRentalPrice = ProcessingTypeRoom.sortDicRentalPrice();
            }
            catch (Exception ex)
            {

            }
            dgvPrice.DataSource = ProcessingTypeRoom.DicRentalPrice.Values.ToList();
            cbbTypeRoom.Items.Clear();
            foreach (string s in ProcessingTypeRoom.DicRentalPrice.Keys)
            {
                ProcessingTypeRoom.DicRentalPrice[s].NameTypeRoom = s;
                cbbTypeRoom.Items.Add(s);
            }
        }
        private void btnSave_Price_Click(object sender, EventArgs e)
        {
            ProcessingTypeRoom.writeFileTypeRooms_Price();
            lbStatus_Price.Text = "Saved!!!";
        }
        private void cbbTypeRoom_TextChanged(object sender, EventArgs e)
        {
            if (cbbTypeRoom.Text != "")
            {
                RentalPrice rp = ProcessingTypeRoom.DicRentalPrice[cbbTypeRoom.Text];
                txtFirstHour.Text = rp.FirstHour.ToString();
                txtNormalHour.Text = rp.NormalHour.ToString();
                txtDay.Text = rp.Day.ToString();
                txtOverNight.Text = rp.OverNight.ToString();
            }
        }
        private void btnChange_Click(object sender, EventArgs e)
        {
            if (cbbTypeRoom.Text == ""
                || txtFirstHour.Text == ""
                || txtNormalHour.Text == ""
                || txtOverNight.Text == ""
                || txtDay.Text == "")
            {
                lbStatus_Price.Text = "Please complete all information!!!";
            }
            else
            {
                ProcessingTypeRoom.DicRentalPrice[cbbTypeRoom.Text].FirstHour = double.Parse(txtFirstHour.Text);
                ProcessingTypeRoom.DicRentalPrice[cbbTypeRoom.Text].NormalHour = double.Parse(txtNormalHour.Text);
                ProcessingTypeRoom.DicRentalPrice[cbbTypeRoom.Text].Day = double.Parse(txtDay.Text);
                ProcessingTypeRoom.DicRentalPrice[cbbTypeRoom.Text].OverNight = double.Parse(txtOverNight.Text);
                ProcessingTypeRoom.writeFileTypeRooms_Price();
                refresh_Price();
                lbStatus_Price.Text = "Changed!!!";
            }
        }
        //</TabPrice>


        //<TabAccount>
        private void refresh_Account()
        {
            txtUserName.Text = string.Empty;
            txtPassWord.Text = string.Empty;
            cbbTypeAccount.SelectedIndex = -1;
            lbStatus.Text = "";
            show_Account();
        }
        private void show_Account()
        {
            int i = 0, j;
            dgvAccount.DataSource = ProcessingAccounts.DicAccount.Values.ToList();
            foreach (Account a in ProcessingAccounts.DicAccount.Values)
            {
                j = i + 1;
                dgvAccount.Rows[i++].Cells[0].Value = j.ToString();
            }
            dgvAccount.Columns.RemoveAt(2);
            //
            cbbTypeAccount.Items.Clear();
            foreach (string s in ProcessingAccounts.ListType)
            {
                cbbTypeAccount.Items.Add(s);
            }
        }
        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            //    e.Handled = true;
        }
        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtUserName.Text = dgvAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbbTypeAccount.Text = dgvAccount.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }
        private void btnChange_TypeAccount_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            ChangeTypeAccountForm cta = new ChangeTypeAccountForm();
            cta.ShowDialog();
            show_Account();
            this.Visible = true;
        }
        //private void btnAdd_Account_Click(object sender, EventArgs e)
        //{
        //    if (ProcessingAccounts.search(txtUserName.Text) != null)
        //    {
        //        lbStatus.Text = "Account was EXIST!!!";
        //    }
        //    else if (txtUserName.Text == "" || txtPassWord.Text == "" || cbbTypeAccount.Text == "")
        //    {
        //        lbStatus.Text = "Please complete all information!!!";
        //    }
        //    else if (cbbTypeAccount.Text == "Manager")
        //        lbStatus.Text = "Can't add Account with Type Manager!!!";
        //    else
        //    {
        //        Account acc = new Account(txtUserName.Text, txtPassWord.Text, cbbTypeAccount.Text);
        //        ProcessingAccounts.DicAccount.Add(txtUserName.Text, acc);
        //        ProcessingAccounts.writeFileAccount();
        //        lbStatus.Text = "Add Account is SUCCESSFUL!!!";
        //        refresh_Account();
        //    }
        //}
        private void btnSearch_Account_Click(object sender, EventArgs e)
        {
            if (ProcessingAccounts.search(txtUserName.Text) != null)
            {
                cbbTypeAccount.Text = ProcessingAccounts.DicAccount[txtUserName.Text].TypeAccount;
                //txtPassWord.Text = ProcessingAccounts.DicAccount[txtUserName.Text].PassWord;
                lbStatus.Text = "Had found!!!";
            }
            else
            {
                lbStatus.Text = "UserName is NOT EXIST!!!";
            }
        }
        private void btnDelete_Account_Click(object sender, EventArgs e)
        {
            if (ProcessingAccounts.search(txtUserName.Text) != null)
            {
                if (ProcessingAccounts.DicAccount[txtUserName.Text].TypeAccount == "Manager")
                {
                    lbStatus.Text = "Can't delete Manager Account!!!";
                }
                else
                {
                    ProcessingAccounts.DicAccount.Remove(txtUserName.Text);
                    ProcessingAccounts.writeFileAccount();
                    //
                    foreach (Employee s in ProcessingEmployee.DicEmployee.Values)
                    {
                        if (s.UserName==txtUserName.Text)
                        {
                            s.UserName = "";
                            ProcessingEmployee.writeFileEmployee();
                        }
                    }
                    //
                    refresh_Account();
                    lbStatus.Text = "Delete SUCCESSFULLY!!!";
                }
            }
            else
            {
                lbStatus.Text = "UserName is NOT EXIST!!!";
            }
        }
        private void btnModify_Account_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" || cbbTypeAccount.Text == "" || txtPassWord.Text == "")
                lbStatus.Text = "Please complete all information!!!";
            else if (ProcessingAccounts.search(txtUserName.Text) != null)
            {
                if (ProcessingAccounts.Currently.UserName == ProcessingAccounts.DicAccount[txtUserName.Text].UserName)
                {
                    if (cbbTypeAccount.Text != "Manager")
                    {
                        lbStatus.Text = "Can't not Modify Type Manager!!!";
                    }
                    else
                    {
                        ProcessingAccounts.DicAccount[txtUserName.Text].PassWord = txtPassWord.Text;
                        ProcessingAccounts.writeFileAccount();
                        refresh_Account();
                        lbStatus.Text = "Modify SUCCESSFULLY!!!";
                    }
                }
                else
                {
                    if (cbbTypeAccount.Text != "Manager")
                    {
                        ProcessingAccounts.DicAccount[txtUserName.Text].PassWord = txtPassWord.Text;
                        ProcessingAccounts.DicAccount[txtUserName.Text].TypeAccount = cbbTypeAccount.Text;
                        ProcessingAccounts.writeFileAccount();
                        //thay đổi TypeEmployee của những Account Đã được sữ hữu thì các Employee
                        foreach (Employee s in ProcessingEmployee.DicEmployee.Values)
                        {
                            if (s.UserName==txtUserName.Text)
                            {
                                s.TypeEmployee = cbbTypeAccount.Text;
                                ProcessingEmployee.writeFileEmployee();
                            }
                        }
                        //
                        refresh_Account();
                        lbStatus.Text = "Modify SUCCESSFULLY!!!";
                    }
                    else lbStatus.Text = "Can't not Modify to Type Manager!!!";
                }
            }
            else lbStatus.Text = "UserName is NOT EXIST!!!";
        }
        private void btnSave_Account_Click(object sender, EventArgs e)
        {
            if (ProcessingAccounts.writeFileAccount())
                lbStatus.Text = "Save SUCCESSFULLY!!!";
            else lbStatus.Text = "Save FAILURE!!!";
        }
        //</TabAccount>


        //<User>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
                e.Handled = true;
        }
        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtAddress_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetterOrDigit(e.KeyChar)
                && (e.KeyChar != ' ')
                && (e.KeyChar != ',')
                && (e.KeyChar != '.')
                && (e.KeyChar != '/'))
                e.Handled = true;
        }
        private void txtUserName_Employee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
        private void dgvUser_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvEmployee.Columns[e.ColumnIndex].Name == "SexCell")
            //if (e.ColumnIndex == 3)
            {
                if (e.Value is bool)
                {
                    bool vl = (bool)e.Value;
                    e.Value = (vl) ? "Nam" : "Nữ";
                    e.FormattingApplied = true; // Ket thuc qua trinh format, khong the format nua
                }
            }
        }
        public void refresh_Employee()
        {
            txtName.Text = "";
            txtID.Text = "";
            txtID.Enabled = true;
            dtpEmployee.Text = dtpEmployee.MaxDate.ToString();
            rdoMale.Checked = true;
            cbbTypeEmployee.SelectedIndex = -1;
            cbbTypeEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTypeEmployee.Enabled = true;
            txtAddress.Text = "";
            txtUserName_Employee.Text = "";
            lbStatus_Employee.Text = "";
            show_Employee();
        }
        public void show_Employee()
        {
            dgvEmployee.DataSource = ProcessingEmployee.DicEmployee.Values.ToList();
            int i = 1;
            for (int j = 0; j < dgvEmployee.RowCount; j++)
            {
                dgvEmployee.Rows[j].Cells["Number"].Value = i;
                i++;
            }
            cbbTypeEmployee.Items.Clear();
            foreach (string s in ProcessingAccounts.ListType)
            {
                if (s != "Manager")
                    cbbTypeEmployee.Items.Add(s);
            }
        }
        private void dgvEmployee_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                txtName.Text = dgvEmployee.Rows[e.RowIndex].Cells["NameCell"].Value.ToString();
                txtID.Text = dgvEmployee.Rows[e.RowIndex].Cells["IDCell"].Value.ToString();
                txtID.Enabled = false;
                dtpEmployee.Text = dgvEmployee.Rows[e.RowIndex].Cells["BirthDayCell"].Value.ToString();
                if (dgvEmployee.Rows[e.RowIndex].Cells["SexCell"].Value.ToString() == true.ToString())
                    rdoMale.Checked = true;
                else rdoFeMale.Checked = true;
                if (dgvEmployee.Rows[e.RowIndex].Cells["TypeEmployeeCell"].Value.ToString()=="Manager")
                {
                    cbbTypeEmployee.DropDownStyle = ComboBoxStyle.DropDown;
                    cbbTypeEmployee.Text = "Manager";
                    cbbTypeEmployee.Enabled = false;
                }
                else
                {
                    cbbTypeEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbbTypeEmployee.Enabled = true;
                    cbbTypeEmployee.Text = dgvEmployee.Rows[e.RowIndex].Cells["TypeEmployeeCell"].Value.ToString();
                }
                txtAddress.Text= dgvEmployee.Rows[e.RowIndex].Cells["AddressCell"].Value.ToString();
                txtUserName_Employee.Text= dgvEmployee.Rows[e.RowIndex].Cells["UserNameCell"].Value.ToString();
            }
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            refresh_Employee();
        }
        private void btnSearch_Employee_Click(object sender, EventArgs e)
        {
            if (ProcessingEmployee.DicEmployee.ContainsKey(txtID.Text))
            {
                lbStatus_Employee.Text = "Had Found!!!";
                txtID.Enabled = false;
                Employee us = ProcessingEmployee.DicEmployee[txtID.Text];
                txtName.Text = us.Name;
                dtpEmployee.Value = us.BirthDay;
                if (us.Sex) rdoMale.Checked = true;
                else rdoFeMale.Checked = true;
                if (us.TypeEmployee == "Manager")
                {
                    cbbTypeEmployee.DropDownStyle = ComboBoxStyle.DropDown;
                    cbbTypeEmployee.Text = "Manager";
                    cbbTypeEmployee.Enabled = false;
                }
                else
                {
                    cbbTypeEmployee.DropDownStyle = ComboBoxStyle.DropDownList;
                    cbbTypeEmployee.Enabled = true;
                    cbbTypeEmployee.Text = us.TypeEmployee;
                }
                txtAddress.Text = us.Address;
                txtUserName_Employee.Text = us.UserName;
            }
            else
                lbStatus_Employee.Text = "Not Found!!!";
        }
        private void btnAdd_Employee_Click(object sender, EventArgs e)
        {
            if (txtName.Text == ""
                || txtID.Text == ""
                || cbbTypeEmployee.Text == ""
                || txtAddress.Text == "")
            {
                lbStatus_Employee.Text = "Please complete all information!!!";
            }
            else if (ProcessingAccounts.DicAccount.ContainsKey(txtUserName_Employee.Text))
            {
                lbStatus_Employee.Text = "UserName was EXIST!!!";
            }
            else if (!ProcessingEmployee.DicEmployee.ContainsKey(txtID.Text))
            {
                Employee us = new Employee();
                us.ID = txtID.Text;
                us.Name = txtName.Text;
                us.BirthDay = dtpEmployee.Value;
                us.Sex = rdoMale.Checked ? true : false;
                us.TypeEmployee = cbbTypeEmployee.Text;
                us.Address = txtAddress.Text;
                us.UserName = txtUserName_Employee.Text;
                ProcessingEmployee.DicEmployee.Add(us.ID, us);
                //add account with empty password
                if (txtUserName_Employee.Text != "")
                {
                    Account account = new Account(txtUserName_Employee.Text, string.Empty, us.TypeEmployee);
                    ProcessingAccounts.DicAccount.Add(txtUserName_Employee.Text, account);
                    ProcessingAccounts.writeFileAccount();
                }
                ProcessingEmployee.writeFileEmployee();
                refresh_Employee();
                lbStatus_Employee.Text = "Add SUCCESSFULLY!!!";
            }
            else
            {
                lbStatus_Employee.Text = "ID was EXIST!!!";
            }
        }
        private void btnDelete_Eployee_Click(object sender, EventArgs e)
        {
            if (ProcessingEmployee.DicEmployee.ContainsKey(txtID.Text))
            {
                string userNameOld = ProcessingEmployee.DicEmployee[txtID.Text].UserName;
                if (ProcessingEmployee.CrrEmployee.ID == txtID.Text)
                {
                    lbStatus_Employee.Text = "Can't Delete Employee is logging into the program!!!";
                }
                else
                {
                    if (userNameOld != "")
                    {
                        ProcessingAccounts.DicAccount.Remove(userNameOld);
                        ProcessingAccounts.writeFileAccount();
                    }
                    ProcessingEmployee.DicEmployee.Remove(txtID.Text);
                    ProcessingEmployee.writeFileEmployee();
                    refresh_Employee();
                    lbStatus_Employee.Text = "Deleted!!!";
                }
            }
            else
            {
                lbStatus_Employee.Text = "ID is not EXIST!!!";
            }
        }
        private void btnModify_Employee_Click(object sender, EventArgs e)
        {
            if (ProcessingEmployee.DicEmployee.ContainsKey(txtID.Text))
            {
                string userNameOld = ProcessingEmployee.DicEmployee[txtID.Text].UserName;
                ProcessingEmployee.DicEmployee[txtID.Text].Name = txtName.Text;
                ProcessingEmployee.DicEmployee[txtID.Text].BirthDay = dtpEmployee.Value;
                ProcessingEmployee.DicEmployee[txtID.Text].TypeEmployee = cbbTypeEmployee.Text;
                ProcessingEmployee.DicEmployee[txtID.Text].Sex = rdoMale.Checked ? true : false;
                ProcessingEmployee.DicEmployee[txtID.Text].Address = txtAddress.Text;
                if (ProcessingAccounts.DicAccount.ContainsKey(txtUserName_Employee.Text))
                {
                    lbStatus_Employee.Text = "Account was EXIST!!!";
                }
                else
                {
                    ProcessingEmployee.DicEmployee[txtID.Text].UserName = txtUserName_Employee.Text;
                    if (txtUserName_Employee.Text != "")
                    {
                        Account acc = new Account(txtUserName_Employee.Text, string.Empty, cbbTypeEmployee.Text);
                        ProcessingAccounts.DicAccount.Add(txtUserName_Employee.Text, acc);
                        ProcessingAccounts.writeFileAccount();
                    }
                    ProcessingEmployee.writeFileEmployee();
                    refresh_Employee();
                    lbStatus_Employee.Text = "Modify SUCCESSFULLY!!!";
                }
                if (ProcessingAccounts.DicAccount.ContainsKey(userNameOld))
                {
                    ProcessingAccounts.DicAccount.Remove(userNameOld);
                    ProcessingAccounts.writeFileAccount();
                }
            }
            else
                lbStatus_Employee.Text = "ID is NOT EXIST!!!";
        }
        private void btnSave_Employee_Click(object sender, EventArgs e)
        {
            ProcessingEmployee.writeFileEmployee();
            lbStatus_Employee.Text = "Saved!!!";
        }

        private void btnChange_Enter(object sender, EventArgs e)
        {
            btnChange_Click(sender, e);
        }

        private void btnlock_Click(object sender, EventArgs e)
        {
            if (!ProcessingAccounts.DicAccountLock.ContainsKey(txtUserName_Employee.Text))
            {
                Account ac = new Account();
                ac.UserName = txtUserName_Employee.Text;
                ac.TypeAccount = ProcessingAccounts.DicAccount[ac.UserName].TypeAccount;
                ac.PassWord = ProcessingAccounts.DicAccount[ac.UserName].PassWord;
                ProcessingAccounts.DicAccountLock.Add(ac.UserName, ac);
                ProcessingAccounts.DicAccount.Remove(ac.UserName);
                ProcessingAccounts.writeFileAccount();
                ProcessingAccounts.writeFileAccountLock();
                lbStatus_Employee.Text = "Account locked!!!";
            }
            else
                lbStatus_Employee.Text = "Account is EXIST in DicLock!!!";
        }

        private void btnUnLock_Click(object sender, EventArgs e)
        {
            if (ProcessingAccounts.DicAccountLock.ContainsKey(txtUserName_Employee.Text))
            {
                Account ac = ProcessingAccounts.DicAccountLock[txtUserName_Employee.Text];
                ProcessingAccounts.DicAccountLock.Remove(ac.UserName);
                ProcessingAccounts.DicAccount.Add(ac.UserName, ac);
                ProcessingAccounts.writeFileAccount();
                ProcessingAccounts.writeFileAccountLock();
                lbStatus_Employee.Text = "Account UnLocked!!!";
            }
            else
                lbStatus_Employee.Text = "Account is EXIST in DicAccount!!!";
        }
        //</User>
    }
}