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
    public partial class ChangeTypeAccountForm : Form
    {

        public ChangeTypeAccountForm()
        {
            InitializeComponent();
        }
        public void show_TypeAccount()
        {
            //BindingSource bs = new BindingSource();
            //bs.DataSource = ProcessingAccounts.ListType;
            //dgvTypeAccount.DataSource = bs;
            dgvTypeAccount.Rows.Clear();
            int i = 0;
            foreach (string s in ProcessingAccounts.ListType)
            {
                dgvTypeAccount.Rows.Add();
                dgvTypeAccount.Rows[i].Cells[0].Value = s;
                i++;
            }
            //
            cbbTypeAccount.Items.Clear();
            foreach (string s in ProcessingAccounts.ListType)
            {
                if (s != "Manager")
                    cbbTypeAccount.Items.Add(s);
            }
            //
            txtNewTypeAccount.Text = string.Empty;
            //
            cbbTypeAccount.Text = string.Empty;
        }
        private void ChangeTypeAccount_Load(object sender, EventArgs e)
        {
            dgvTypeAccount.Columns[0].ReadOnly = true;
            ProcessingAccounts.readFileTypeAccount();
            show_TypeAccount();
            cbbTypeAccount.Enabled = false;
        }
        private void txtNewTypeAccount_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số và chữ
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void btnAdd_TypeAccount_Click(object sender, EventArgs e)
        {
            if (txtNewTypeAccount.Text == "")
            {
                lbStatus_TypeAccount.Text = "You must Enter new TypeAccount!!!";
            }
            else if (ProcessingAccounts.ListType.Contains(txtNewTypeAccount.Text))
            {
                lbStatus_TypeAccount.Text = "Type was EXIST!!!";
            }
            else
            {
                lbStatus_TypeAccount.Text = "Added !!!";
                ProcessingAccounts.ListType.Add(txtNewTypeAccount.Text);
                ProcessingAccounts.writeFileTypeAccount();
                show_TypeAccount();
            }
        }

        private void btnModify_TypeAccount_Click(object sender, EventArgs e)
        {
            if (btnModify_TypeAccount.Text == "Modify")
            {
                btnAdd_TypeAccount.Enabled = false;
                btnDelete_TypeAccount.Enabled = false;
                btnSave_TypeAccount.Enabled = false;
                cbbTypeAccount.Enabled = true;
                btnModify_TypeAccount.Text = "Apply";
                btnModify_TypeAccount.ForeColor = Color.Red;
                btnModify_TypeAccount.Font = new Font(btnModify_TypeAccount.Font, FontStyle.Bold);
                lbStatus_TypeAccount.Text = "Choose type need change at 'TypeAccount' and enter newType";
                btnCancel_TypeAccount.BringToFront();
            }
            else
            {
                if (txtNewTypeAccount.Text == "")
                {
                    lbStatus_TypeAccount.Text = "You must enter a new account type!!!";
                }
                else if (cbbTypeAccount.Text == "Manager")
                {
                    lbStatus_TypeAccount.Text = "Can't change Type Manager!!!";
                }
                else if (!ProcessingAccounts.ListType.Contains(cbbTypeAccount.Text))
                {
                    lbStatus_TypeAccount.Text = "TypeAccount isn't EXIST!!!";
                }
                else
                {
                    if (txtNewTypeAccount.Text == "Manager")
                    {
                        lbStatus_TypeAccount.Text = "Can't change to Type Manager!!!";
                    }
                    else
                    {
                        int i = ProcessingAccounts.ListType.IndexOf(cbbTypeAccount.Text);
                        if (ProcessingAccounts.ListType.Contains(txtNewTypeAccount.Text))
                        {
                            ProcessingAccounts.ListType[i] = txtNewTypeAccount.Text;
                        }
                        else
                        {
                            ProcessingAccounts.ListType.Add(txtNewTypeAccount.Text);
                        }
                        foreach (Account acc in ProcessingAccounts.DicAccount.Values)
                        {
                            if (acc.TypeAccount == cbbTypeAccount.Text)
                                acc.TypeAccount = txtNewTypeAccount.Text;
                        }
                        ProcessingAccounts.ListType.RemoveAt(i);
                        lbStatus_TypeAccount.Text = "Modifed!!!";
                        btnAdd_TypeAccount.Enabled = true;
                        btnDelete_TypeAccount.Enabled = true;
                        btnSave_TypeAccount.Enabled = true;
                        cbbTypeAccount.Enabled = false;
                        btnSave_TypeAccount.BringToFront();
                        btnSave_TypeAccount.Enabled = true;
                        btnModify_TypeAccount.Text = "Modify";
                        btnModify_TypeAccount.ForeColor = Color.Black;
                        btnModify_TypeAccount.Font = new Font(btnModify_TypeAccount.Font, FontStyle.Regular);
                        ProcessingAccounts.writeFileTypeAccount();
                        ProcessingAccounts.writeFileAccount();
                        ProcessingEmployee.writeFileEmployee();
                        show_TypeAccount();
                    }
                }
            }
        }
        private void btnDelete_TypeAccount_Click(object sender, EventArgs e)
        {
            if (btnDelete_TypeAccount.Text == "Delete")
            {
                btnAdd_TypeAccount.Enabled = false;
                btnModify_TypeAccount.Enabled = false;
                btnSave_TypeAccount.Enabled = false;
                cbbTypeAccount.Enabled = true;
                txtNewTypeAccount.Enabled = false;
                txtNewTypeAccount.Text = "";
                btnDelete_TypeAccount.Text = "Apply";
                btnDelete_TypeAccount.ForeColor = Color.Red;
                btnDelete_TypeAccount.Font = new Font(btnDelete_TypeAccount.Font, FontStyle.Bold);
                lbStatus_TypeAccount.Text = "Choose type need Delete at 'TypeAccount' and click 'Apply'";
                btnCancel_TypeAccount.BringToFront();
            }
            else
            {
                if (cbbTypeAccount.Text == "")
                {
                    lbStatus_TypeAccount.Text = "You must choose account type!!!";
                }
                else if (cbbTypeAccount.Text == "Manager")
                {
                    lbStatus_TypeAccount.Text = "Can't delete Type Manager!!!";
                }
                else if (ProcessingAccounts.ListType.Contains(cbbTypeAccount.Text))
                {
                    bool flag = false;
                    CheckBox cb = new CheckBox();
                    cb.Checked = false;
                    foreach (Account acc in ProcessingAccounts.DicAccount.Values)
                    {
                        if (acc.TypeAccount == cbbTypeAccount.Text)
                        {
                            flag = true;

                            TypeAccountErrorWarning taew = new TypeAccountErrorWarning(cbbTypeAccount.Text, cb);
                            taew.ShowDialog();
                            break;
                        }
                    }
                    if (cb.Checked)
                    {
                        btnCancel_TypeAccount_Click(sender, e);
                        show_TypeAccount();
                        lbStatus_TypeAccount.Text = "Deleted!!!";
                    }
                    if (!flag)
                    {
                        ProcessingAccounts.ListType.Remove(cbbTypeAccount.Text);
                        lbStatus_TypeAccount.Text = "Deleted!!!";
                        cbbTypeAccount.Enabled = false;
                        txtNewTypeAccount.Enabled = true;
                        btnDelete_TypeAccount.Text = "Delete";
                        btnDelete_TypeAccount.ForeColor = Color.Black;
                        btnDelete_TypeAccount.Font = new Font(btnDelete_TypeAccount.Font, FontStyle.Regular);
                        btnAdd_TypeAccount.Enabled = true;
                        btnModify_TypeAccount.Enabled = true;
                        btnSave_TypeAccount.Enabled = true;
                        btnSave_TypeAccount.BringToFront();
                    }
                    ProcessingAccounts.writeFileTypeAccount();
                    ProcessingAccounts.writeFileAccount();
                    ProcessingEmployee.writeFileEmployee();
                    show_TypeAccount();
                }
            }
        }

        private void btnSave_TypeAccount_Click(object sender, EventArgs e)
        {
            ProcessingAccounts.writeFileTypeAccount();
            lbStatus_TypeAccount.Text = "Saved!!!";
        }

        private void btnCancel_TypeAccount_Click(object sender, EventArgs e)
        {
            //
            cbbTypeAccount.Text = string.Empty;
            txtNewTypeAccount.Text = string.Empty;
            cbbTypeAccount.Enabled = false;
            lbStatus_TypeAccount.Text = string.Empty;
            // Cancel của Modify
            btnAdd_TypeAccount.Enabled = true;
            btnDelete_TypeAccount.Enabled = true;
            btnSave_TypeAccount.Enabled = true;
            btnSave_TypeAccount.BringToFront();
            cbbTypeAccount.SelectedIndex = -1;
            btnModify_TypeAccount.Text = "Modify";
            btnModify_TypeAccount.ForeColor = Color.Black;
            btnModify_TypeAccount.Font = new Font(btnModify_TypeAccount.Font, FontStyle.Regular);
            // Cancel của Delete
            txtNewTypeAccount.Enabled = true;
            btnModify_TypeAccount.Enabled = true;
            btnDelete_TypeAccount.Text = "Delete";
            btnDelete_TypeAccount.ForeColor = Color.Black;
            btnDelete_TypeAccount.Font = new Font(btnModify_TypeAccount.Font, FontStyle.Regular);
        }
        private void dgvTypeAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                cbbTypeAccount.Text = dgvTypeAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            dgvTypeAccount.Columns[0].ReadOnly = true;
        }
    }
}