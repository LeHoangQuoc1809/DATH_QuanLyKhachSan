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
    public partial class FormHistoryBill : Form
    {
        List<ViewUnitSingle> listSingle = new List<ViewUnitSingle>();
        List<ViewUnitGroup> listGroup = new List<ViewUnitGroup>();


        public FormHistoryBill()
        {
            InitializeComponent();
        }
        private void FormHistoryBill_Load(object sender, EventArgs e)
        {
            dtpBegin.Format = DateTimePickerFormat.Custom;
            dtpBegin.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            dtpEnd.Format = DateTimePickerFormat.Custom;
            dtpEnd.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            clearRow();
            renderSingle();
            renderGroup();
            BindingSource bs = new BindingSource();
            bs.DataSource = listSingle.ToList();
            dgvBill.DataSource = bs;
            BindingSource bss = new BindingSource();
            bss.DataSource = listGroup.ToList();
            dgvGroupBillHistory.DataSource = bss;
        }
        void sortSingle(ref List<ViewUnitSingle> list)
        {
            List<ViewUnitSingle> ls = new List<ViewUnitSingle>();
            ViewUnitSingle max1 = new ViewUnitSingle();
            for (int i = 0; i<list.Count; i++)
            {
                ViewUnitSingle max = list[i];
                for (int j = 0; j<list.Count; j++)
                {
                    if (!ls.Contains(max)&&!ls.Contains(list[j])
                        &&DateTime.Compare(max.TimePayment, list[j].TimePayment) <= 0)
                    {
                        max = list[j];
                        if (ls.Contains(list[j]))
                            max = list[j-1];
                    }
                }
                if (!ls.Contains(max))
                {
                    max1=max;
                    ls.Add(max);
                    i--;
                }
            }
            list= ls;
        }
        private void renderSingle()
        {
            ProcessingSingleBill.readFileSingleBill();
            foreach (SingleBill sb in ProcessingSingleBill.ListSingleBill)
            {
                ViewUnitSingle vus = new ViewUnitSingle();
                vus.Roomcode = sb.RentalSingle_Bill.RoomBook.RoomCode;
                vus.TimePayment = sb.TimePayment;
                listSingle.Add(vus);
            }
            sortSingle(ref listSingle);
        }
        private void dgvBill_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1)
            {
                string roomcode = dgvBill.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateTime dt = (DateTime)dgvBill.Rows[e.RowIndex].Cells["TimePayment"].Value;

                SingleBill sb = new SingleBill();
                sb = ProcessingSingleBill.search(roomcode, dt);
                CheckBox cb = new CheckBox();
                pnBill.Controls.Clear();
                FormSingleBill frm = new FormSingleBill(sb, cb);
                frm.TopLevel = false;
                pnBill.Controls.Add(frm);
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }
        void sortGroup(ref List<ViewUnitGroup> list)
        {
            List<ViewUnitGroup> ls = new List<ViewUnitGroup>();
            ViewUnitGroup max1 = new ViewUnitGroup();
            for (int i = 0; i < list.Count; i++)
            {
                ViewUnitGroup max = list[i];
                for (int j = 0; j < list.Count; j++)
                {
                    if (!ls.Contains(max) && !ls.Contains(list[j])
                        && DateTime.Compare(max.TimePayment, list[j].TimePayment) <= 0)
                    {
                        max = list[j];
                        if (ls.Contains(list[j]))
                            max = list[j - 1];
                    }
                }
                if (!ls.Contains(max))
                {
                    max1 = max;
                    ls.Add(max);
                    i--;
                }
            }
            list = ls;
        }
        private void renderGroup()
        {
            ProcessingGroupBill.readFileGroupBill();
            foreach (GroupBill gb in ProcessingGroupBill.ListGroupBill)
            {
                ViewUnitGroup vug = new ViewUnitGroup();
                vug.IDCustomer = gb.RentalGroup_Bill.IDCustomer;
                vug.TimePayment = gb.TimePayment;
                listGroup.Add(vug);
            }
            sortGroup(ref listGroup);
        }



        private void dgvGroupBillHistory_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string id = dgvGroupBillHistory.Rows[e.RowIndex].Cells[0].Value.ToString();
                DateTime dt = (DateTime)dgvGroupBillHistory.Rows[e.RowIndex].Cells[1].Value;

                GroupBill gb = new GroupBill();
                gb = ProcessingGroupBill.search(id, dt);
                CheckBox cb = new CheckBox();
                pnBill.Controls.Clear();
                FormGroupBill frm = new FormGroupBill(gb, cb);
                frm.TopLevel = false;
                pnBill.Controls.Add(frm);
                frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                frm.Dock = DockStyle.Fill;
                frm.Show();
            }
        }
        void clearRow()
        {
            listGroup.Clear();
            listSingle.Clear();
            dgvBill.Rows.Clear();
            dgvGroupBillHistory.Rows.Clear();
        }
        private void btnView_Click(object sender, EventArgs e)
        {
            clearRow();
            double money = 0;
            lbMauDo.Visible = true;
            lbTimeTotalMoney.Visible = true;
            lbTimeTotalMoney.Text = dtpBegin.Value.ToString() + " - " + dtpEnd.Value.ToString() + " : ";
            ProcessingSingleBill.readFileSingleBill();
            foreach (SingleBill sb in ProcessingSingleBill.ListSingleBill)
            {
                if (DateTime.Compare(sb.TimePayment, dtpBegin.Value) >= 0 && DateTime.Compare(sb.TimePayment, dtpEnd.Value) < 0)
                {
                    ViewUnitSingle vus = new ViewUnitSingle();
                    vus.Roomcode = sb.RentalSingle_Bill.RoomBook.RoomCode;
                    vus.TimePayment = sb.TimePayment;
                    listSingle.Add(vus);
                    money += sb.Totalmoney;
                }
            }
            sortSingle(ref listSingle);
            //
            ProcessingGroupBill.readFileGroupBill();
            foreach (GroupBill gb in ProcessingGroupBill.ListGroupBill)
            {
                if (DateTime.Compare(gb.TimePayment, dtpBegin.Value) >= 0 && DateTime.Compare(gb.TimePayment, dtpEnd.Value) < 0)
                {
                    ViewUnitGroup vug = new ViewUnitGroup();
                    vug.IDCustomer = gb.RentalGroup_Bill.IDCustomer;
                    vug.TimePayment = gb.TimePayment;
                    listGroup.Add(vug);
                    money += gb.Totalmoney;
                }
            }
            sortGroup(ref listGroup);
            //
            BindingSource bs = new BindingSource();
            bs.DataSource = listSingle.ToList();
            dgvBill.DataSource = bs;
            BindingSource bss = new BindingSource();
            bss.DataSource = listGroup.ToList();
            dgvGroupBillHistory.DataSource = bss;
            //
            lbTimeTotalMoney.Text += money.ToString();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lbMauDo.Visible = false;
            lbTimeTotalMoney.Visible = false;
            dtpBegin.Value = DateTime.Now;
            dtpEnd.Value = DateTime.Now;
            pnBill.Controls.Clear();
            FormHistoryBill_Load(sender, e);
        }

        private void dtpBegin_ValueChanged(object sender, EventArgs e)
        {
            dtpEnd.MinDate=dtpBegin.Value;
        }
    }
}
