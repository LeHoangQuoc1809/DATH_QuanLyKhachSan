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
    public partial class TypeAccountErrorWarning : Form
    {
        string typeAcc = "";
        CheckBox cbn;
        public TypeAccountErrorWarning(string type, CheckBox cb)
        {
            InitializeComponent();
            lbWarning_DeleteTypeAccount.Text = "Detect the existence of a " + type + " type account, deleting the " + type + " account type will cause all the " + type + " type accounts to be lost! Prevent it by changing to a new account type or you can also delete them directly!";
            typeAcc = type;
            cbn = cb;
        }
        private void TypeAccountErrorWarning_Load(object sender, EventArgs e)
        {
            cbbTypeAccount.Enabled = false;
            cbbTypeAccount.Items.Clear();
            foreach (string s in ProcessingAccounts.ListType)
            {
                if (s != "Manager" && s != typeAcc)
                    cbbTypeAccount.Items.Add(s);
            }
            if (cbbTypeAccount.Items.Count == 0)
            {
                btnChangeType1.Enabled = false;
            }
        }

        private void btnChangeType1_Click(object sender, EventArgs e)
        {
            if (btnChangeType1.Text == "Change")
            {
                cbbTypeAccount.Enabled = true;
                btnCancel.BringToFront();
                btnDeleteAll.Enabled = false;
                btnChangeType1.Text = "Apply";
                btnChangeType1.ForeColor = Color.Red;
                btnChangeType1.Font = new Font(btnChangeType1.Font, FontStyle.Bold);
                btnDeleteAll.Enabled = false;
            }
            else
            {
                if (cbbTypeAccount.Text == "")
                {
                    lbStatus.Text = "You must choose TypeAccount!!!";
                }
                else if (!ProcessingAccounts.ListType.Contains(cbbTypeAccount.Text) || cbbTypeAccount.Text == typeAcc)
                {
                    lbStatus.Text = "TypeAccount isn't EXIST!!!";
                }
                else
                {
                    foreach (Account acc in ProcessingAccounts.DicAccount.Values)
                    {
                        if (acc.TypeAccount == typeAcc)
                            acc.TypeAccount = cbbTypeAccount.Text;
                    }
                    foreach (Employee em in ProcessingEmployee.DicEmployee.Values)
                    {
                        if (em.TypeEmployee == typeAcc)
                        {
                            em.TypeEmployee = cbbTypeAccount.Text;
                        }
                    }
                    ProcessingAccounts.ListType.Remove(typeAcc);
                    cbbTypeAccount.Enabled = false;
                    btnChangeType1.Text = "Change";
                    btnChangeType1.ForeColor = Color.Black;
                    btnChangeType1.Font = new Font(btnChangeType1.Font, FontStyle.Regular);
                    cbbTypeAccount.Text = "";
                    btnDeleteAll.Enabled = true;
                    cbn.Checked = true;
                    Close();
                }
            }
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {

            ProcessingAccounts.ListType.Remove(typeAcc);
            List<string> deletewill = new List<string>();
            foreach (Account acc in ProcessingAccounts.DicAccount.Values)
            {
                if (acc.TypeAccount == typeAcc)
                    deletewill.Add(acc.UserName);
            }
            foreach (string us in deletewill)
            {
                ProcessingAccounts.DicAccount.Remove(us);
            }
            foreach (Employee em in ProcessingEmployee.DicEmployee.Values)
            {
                if (em.TypeEmployee == typeAcc)
                {
                    em.UserName = "";
                }
            }
            cbn.Checked = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cbbTypeAccount.Enabled = false;
            btnDeleteAll.Enabled = true;
            btnDeleteAll.BringToFront();
            btnChangeType1.Text = "Change";
            btnChangeType1.ForeColor = Color.Black;
            btnChangeType1.Font = new Font(btnChangeType1.Font, FontStyle.Regular);
            cbbTypeAccount.SelectedIndex = -1;
        }
    }
}