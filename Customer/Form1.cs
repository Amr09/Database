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
    public partial class RoutesForm : MetroFramework.Forms.MetroForm
    {
        public RoutesForm()
        {
            InitializeComponent();
            this.btnDelete.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libertyAirDataSet1.Route' table. You can move, or remove it, as needed.
            this.routeTableAdapter.Fill(this.libertyAirDataSet1.Route);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.routeTableAdapter.Update(this.libertyAirDataSet1.Route);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            this.routeTableAdapter.DeleteQuery(Id);
            this.routeTableAdapter.Fill(this.libertyAirDataSet1.Route);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      //      if (dataGridView1.SelectedRows.Count > 0)
            {
                this.btnDelete.Enabled = true;
            }
        }

       
    }
}
