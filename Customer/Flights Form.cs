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
    public partial class Flights_Form : Form
    {
        public Flights_Form()
        {
            InitializeComponent();
        }

        private void Flights_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libertyAirDataSet6.Route' table. You can move, or remove it, as needed.
            this.routeTableAdapter.Fill(this.libertyAirDataSet6.Route);
            // TODO: This line of code loads data into the 'libertyAirDataSet.AirCrafts' table. You can move, or remove it, as needed.
            this.airCraftsTableAdapter.Fill(this.libertyAirDataSet.AirCrafts);
            // TODO: This line of code loads data into the 'libertyAirDataSet5.Flight_Schedule' table. You can move, or remove it, as needed.
            this.flight_ScheduleTableAdapter.Join(this.libertyAirDataSet5.Flight_Schedule);

        }

        private void joinToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.flight_ScheduleTableAdapter.Join(this.libertyAirDataSet5.Flight_Schedule);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.flight_ScheduleTableAdapter.FillBy(this.libertyAirDataSet5.Flight_Schedule);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            String airc = comboBox1.Text;
            int airId =Convert.ToInt32(this.flight_ScheduleTableAdapter.ScalarQueryAircrafts(airc));

           String routeCode = comboBox2.Text;
            int airFID= Convert.ToInt32(this.flight_ScheduleTableAdapter.ScalarQueryAirF(routeCode));

            int flID = Convert.ToInt32(textBox1.Text);
            DateTime dd = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime depT = Convert.ToDateTime(dateTimePicker2.Text);
            DateTime arT = Convert.ToDateTime(dateTimePicker3.Text);

            this.flight_ScheduleTableAdapter.InsertQuery(flID, dd, depT, arT, airId, airFID);



            this.airCraftsTableAdapter.Fill(this.libertyAirDataSet.AirCrafts);
            // TODO: This line of code loads data into the 'libertyAirDataSet5.Flight_Schedule' table. You can move, or remove it, as needed.
            this.flight_ScheduleTableAdapter.Join(this.libertyAirDataSet5.Flight_Schedule);

         //   Console.WriteLine(">>>>" + textBox1.Text + "<<><" + dateTimePicker1.Text + ">>" + dateTimePicker2.Text + "<<" + dateTimePicker3.Text + ">>> " + comboBox1.Text + ">>> " + comboBox2.Text + ">");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            int Id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
            this.flight_ScheduleTableAdapter.DeleteQuery(Id);

            this.airCraftsTableAdapter.Fill(this.libertyAirDataSet.AirCrafts);
            // TODO: This line of code loads data into the 'libertyAirDataSet5.Flight_Schedule' table. You can move, or remove it, as needed.
            this.flight_ScheduleTableAdapter.Join(this.libertyAirDataSet5.Flight_Schedule);
        }

        

      
    }
}
