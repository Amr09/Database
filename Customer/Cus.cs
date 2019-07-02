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
    public partial class Cus : Form
    {
        public Cus()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flight_Inquiry x = new Flight_Inquiry();
            x.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
           Manage_Booking x = new Manage_Booking();
            x.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //this.Hide();
            Contact_Suppot x = new Contact_Suppot();
            x.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Deals_Discounts x = new Deals_Discounts();
            x.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            
          AdForm af = new AdForm();
          this.Hide();
          af.Show();
        }

        private void Cus_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
