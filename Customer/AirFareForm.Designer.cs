namespace Customer
{
    partial class AirFareForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.airFareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libertyAirDataSet3 = new Customer.LibertyAirDataSet3();
            this.airFareTableAdapter = new Customer.LibertyAirDataSet3TableAdapters.AirFareTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libertyAirDataSet4 = new Customer.LibertyAirDataSet4();
            this.btnAdd = new System.Windows.Forms.Button();
            this.routeTableAdapter = new Customer.LibertyAirDataSet4TableAdapters.RouteTableAdapter();
            this.RouteCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Airport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Destination = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.afIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.routeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airFareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RouteCode,
            this.Airport,
            this.Destination,
            this.fareDataGridViewTextBoxColumn,
            this.afIDDataGridViewTextBoxColumn,
            this.routeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.airFareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(71, 96);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(635, 194);
            this.dataGridView1.TabIndex = 0;
            // 
            // airFareBindingSource
            // 
            this.airFareBindingSource.DataMember = "AirFare";
            this.airFareBindingSource.DataSource = this.libertyAirDataSet3;
            // 
            // libertyAirDataSet3
            // 
            this.libertyAirDataSet3.DataSetName = "LibertyAirDataSet3";
            this.libertyAirDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airFareTableAdapter
            // 
            this.airFareTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "AirFare ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(229, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Route Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "AirFare (USD $)";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(517, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(112, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.routeBindingSource;
            this.comboBox1.DisplayMember = "RouteCode";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(299, 34);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "RouteCode";
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.libertyAirDataSet4;
            // 
            // libertyAirDataSet4
            // 
            this.libertyAirDataSet4.DataSetName = "LibertyAirDataSet4";
            this.libertyAirDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(642, 56);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(91, 34);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // RouteCode
            // 
            this.RouteCode.DataPropertyName = "RouteCode";
            this.RouteCode.HeaderText = "RouteCode";
            this.RouteCode.Name = "RouteCode";
            // 
            // Airport
            // 
            this.Airport.DataPropertyName = "Airport";
            this.Airport.HeaderText = "Airport";
            this.Airport.Name = "Airport";
            // 
            // Destination
            // 
            this.Destination.DataPropertyName = "Destination";
            this.Destination.HeaderText = "Destination";
            this.Destination.Name = "Destination";
            // 
            // fareDataGridViewTextBoxColumn
            // 
            this.fareDataGridViewTextBoxColumn.DataPropertyName = "Fare";
            this.fareDataGridViewTextBoxColumn.HeaderText = "Fare";
            this.fareDataGridViewTextBoxColumn.Name = "fareDataGridViewTextBoxColumn";
            // 
            // afIDDataGridViewTextBoxColumn
            // 
            this.afIDDataGridViewTextBoxColumn.DataPropertyName = "AfID";
            this.afIDDataGridViewTextBoxColumn.HeaderText = "AfID";
            this.afIDDataGridViewTextBoxColumn.Name = "afIDDataGridViewTextBoxColumn";
            // 
            // routeDataGridViewTextBoxColumn
            // 
            this.routeDataGridViewTextBoxColumn.DataPropertyName = "Route";
            this.routeDataGridViewTextBoxColumn.HeaderText = "Route";
            this.routeDataGridViewTextBoxColumn.Name = "routeDataGridViewTextBoxColumn";
            // 
            // AirFareForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 316);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AirFareForm";
            this.Text = "AirFareForm";
            this.Load += new System.EventHandler(this.AirFareForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airFareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private LibertyAirDataSet3 libertyAirDataSet3;
        private System.Windows.Forms.BindingSource airFareBindingSource;
        private LibertyAirDataSet3TableAdapters.AirFareTableAdapter airFareTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAdd;
        private LibertyAirDataSet4 libertyAirDataSet4;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private LibertyAirDataSet4TableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Airport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Destination;
        private System.Windows.Forms.DataGridViewTextBoxColumn fareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn afIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeDataGridViewTextBoxColumn;
    }
}