using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace bioritms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void update(object sender, EventArgs e)
        {
            DateTime dzimsh = DateTime.Parse(dateTimePicker1.Text);
            DateTime velamais = DateTime.Parse(dateTimePicker2.Text);
            int t = (int) (velamais - dzimsh).TotalDays;

            if (t > 0)
            {
                label4.Text = ((Math.Sin(2 * Math.PI * t / 23)) * 100).ToString("0.##") + "%";
                label5.Text = ((Math.Sin(2 * Math.PI * t / 28)) * 100).ToString("0.##") + "%";
                label6.Text = ((Math.Sin(2 * Math.PI * t / 33)) * 100).ToString("0.##") + "%";
                label7.ForeColor = Color.Black;
                label8.ForeColor = Color.Black;
            } else {
                label7.ForeColor = Color.Red;
                label8.ForeColor = Color.Red;
                label4.Text = "%";
                label5.Text = "%";
                label6.Text = "%";
            }
            
        }

    }
}
