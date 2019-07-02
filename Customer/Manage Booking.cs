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
    public partial class Manage_Booking : Form
    {
        public Manage_Booking()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Cus x = new Cus();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Contact_Suppot x = new Contact_Suppot();
            x.Show();
        }
    }
}
