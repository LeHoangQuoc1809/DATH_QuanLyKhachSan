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
    public partial class AddFirstAcount : Form
    {
        public AddFirstAcount()
        {
            InitializeComponent();
        }
        private void txtName_AddFirstAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != ' '))
                e.Handled = true;
        }
        private void txtID_AddFirstAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtAddress_AddFirstAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar)
                && !char.IsLetterOrDigit(e.KeyChar)
                && (e.KeyChar != ' ')
                && (e.KeyChar != ',')
                && (e.KeyChar != '.')
                && (e.KeyChar != '/'))
                e.Handled = true;
        }
        private void txtUserName_AddFirstAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
        private void txtPassWord_AddFirstAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            //    e.Handled = true;
        }
        private void txtAgainPassWord_AddFirstAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            //    e.Handled = true;
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName_AddFirstAccount.Text == ""
                || txtID_AddFirstAccount.Text == ""
                || txtAddress_AddFirstAccount.Text == ""
                || txtUserName_AddFirstAccount.Text == ""
                || txtPassWord_AddFirstAccount.Text == ""
                || txtAgainPassWord_AddFirstAccount.Text == "")
            {
                lbStatus_AddFirstAccount.Text = "Please complete all information!!!";
            }
            else if(txtID_AddFirstAccount.Text.Length<12)
            {
                lbStatus_AddFirstAccount.Text="ID must have 12 characters!!!";
            }
            else if (txtPassWord_AddFirstAccount.Text != txtAgainPassWord_AddFirstAccount.Text)
            {
                lbStatus_AddFirstAccount.Text = "PassWord does not match!!!";
            }
            else
            {
                Account users = new Account(txtUserName_AddFirstAccount.Text, txtPassWord_AddFirstAccount.Text, txtTypeEmployee_AddFirstAccount.Text);
                ProcessingAccounts.DicAccount.Add(users.UserName, users);
                ProcessingAccounts.ListType.Add(txtTypeEmployee_AddFirstAccount.Text);
                Employee employee = new Employee();
                employee.UserName = txtUserName_AddFirstAccount.Text;
                employee.Name = txtName_AddFirstAccount.Text;
                employee.ID = txtID_AddFirstAccount.Text;
                employee.Address = txtAddress_AddFirstAccount.Text;
                employee.BirthDay = dtpDateOfBirth_AddFirstAccount.Value;
                if (rdoMale_AddFirstAccount.Checked)
                    employee.Sex = true;
                else employee.Sex = false;
                employee.TypeEmployee = txtTypeEmployee_AddFirstAccount.Text;
                ProcessingEmployee.DicEmployee.Add(employee.ID, employee);
                ProcessingAccounts.writeFileAccount();
                ProcessingAccounts.writeFileTypeAccount();
                ProcessingEmployee.writeFileEmployee();
                this.Close();
            }
        }
    }
}
