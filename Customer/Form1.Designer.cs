namespace Customer
{
    partial class RoutesForm
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
            this.routeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libertyAirDataSet1 = new Customer.LibertyAirDataSet1();
            this.routeTableAdapter = new Customer.LibertyAirDataSet1TableAdapters.RouteTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.routeCodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.airportDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rtIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // routeBindingSource
            // 
            this.routeBindingSource.DataMember = "Route";
            this.routeBindingSource.DataSource = this.libertyAirDataSet1;
            // 
            // libertyAirDataSet1
            // 
            this.libertyAirDataSet1.DataSetName = "LibertyAirDataSet1";
            this.libertyAirDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // routeTableAdapter
            // 
            this.routeTableAdapter.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(367, 261);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(248, 261);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // routeCodeDataGridViewTextBoxColumn
            // 
            this.routeCodeDataGridViewTextBoxColumn.DataPropertyName = "RouteCode";
            this.routeCodeDataGridViewTextBoxColumn.HeaderText = "RouteCode";
            this.routeCodeDataGridViewTextBoxColumn.Name = "routeCodeDataGridViewTextBoxColumn";
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            // 
            // airportDataGridViewTextBoxColumn
            // 
            this.airportDataGridViewTextBoxColumn.DataPropertyName = "Airport";
            this.airportDataGridViewTextBoxColumn.HeaderText = "Airport";
            this.airportDataGridViewTextBoxColumn.Name = "airportDataGridViewTextBoxColumn";
            // 
            // rtIDDataGridViewTextBoxColumn
            // 
            this.rtIDDataGridViewTextBoxColumn.DataPropertyName = "RtID";
            this.rtIDDataGridViewTextBoxColumn.HeaderText = "RtID";
            this.rtIDDataGridViewTextBoxColumn.Name = "rtIDDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rtIDDataGridViewTextBoxColumn,
            this.airportDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.routeCodeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.routeBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(129, 44);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(440, 200);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // RoutesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 325);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "RoutesForm";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Routes";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.routeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibertyAirDataSet1 libertyAirDataSet1;
        private System.Windows.Forms.BindingSource routeBindingSource;
        private LibertyAirDataSet1TableAdapters.RouteTableAdapter routeTableAdapter;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn routeCodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn airportDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rtIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;

    }
}