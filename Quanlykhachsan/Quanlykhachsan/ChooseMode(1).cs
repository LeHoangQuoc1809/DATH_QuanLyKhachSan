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
    public partial class ChooseMode : Form
    {
        public ChooseMode()
        {
            InitializeComponent();
        }

        private void btnMng_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManagerForm mngForm = new ManagerForm();
            mngForm.ShowDialog();
            this.Show();
        }

        private void btnRct_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReceptionistForm rctForm=new ReceptionistForm();
            rctForm.ShowDialog();
            this.Show();
        }

        private void ChooseMode_Load(object sender, EventArgs e)
        {

        }
    }
}
