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
    public partial class AdForm : Form
    {
        public AdForm()
        {
            InitializeComponent();
        }

        private void btnAirC_Click(object sender, EventArgs e)
        {
            AircForm airc = new AircForm();
            this.Hide();
            airc.Show();
        }

        private void btnrou_Click(object sender, EventArgs e)
        {
            this.Hide();
            RoutesForm fff = new RoutesForm();
            fff.Show();

        }

        private void btnArf_Click(object sender, EventArgs e)
        {
            this.Hide();
            AirFareForm aff = new AirFareForm();
            aff.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Flights_Form f = new Flights_Form();
            f.Show();
        }

        private void AdForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
