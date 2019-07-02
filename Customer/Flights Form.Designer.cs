namespace Customer
{
    partial class Flights_Form
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.flightScheduleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libertyAirDataSet5 = new Customer.LibertyAirDataSet5();
            this.flight_ScheduleTableAdapter = new Customer.LibertyAirDataSet5TableAdapters.Flight_ScheduleTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.airCraftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libertyAirDataSet = new Customer.LibertyAirDataSet();
            this.airCraftsTableAdapter = new Customer.LibertyAirDataSetTableAdapters.AirCraftsTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fillByToolStrip = new System.Windows.Forms.ToolStrip();
            this.fillByToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.flIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AcNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.libertyAirDataSet6 = new Customer.LibertyAirDataSet6();
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.routeTableAdapter = new Customer.LibertyAirDataSet6TableAdapters.RouteTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.fillByToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Flight_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Arrival";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 215);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Air Craft";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 255);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Route";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(67, 49);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(73, 20);
            this.textBox1.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(67, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(84, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(67, 126);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker3.Location = new System.Drawing.Point(67, 171);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker3.TabIndex = 9;
            // 
            // flightScheduleBindingSource
            // 
            this.flightScheduleBindingSource.DataMember = "Flight_Schedule";
            this.flightScheduleBindingSource.DataSource = this.libertyAirDataSet5;
            // 
            // libertyAirDataSet5
            // 
            this.libertyAirDataSet5.DataSetName = "LibertyAirDataSet5";
            this.libertyAirDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // flight_ScheduleTableAdapter
            // 
            this.flight_ScheduleTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.flightScheduleBindingSource, "AcNumber", true));
            this.comboBox1.DataSource = this.airCraftsBindingSource;
            this.comboBox1.DisplayMember = "AcNumber";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(67, 215);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(108, 21);
            this.comboBox1.TabIndex = 10;
            this.comboBox1.ValueMember = "AcID";
            // 
            // airCraftsBindingSource
            // 
            this.airCraftsBindingSource.DataMember = "AirCrafts";
            this.airCraftsBindingSource.DataSource = this.libertyAirDataSet;
            // 
            // libertyAirDataSet
            // 
            this.libertyAirDataSet.DataSetName = "LibertyAirDataSet";
            this.libertyAirDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // airCraftsTableAdapter
            // 
            this.airCraftsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.flIDDataGridViewTextBoxColumn,
            this.departureDataGridViewTextBoxColumn,
            this.arrivalDataGridViewTextBoxColumn,
            this.airportDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.AcNumber,
            this.RouteCode});
            this.dataGridView1.DataSource = this.flightScheduleBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(216, 107);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(742, 219);
            this.dataGridView1.TabIndex = 12;
            // 
            // fillByToolStrip
            // 
            this.fillByToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fillByToolStripButton});
            this.fillByToolStrip.Location = new System.Drawing.Point(0, 0);
            this.fillByToolStrip.Name = "fillByToolStrip";
            this.fillByToolStrip.Size = new System.Drawing.Size(982, 25);
            this.fillByToolStrip.TabIndex = 13;
            this.fillByToolStrip.Text = "fillByToolStrip";
            // 
            // fillByToolStripButton
            // 
            this.fillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByToolStripButton.Name = "fillByToolStripButton";
            this.fillByToolStripButton.Size = new System.Drawing.Size(39, 22);
            this.fillByToolStripButton.Text = "FillBy";
            this.fillByToolStripButton.Click += new System.EventHandler(this.fillByToolStripButton_Click);
            // 
            // flIDDataGridViewTextBoxColumn
            // 
            this.flIDDataGridViewTextBoxColumn.DataPropertyName = "FlID";
            this.flIDDataGridViewTextBoxColumn.HeaderText = "FlID";
            this.flIDDataGridViewTextBoxColumn.Name = "flIDDataGridViewTextBoxColumn";
            // 
            // departureDataGridViewTextBoxColumn
            // 
            this.departureDataGridViewTextBoxColumn.DataPropertyName = "Departure";
            this.departureDataGridViewTextBoxColumn.HeaderText = "Departure";
            this.departureDataGridViewTextBoxColumn.Name = "departureDataGridViewTextBoxColumn";
            // 
            // arrivalDataGridViewTextBoxColumn
            // 
            this.arrivalDataGridViewTextBoxColumn.DataPropertyName = "Arrival";
            this.arrivalDataGridViewTextBoxColumn.HeaderText = "Arrival";
            this.arrivalDataGridViewTextBoxColumn.Name = "arrivalDataGridViewTextBoxColumn";
            // 
            // airportDataGridViewTextBoxColumn
            // 
            this.airportDataGridViewTextBoxColumn.DataPropertyName = "Airport";
            this.airportDataGridViewTextBoxColumn.HeaderText = "Airport";
            this.airportDataGridViewTextBoxColumn.Name = "airportDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // AcNumber
            // 
            this.AcNumber.DataPropertyName = "AcNumber";
            this.AcNumber.HeaderText = "AcNumber";
            this.AcNumber.Name = "AcNumber";
            // 
            // RouteCode
            // 
            this.RouteCode.DataPropertyName = "RouteCode";
            this.RouteCode.HeaderText = "RouteCode";
            this.RouteCode.Name = "RouteCode";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.routeBindingSource;
            this.comboBox2.DisplayMember = "RouteCode";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(67, 252);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(108, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.ValueMember = "RouteCode";
            // 
            // libertyAirDataSet6
            // 
            this.libertyAirDataSet6.DataSetName = "LibertyAirDataSet6";
            this.libertyAirDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.libertyAirDataSet6;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Flights_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 429);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fillByToolStrip);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Flights_Form";
            this.Text = "Flights_Form";
            this.Load += new System.EventHandler(this.Flights_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightScheduleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airCraftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.fillByToolStrip.ResumeLayout(false);
            this.fillByToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private LibertyAirDataSet5 libertyAirDataSet5;
        private System.Windows.Forms.BindingSource flightScheduleBindingSource;
        private LibertyAirDataSet5TableAdapters.Flight_ScheduleTableAdapter flight_ScheduleTableAdapter;
        private System.Windows.Forms.ComboBox comboBox1;
        private LibertyAirDataSet libertyAirDataSet;
        private System.Windows.Forms.BindingSource airCraftsBindingSource;
        private LibertyAirDataSetTableAdapters.AirCraftsTableAdapter airCraftsTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip fillByToolStrip;
        private System.Windows.Forms.ToolStripButton fillByToolStripButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn flIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departureDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn arrivalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AcNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private LibertyAirDataSet6 libertyAirDataSet6;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private LibertyAirDataSet6TableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.Button button2;
    }
}