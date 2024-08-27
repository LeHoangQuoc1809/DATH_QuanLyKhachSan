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
    public partial class TypeRoomMngForm : Form
    {
        public TypeRoomMngForm()
        {
            InitializeComponent();
        }
        private void TypeRoomMngForm_Load(object sender, EventArgs e)
        {
            if (ProcessingTypeRoom.readFileTypeRooms_Size()
                && ProcessingTypeRoom.readFileTypeRooms_Rank())
            {
                lbStatus_Size.Text = "Load file Size SUCCESSFULLY!!!";
                lbStatus_Rank.Text = "Load file Rank SUCCESSFULLY!!!";
            }
            else
            {
                lbStatus_Size.Text = "Load file Failure!!!";
            }
            showSize();
            refresh_Size();
            showRank();
            refresh_Rank();
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            showSize();
            showRank();
        }
        //<Size>
        private void showSize()
        {
            int j = 0;
            ProcessingTypeRoom.ListSize.Sort();
            dgvSize.Rows.Clear();
            cbbSizeRoom.Items.Clear();
            foreach (int i in ProcessingTypeRoom.ListSize)
            {
                dgvSize.Rows.Add();
                dgvSize.Rows[j++].Cells[0].Value = i;
                cbbSizeRoom.Items.Add(i);
            }
            dgvRank.Columns[0].ReadOnly = true;

        }
        private void refresh_Size()
        {
            cbbSizeRoom.Text = string.Empty;
            cbbSizeRoom.Enabled = false;
            txtNewSizeRoom.Text = string.Empty;
        }
        private void txtNewSizeRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dgvSize_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                cbbSizeRoom.Text = dgvSize.Rows[e.RowIndex].Cells[0].Value.ToString();
            dgvSize.Columns[0].ReadOnly = true;
        }
        private void btnAdd_Size_Click(object sender, EventArgs e)
        {
            if (txtNewSizeRoom.Text == "")
            {
                lbStatus_Size.Text = "You must Enter New SizeRoom!!!";
            }
            else if (ProcessingTypeRoom.add_ListSize(int.Parse(txtNewSizeRoom.Text)) != -1)
            {
                lbStatus_Size.Text = "Add size SUCCESSFULLY!!!";
                ProcessingTypeRoom.writeFileTypeRooms_Size();
                //Change DicType and file
                foreach (string s in ProcessingTypeRoom.ListRank)
                {
                    RentalPrice rp = new RentalPrice();
                    ProcessingTypeRoom.DicRentalPrice.Add(txtNewSizeRoom.Text + '-' + s, rp);
                }
                ProcessingTypeRoom.writeFileTypeRooms_Price();
                showSize();
                refresh_Size();
            }
            else lbStatus_Size.Text = "Size was EXIST!!!";
        }
        private void btnDelete_Size_Click(object sender, EventArgs e)
        {
            if (btnDelete_Size.Text == "Delete")
            {
                btnAdd_Size.Enabled = false;
                btnModify_Size.Enabled = false;
                btnSave_Size.Enabled = false;
                cbbSizeRoom.Enabled = true;
                txtNewSizeRoom.Enabled = false;
                txtNewSizeRoom.Text = "";
                btnDelete_Size.Text = "Apply";
                btnDelete_Size.ForeColor = Color.Red;
                btnDelete_Size.Font = new Font(btnDelete_Size.Font, FontStyle.Bold);
                lbStatus_Size.Text = "Choose Size need Delete at 'SizeRoom' and click 'Apply'";
                btnCancel_Size.BringToFront();
            }
            else
            {
                int i;
                bool flag = false;
                CheckBox cb = new CheckBox();
                cb.Checked = false;
                if (cbbSizeRoom.SelectedIndex == -1)
                {
                    lbStatus_Size.Text = "You must choose SizeRoom!!!";
                }
                else if (ProcessingTypeRoom.ListSize.Contains(int.Parse(cbbSizeRoom.Text)))
                {
                    i = int.Parse(cbbSizeRoom.Text);
                    foreach (Room room in ProcessingRoom.DicRoom.Values)
                    {
                        if (room.TypeRoom.Size == i)
                        {
                            flag = true;
                            if (cbbSizeRoom.Items.Count == 1)
                            {
                                MessageBox.Show("This operation will affect rooms with size " + i + ", " +
                                    "please add size to make it", "ERROR"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            else
                            {
                                SizeRoomErrorWarning sizeRoomErrorWarning = new SizeRoomErrorWarning(i, cb);
                                sizeRoomErrorWarning.ShowDialog();
                                break;
                            }
                        }
                    }
                    if (cb.Checked)
                    {
                        List<string> deletewill = new List<string>();
                        foreach (string s in ProcessingTypeRoom.DicRentalPrice.Keys)
                        {
                            int j = 0;
                            for (; j < s.Length; j++)
                            {
                                if (s[j] == '-')
                                    break;
                            }
                            string str = s.Substring(0, j);
                            string str1 = cbbSizeRoom.Text;
                            if (str == str1)
                                deletewill.Add(s);
                        }
                        //
                        foreach (string s in deletewill)
                        {
                            ProcessingTypeRoom.DicRentalPrice.Remove(s);
                        }
                        btnCancel_Size_Click(sender, e);
                        lbStatus_Size.Text = "Deleted!!!";
                    }
                    else cbbSizeRoom.Enabled = true;
                    if (!flag)
                    {
                        List<string> deletewill = new List<string>();
                        foreach (string s in ProcessingTypeRoom.DicRentalPrice.Keys)
                        {
                            int j = 0;
                            for (; j < s.Length; j++)
                            {
                                if (s[j] == '-')
                                    break;
                            }
                            string str = s.Substring(0, j);
                            string str1 = cbbSizeRoom.Text;
                            if (str == str1)
                                deletewill.Add(s);
                        }
                        //
                        foreach (string s in deletewill)
                        {
                            ProcessingTypeRoom.DicRentalPrice.Remove(s);
                        }
                        ProcessingTypeRoom.ListSize.Remove(i);
                        btnCancel_Size_Click(sender, e);
                        lbStatus_Size.Text = "Deleted!!!";
                    }
                    //
                    ProcessingTypeRoom.writeFileTypeRooms_Price();
                    ProcessingRoom.writeFile_DicRoom();
                    showSize();
                    ProcessingTypeRoom.writeFileTypeRooms_Size();
                }
            }
        }
        private void btnModify_Size_Click(object sender, EventArgs e)
        {
            if (btnModify_Size.Text == "Modify")
            {
                btnAdd_Size.Enabled = false;
                btnDelete_Size.Enabled = false;
                btnSave_Size.Enabled = false;
                cbbSizeRoom.Enabled = true;
                txtNewSizeRoom.Text = "";
                btnModify_Size.Text = "Apply";
                btnModify_Size.ForeColor = Color.Red;
                btnModify_Size.Font = new Font(btnDelete_Size.Font, FontStyle.Bold);
                lbStatus_Size.Text = "Choose Size need Modify at 'SizeRoom' and Enter NewSize";
                btnCancel_Size.BringToFront();
            }
            else
            {
                if (txtNewSizeRoom.Text == "")
                {
                    lbStatus_Size.Text = "You must Enter New SizeRoom!!!";
                }
                else if (cbbSizeRoom.Text == "")
                {
                    lbStatus_Size.Text = "You must choose SizeRoom!!!";
                }
                else
                {
                    int crr = int.Parse(cbbSizeRoom.Text), newS = int.Parse(txtNewSizeRoom.Text);
                    int indexDelete = ProcessingTypeRoom.ListSize.LastIndexOf(crr);

                    List<string> deletewill = new List<string>();
                    if (ProcessingTypeRoom.ListSize.Contains(newS))
                    {
                        foreach (string s in ProcessingTypeRoom.DicRentalPrice.Keys)
                        {
                            int j = 0;
                            for (; j < s.Length; j++)
                            {
                                if (s[j] == '-') break;
                            }
                            string rank = s.Substring(j + 1);
                            string size = s.Substring(0, j);
                            string str1 = cbbSizeRoom.Text;
                            string typenew = "";
                            if (size == str1)
                            {
                                typenew = newS + "-" + rank;
                                ProcessingTypeRoom.DicRentalPrice[s].FirstHour = ProcessingTypeRoom.DicRentalPrice[typenew].FirstHour;
                                ProcessingTypeRoom.DicRentalPrice[s].NormalHour = ProcessingTypeRoom.DicRentalPrice[typenew].NormalHour;
                                ProcessingTypeRoom.DicRentalPrice[s].Day = ProcessingTypeRoom.DicRentalPrice[typenew].Day;
                                ProcessingTypeRoom.DicRentalPrice[s].OverNight = ProcessingTypeRoom.DicRentalPrice[typenew].OverNight;
                                deletewill.Add(s);
                            }
                        }
                    }
                    else
                    {
                        string typenew = "";
                        foreach (string i in ProcessingTypeRoom.ListRank)
                        {
                            typenew = newS.ToString() + "-" + i.ToString();
                            RentalPrice rp = new RentalPrice();
                            ProcessingTypeRoom.DicRentalPrice.Add(typenew, rp);
                            deletewill.Add(crr.ToString() + "-" + i.ToString());
                        }
                    }
                    //
                    foreach (string s in deletewill)
                    {
                        ProcessingTypeRoom.DicRentalPrice.Remove(s);
                    }
                    //
                    if (ProcessingTypeRoom.ListSize.Contains(newS))
                    {
                        foreach (Room room in ProcessingRoom.DicRoom.Values)
                            if (room.TypeRoom.Size == crr) room.TypeRoom.Size = newS;
                    }
                    else
                    {
                        ProcessingTypeRoom.ListSize.Add(newS);
                        foreach (Room room in ProcessingRoom.DicRoom.Values)
                            if (room.TypeRoom.Size == crr) room.TypeRoom.Size = newS;
                    }
                    ProcessingTypeRoom.ListSize.RemoveAt(indexDelete);
                    ProcessingTypeRoom.writeFileTypeRooms_Price();
                    ProcessingTypeRoom.writeFileTypeRooms_Size();
                    ProcessingRoom.writeFile_DicRoom();
                    showSize();
                    btnCancel_Size_Click(sender, e);
                    lbStatus_Size.Text = "Modified!!!";
                }
            }
        }
        private void btnSave_Size_Click(object sender, EventArgs e)
        {
            if (ProcessingTypeRoom.writeFileTypeRooms_Size())
            {
                lbStatus_Size.Text = "Saved!!!";
            }
            else
            {
                lbStatus_Size.Text = "Save is error!!!";
            }
        }
        private void btnCancel_Size_Click(object sender, EventArgs e)
        {
            cbbSizeRoom.SelectedIndex = -1;
            txtNewSizeRoom.Text = "";
            // Cancel of delete
            btnAdd_Size.Enabled = true;
            btnModify_Size.Enabled = true;
            btnSave_Size.Enabled = true;
            cbbSizeRoom.Enabled = false;
            txtNewSizeRoom.Enabled = true;
            btnDelete_Size.Text = "Delete";
            btnDelete_Size.ForeColor = Color.Black;
            btnDelete_Size.Font = new Font(btnDelete_Size.Font, FontStyle.Regular);
            lbStatus_Size.Text = string.Empty;
            btnSave_Size.BringToFront();
            // Cancel of Modify
            btnAdd_Size.Enabled = true;
            btnDelete_Size.Enabled = true;
            btnSave_Size.Enabled = true;
            cbbSizeRoom.Enabled = false;
            txtNewSizeRoom.Enabled = true;
            btnModify_Size.Text = "Modify";
            btnModify_Size.ForeColor = Color.Black;
            btnModify_Size.Font = new Font(btnDelete_Size.Font, FontStyle.Regular);
            lbStatus_Size.Text = string.Empty;
            btnSave_Size.BringToFront();
        }

        //</Size>
        //---------------------------------------------------------------------------------------------//

        //<Rank>
        private void showRank()
        {
            int j = 0;
            ProcessingTypeRoom.ListRank.Sort();
            dgvRank.Rows.Clear();
            cbbRankRoom.Items.Clear();
            foreach (string i in ProcessingTypeRoom.ListRank)
            {
                dgvRank.Rows.Add();
                dgvRank.Rows[j++].Cells[0].Value = i;
                cbbRankRoom.Items.Add(i);
            }
            dgvRank.Columns[0].ReadOnly = true;

        }
        private void refresh_Rank()
        {
            cbbRankRoom.Text = string.Empty;
            cbbRankRoom.Enabled = false;
            txtNewRankRoom.Text = string.Empty;
        }
        private void txtNewRankRoom_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Xác thực rằng phím vừa nhấn không phải CTRL hoặc không phải dạng số và chữ
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void dgvRank_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
                cbbRankRoom.Text = dgvRank.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private void btnAdd_Rank_Click(object sender, EventArgs e)
        {
            if (txtNewRankRoom.Text == "")
            {
                lbStatus_Size.Text = "You must Enter New RankRoom!!!";
            }
            else if (ProcessingTypeRoom.add_ListRank(txtNewRankRoom.Text) != null)
            {
                lbStatus_Rank.Text = "Add rank SUCCESSFULLY!!!";
                ProcessingTypeRoom.writeFileTypeRooms_Rank();
                //Change DicType and file
                foreach (int i in ProcessingTypeRoom.ListSize)
                {
                    RentalPrice rp = new RentalPrice();
                    ProcessingTypeRoom.DicRentalPrice.Add(i.ToString() + '-' + txtNewRankRoom.Text, rp);
                }
                ProcessingTypeRoom.writeFileTypeRooms_Price();
                showRank();
                refresh_Rank();
            }
            else lbStatus_Rank.Text = "Rank was EXIST!!!";
        }
        private void btnDelete_Rank_Click(object sender, EventArgs e)
        {
            if (btnDelete_Rank.Text=="Delete")
            {
                btnAdd_Rank.Enabled = false;
                btnModify_Rank.Enabled = false;
                btnSave_Rank.Enabled = false;
                cbbRankRoom.Enabled = true;
                txtNewRankRoom.Enabled = false;
                txtNewRankRoom.Text = "";
                btnDelete_Rank.Text = "Apply";
                btnDelete_Rank.ForeColor = Color.Red;
                btnDelete_Rank.Font = new Font(btnDelete_Size.Font, FontStyle.Bold);
                lbStatus_Rank.Text = "Choose Rank need Delete at 'RankRoom' and click 'Apply'";
                btnCancel_Rank.BringToFront();
            }
            else
            {
                bool flag = false;
                CheckBox cb = new CheckBox();
                cb.Checked = false;
                if (cbbRankRoom.SelectedIndex == -1)
                {
                    lbStatus_Rank.Text = "You must choose RankRoom!!!";
                }
                else if (ProcessingTypeRoom.ListRank.Contains(cbbRankRoom.Text))
                {
                    foreach (Room room in ProcessingRoom.DicRoom.Values)
                    {
                        if (room.TypeRoom.Rank == cbbRankRoom.Text)
                        {
                            flag = true;
                            if (cbbRankRoom.Items.Count == 1)
                            {
                                MessageBox.Show("This operation will affect rooms with Rank " + cbbRankRoom.Text + ", " +
                                    "please add Rank to make it", "ERROR"
                                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                                break;
                            }
                            else
                            {
                                RankRoomErrorWarning rankRoomErrorWarning = new RankRoomErrorWarning(cbbRankRoom.Text, cb);
                                rankRoomErrorWarning.ShowDialog();
                                break;
                            }
                        }
                    }
                    if (cb.Checked)
                    {
                        List<string> deletewill = new List<string>();
                        foreach (string s in ProcessingTypeRoom.DicRentalPrice.Keys)
                        {
                            int j = 0;
                            for (; j < s.Length; j++)
                            {
                                if (s[j] == '-') break;
                            }
                            string str = s.Substring(j + 1);
                            string str1 = cbbRankRoom.Text;
                            if (str == str1)
                                deletewill.Add(s);
                        }
                        //
                        foreach (string s in deletewill)
                        {
                            ProcessingTypeRoom.DicRentalPrice.Remove(s);
                        }
                        btnCancel_Rank_Click(sender, e);
                        lbStatus_Rank.Text = "Deleted!!!";
                    }
                    else cbbSizeRoom.Enabled = true;
                    if (!flag)
                    {
                        List<string> deletewill = new List<string>();
                        foreach (string s in ProcessingTypeRoom.DicRentalPrice.Keys)
                        {
                            int j = 0;
                            for (; j < s.Length; j++)
                            {
                                if (s[j] == '-') break;
                            }
                            string str = s.Substring(j + 1);
                            string str1 = cbbRankRoom.Text;
                            if (str == str1)
                                deletewill.Add(s);
                        }
                        //
                        foreach (string s in deletewill)
                        {
                            ProcessingTypeRoom.DicRentalPrice.Remove(s);
                        }
                        ProcessingTypeRoom.ListRank.Remove(cbbRankRoom.Text);
                        btnCancel_Rank_Click(sender, e);
                        lbStatus_Rank.Text = "Deleted!!!";
                    }
                    //
                    ProcessingTypeRoom.writeFileTypeRooms_Price();
                    ProcessingRoom.writeFile_DicRoom();
                    showRank();
                    ProcessingTypeRoom.writeFileTypeRooms_Rank();
                }
            }
        }
        private void btnModify_Rank_Click(object sender, EventArgs e)
        {
            if (btnModify_Rank.Text == "Modify")
            {
                btnAdd_Rank.Enabled = false;
                btnDelete_Rank.Enabled = false;
                btnSave_Rank.Enabled = false;
                cbbRankRoom.Enabled = true;
                txtNewRankRoom.Text = "";
                btnModify_Rank.Text = "Apply";
                btnModify_Rank.ForeColor = Color.Red;
                btnModify_Rank.Font = new Font(btnDelete_Size.Font, FontStyle.Bold);
                lbStatus_Rank.Text = "Choose Size need Modify at 'SizeRoom' and Enter NewSize";
                btnCancel_Rank.BringToFront();
            }
            else
            {
                if (txtNewRankRoom.Text == "")
                {
                    lbStatus_Rank.Text = "You must Enter New RankRoom!!!";
                }
                else if (cbbRankRoom.Text == "")
                {
                    lbStatus_Rank.Text = "You must choose RankRoom!!!";
                }
                else
                {
                    string crr = cbbRankRoom.Text, newR = txtNewRankRoom.Text;
                    int indexDelete = ProcessingTypeRoom.ListRank.LastIndexOf(crr);
                    //
                    List<string> deletewill = new List<string>();
                    if (ProcessingTypeRoom.ListRank.Contains(newR))
                    {
                        foreach (string s in ProcessingTypeRoom.DicRentalPrice.Keys)
                        {
                            int j = 0;
                            for (; j < s.Length; j++)
                            {
                                if (s[j] == '-') break;
                            }
                            string rank = s.Substring(j + 1);
                            string size = s.Substring(0, j);
                            string str1 = cbbRankRoom.Text;
                            string typenew = "";
                            if (rank == str1)
                            {
                                typenew = size + "-" + newR;
                                ProcessingTypeRoom.DicRentalPrice[typenew].FirstHour = ProcessingTypeRoom.DicRentalPrice[s].FirstHour;
                                ProcessingTypeRoom.DicRentalPrice[typenew].NormalHour = ProcessingTypeRoom.DicRentalPrice[s].NormalHour;
                                ProcessingTypeRoom.DicRentalPrice[typenew].Day = ProcessingTypeRoom.DicRentalPrice[s].Day;
                                ProcessingTypeRoom.DicRentalPrice[typenew].OverNight = ProcessingTypeRoom.DicRentalPrice[s].OverNight;
                                deletewill.Add(s);
                            }
                        }
                    }
                    else
                    {
                        string typenew = "";
                        foreach (int i in ProcessingTypeRoom.ListSize)
                        {
                            typenew = i.ToString() + "-" + newR;
                            RentalPrice rp = new RentalPrice();
                            ProcessingTypeRoom.DicRentalPrice.Add(typenew, rp);
                            ProcessingTypeRoom.DicRentalPrice[typenew].FirstHour = ProcessingTypeRoom.DicRentalPrice[i.ToString() + "-" + crr].FirstHour;
                            ProcessingTypeRoom.DicRentalPrice[typenew].NormalHour = ProcessingTypeRoom.DicRentalPrice[i.ToString() + "-" + crr].NormalHour;
                            ProcessingTypeRoom.DicRentalPrice[typenew].Day = ProcessingTypeRoom.DicRentalPrice[i.ToString() + "-" + crr].Day;
                            ProcessingTypeRoom.DicRentalPrice[typenew].OverNight = ProcessingTypeRoom.DicRentalPrice[i.ToString() + "-" + crr].OverNight;
                            deletewill.Add(i.ToString()+"-"+crr);
                        }
                    }
                    //
                    foreach (string s in deletewill)
                    {

                        ProcessingTypeRoom.DicRentalPrice.Remove(s);
                    }
                    //
                    if (ProcessingTypeRoom.ListRank.Contains(newR))
                    {
                        foreach (Room room in ProcessingRoom.DicRoom.Values)
                            if (room.TypeRoom.Rank == crr) room.TypeRoom.Rank = newR;
                    }
                    else
                    {
                        ProcessingTypeRoom.ListRank.Add(newR);
                        foreach (Room room in ProcessingRoom.DicRoom.Values)
                        {
                            if (room.TypeRoom.Rank == crr) room.TypeRoom.Rank = newR;
                        }
                    }
                    ProcessingTypeRoom.ListRank.RemoveAt(indexDelete);
                    //
                    ProcessingTypeRoom.writeFileTypeRooms_Price();
                    ProcessingTypeRoom.writeFileTypeRooms_Rank();
                    ProcessingRoom.writeFile_DicRoom();
                    showRank();
                    btnCancel_Rank_Click(sender, e);
                    lbStatus_Rank.Text = "Modified!!!";
                }
            }
        }
        private void btnSave_Rank_Click(object sender, EventArgs e)
        {
            if (ProcessingTypeRoom.writeFileTypeRooms_Rank())
            {
                lbStatus_Rank.Text = "Saved!!!";
            }
            else
            {
                lbStatus_Rank.Text = "Save is error!!!";
            }
        }
        private void btnCancel_Rank_Click(object sender, EventArgs e)
        {
            cbbRankRoom.SelectedIndex = -1;
            txtNewRankRoom.Text = "";
            // Cancel of delete
            btnAdd_Rank.Enabled = true;
            btnModify_Rank.Enabled = true;
            btnSave_Rank.Enabled = true;
            cbbRankRoom.Enabled = false;
            txtNewRankRoom.Enabled = true;
            btnDelete_Rank.Text = "Delete";
            btnDelete_Rank.ForeColor = Color.Black;
            btnDelete_Rank.Font = new Font(btnDelete_Size.Font, FontStyle.Regular);
            lbStatus_Rank.Text = string.Empty;
            btnSave_Rank.BringToFront();
            // Cancel of Modify
            btnAdd_Rank.Enabled = true;
            btnDelete_Rank.Enabled = true;
            btnSave_Rank.Enabled = true;
            cbbRankRoom.Enabled = false;
            txtNewRankRoom.Enabled = true;
            btnModify_Rank.Text = "Modify";
            btnModify_Rank.ForeColor = Color.Black;
            btnModify_Rank.Font = new Font(btnDelete_Size.Font, FontStyle.Regular);
            lbStatus_Rank.Text = string.Empty;
            btnSave_Rank.BringToFront();
        }

        private void tpSize_Click(object sender, EventArgs e)
        {

        }

        //</Rank>

    }
}
