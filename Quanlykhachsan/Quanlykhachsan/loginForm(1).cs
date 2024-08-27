using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;


namespace Quanlykhachsan
{
    public partial class loginForm : Form
    {

        public loginForm()
        {
            InitializeComponent();
        }
        private void loadFile()
        {
            ProcessingAccounts.readFileAccount();
            ProcessingAccounts.readFileTypeAccount();
            ProcessingEmployee.readFileEmployee();
            ProcessingAccounts.readFileTypeAccount();
            ProcessingRentalSingle.readFileRentalSingle();
            ProcessingRoom.readFile_DicRoom();
            ProcessingTypeRoom.readFileTypeRooms_Price();
            ProcessingTypeRoom.readFileTypeRooms_Rank();
            ProcessingTypeRoom.readFileTypeRooms_Size();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = ProcessingAccounts.DicAccount[txtUserName.Text];
                ProcessingAccounts.Currently = account;
                foreach (Employee ep in ProcessingEmployee.DicEmployee.Values)
                {
                    if (ep.UserName == txtUserName.Text)
                    {
                        ProcessingEmployee.CrrEmployee = ep;
                        break;
                    }
                }
                if (account.TypeAccount=="Manager" && txtPassWord.Text==account.PassWord)
                {
                    loadFile();
                    this.Visible=false;
                    ChooseMode choose = new ChooseMode();

                    choose.ShowDialog();
                    this.Close();
                }
                else if (account.TypeAccount != "Manager" && txtPassWord.Text==account.PassWord)
                {
                    loadFile();
                    this.Visible=false;
                    ReceptionistForm rctForm = new ReceptionistForm();
                    rctForm.ShowDialog();
                    this.Show();
                }
                else wrong.Text = "Wrong username or password!";
            }
            catch (Exception)
            {
                wrong.Text = " Username is not EXIST!";
            }
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            if (ProcessingAccounts.readFileAccount()==false)
            {
                AddFirstAcount afa = new AddFirstAcount();
                afa.ShowDialog();
            }
            ProcessingEmployee.readFileEmployee();

            ProcessingAccounts.readFileAccountLock();
        }
    }
}
