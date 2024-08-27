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
    public partial class RankRoomErrorWarning : Form
    {
        string rankDelete;
        CheckBox cbn;
        public RankRoomErrorWarning(string rank, CheckBox cb)
        {
            InitializeComponent();
            cbn = cb;
            lbNotify_Rank.Text = "There is a room with rank " + rank + ", you can choose a new rank to change the category below, or change the rank of each room in the room management!!!";
            foreach (string s in ProcessingTypeRoom.ListRank)
            {
                if (s != rank)
                    cbbRankRoom.Items.Add(s);
            }
            rankDelete = rank;
            if (cbbRankRoom.Items.Count != 0)
                cbbRankRoom.SelectedIndex = 0;
        }
        private void btnApply_Rank_Click(object sender, EventArgs e)
        {
            foreach (Room room in ProcessingRoom.DicRoom.Values)
            {
                if (room.TypeRoom.Rank == rankDelete)
                    room.TypeRoom.Rank = cbbRankRoom.Text;
            }
            ProcessingTypeRoom.ListRank.Remove(rankDelete);
            cbn.Checked = true;
            this.Close();
        }
    }
}
