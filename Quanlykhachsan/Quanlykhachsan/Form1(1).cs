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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/dd/yyyy HH:mm:ss";
        }
        RentalSingle rs = new RentalSingle();

        private void Form1_Load(object sender, EventArgs e)
        {
            rs.TypeRental = "Hour";
            rs.Price = new RentalPrice();
            rs.Price.OverNight =200;
            rs.Price.Day =300;
            rs.Price.NormalHour = 20;
            rs.Price.FirstHour = 50;
            TimeSpan ts = new TimeSpan(1,1,0,0);
            DateTime dateTime  = DateTime.Now;
            double i = 1;
            dateTime = dateTime.AddHours(i);
            label1.Text = dateTime.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rs.TimeCheckin = dateTimePicker1.Value;

            //label1.Text = ProcessingRentalSingle.calculateMoney(rs).ToString();

        }
    }
}
