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
    public partial class AircForm : MetroFramework.Forms.MetroForm
    {
        public AircForm()
        {
            InitializeComponent();
            this.StyleManager = msm;
            this.mbtndelete.Enabled = false;
            
        }

        private void AircForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libertyAirDataSet.AirCrafts' table. You can move, or remove it, as needed.
            this.airCraftsTableAdapter.Fill(this.libertyAirDataSet.AirCrafts);

        }

        /*private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.airCraftsTableAdapter.Update(this.libertyAirDataSet.AirCrafts);
        }*/

      /*  private void btnDel_Click(object sender, EventArgs e)
        {
           
            int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            this.airCraftsTableAdapter.DeleteQuery1(Id);
            this.airCraftsTableAdapter.Update(this.libertyAirDataSet.AirCrafts);
            this.airCraftsTableAdapter.Fill(this.libertyAirDataSet.AirCrafts);
        }
        */
        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (metroGrid1.SelectedRows.Count > 0)
            {
                this.mbtndelete.Enabled = true;
            }
        }

        private void mbtnupdate_Click(object sender, EventArgs e)
        {
            this.airCraftsTableAdapter.Update(this.libertyAirDataSet.AirCrafts);
        }

        private void mbtndelete_Click(object sender, EventArgs e)

        {
            
                int Id = Convert.ToInt32(metroGrid1.SelectedRows[0].Cells[0].Value);
                this.airCraftsTableAdapter.DeleteQuery1(Id);
                this.airCraftsTableAdapter.Update(this.libertyAirDataSet.AirCrafts);
                this.airCraftsTableAdapter.Fill(this.libertyAirDataSet.AirCrafts);
            
        }

        
    }
}
