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
    public partial class SizeRoomErrorWarning : Form
    {
        int sizeDelete = 0;
        CheckBox cbn;
        public SizeRoomErrorWarning(int size, CheckBox cb)
        {
            InitializeComponent();
            cbn = cb;
            lbNotify.Text = "There is a room with size " + size + ", you can choose a new size to change the category below, or change the size of each room in the room management!!!";
            foreach (int i in ProcessingTypeRoom.ListSize)
            {
                if (i != size) // Quốc thêm
                    cbbSizeRoom.Items.Add(i);
            }
            sizeDelete = size;
            if (cbbSizeRoom.Items.Count != 0)
                cbbSizeRoom.SelectedIndex = 0;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            foreach (Room room in ProcessingRoom.DicRoom.Values)
            {
                if (room.TypeRoom.Size == sizeDelete)
                    room.TypeRoom.Size = int.Parse(cbbSizeRoom.Text);
            }
            ProcessingTypeRoom.ListSize.Remove(sizeDelete);
            cbn.Checked = true;
            this.Close();
        }
    }
}
