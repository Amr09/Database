using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer
{
    public partial class Flight_Inquiry : Form
    {
        public Flight_Inquiry()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contact_Suppot x = new Contact_Suppot();
            x.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cus x = new Cus();
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
