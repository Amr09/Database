using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Customer
{
    public partial class AirFareForm : Form
    {
        public AirFareForm()
        {
            InitializeComponent();
            
        }

        private void AirFareForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libertyAirDataSet4.Route' table. You can move, or remove it, as needed.
            this.routeTableAdapter.Fill(this.libertyAirDataSet4.Route);
            // TODO: This line of code loads data into the 'libertyAirDataSet3.AirFare' table. You can move, or remove it, as needed.
            this.airFareTableAdapter.Fill(this.libertyAirDataSet3.AirFare);
          //  Fillcombo();

        }
        protected void Fillcombo()
        {
            comboBox1.DataSource = this.airFareTableAdapter.GetRouteData().DataSet;
           
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string routecode=comboBox1.SelectedValue.ToString();
            int rid=Convert.ToInt32(this.routeTableAdapter.ScalarQuery(routecode));
            int afID =Convert.ToInt32(textBox2.Text);
            int fare = Convert.ToInt32(textBox1.Text);
            this.airFareTableAdapter.InsertQuery(afID, rid, fare);
            // TODO: This line of code loads data into the 'libertyAirDataSet4.Route' table. You can move, or remove it, as needed.
            this.routeTableAdapter.Fill(this.libertyAirDataSet4.Route);
            // TODO: This line of code loads data into the 'libertyAirDataSet3.AirFare' table. You can move, or remove it, as needed.
            this.airFareTableAdapter.Fill(this.libertyAirDataSet3.AirFare);

            


            /*var connect = "Data Source=DESKTOP-09KPT7L;Initial Catalog=LibertyAir;Integrated Security=True";
            var sql = "SELECT RtID From Route Where RouteCode = 'Isl-Dub'";
           using (SqlConnection  conn = new SqlConnection(connect));*/
/*

           SqlCommand cmd = new SqlCommand();
        cmd.CommandType = CommandType.Text;

        cmd.Parameters.Add("USUsername", SqlDbType.VarChar).Value = recv.Itypes;
        cmd.CommandText = "SELECT ItypeNo FROM tbl_itemMaster WHERE Itype = @USUsername";

        int itemNo = Convert.ToInt32(connect.ExeNonQuery(cmd));
            */
        

           }
    }

        }
       

        
       
 
