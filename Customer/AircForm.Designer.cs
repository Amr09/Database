namespace Customer
{
    partial class AircForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.airCraftsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libertyAirDataSet = new Customer.LibertyAirDataSet();
            this.airCraftsTableAdapter = new Customer.LibertyAirDataSetTableAdapters.AirCraftsTableAdapter();
            this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
            this.acIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.acNumberDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mfdByDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mbtndelete = new MetroFramework.Controls.MetroButton();
            this.mbtnupdate = new MetroFramework.Controls.MetroButton();
            this.msm = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.airCraftsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).BeginInit();
            this.SuspendLayout();
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
            // metroGrid1
            // 
            this.metroGrid1.AllowUserToResizeRows = false;
            this.metroGrid1.AutoGenerateColumns = false;
            this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.metroGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.acIDDataGridViewTextBoxColumn1,
            this.acNumberDataGridViewTextBoxColumn1,
            this.capacityDataGridViewTextBoxColumn1,
            this.mfdByDataGridViewTextBoxColumn1});
            this.metroGrid1.DataSource = this.airCraftsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
            this.metroGrid1.EnableHeadersVisualStyles = false;
            this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this.metroGrid1.Location = new System.Drawing.Point(172, 28);
            this.metroGrid1.Name = "metroGrid1";
            this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid1.Size = new System.Drawing.Size(435, 273);
            this.metroGrid1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGrid1.TabIndex = 5;
            this.metroGrid1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.metroGrid1_CellContentClick);
            // 
            // acIDDataGridViewTextBoxColumn1
            // 
            this.acIDDataGridViewTextBoxColumn1.DataPropertyName = "AcID";
            this.acIDDataGridViewTextBoxColumn1.HeaderText = "AcID";
            this.acIDDataGridViewTextBoxColumn1.Name = "acIDDataGridViewTextBoxColumn1";
            // 
            // acNumberDataGridViewTextBoxColumn1
            // 
            this.acNumberDataGridViewTextBoxColumn1.DataPropertyName = "AcNumber";
            this.acNumberDataGridViewTextBoxColumn1.HeaderText = "AcNumber";
            this.acNumberDataGridViewTextBoxColumn1.Name = "acNumberDataGridViewTextBoxColumn1";
            // 
            // capacityDataGridViewTextBoxColumn1
            // 
            this.capacityDataGridViewTextBoxColumn1.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn1.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn1.Name = "capacityDataGridViewTextBoxColumn1";
            // 
            // mfdByDataGridViewTextBoxColumn1
            // 
            this.mfdByDataGridViewTextBoxColumn1.DataPropertyName = "MfdBy";
            this.mfdByDataGridViewTextBoxColumn1.HeaderText = "MfdBy";
            this.mfdByDataGridViewTextBoxColumn1.Name = "mfdByDataGridViewTextBoxColumn1";
            // 
            // mbtndelete
            // 
            this.mbtndelete.Location = new System.Drawing.Point(23, 233);
            this.mbtndelete.Name = "mbtndelete";
            this.mbtndelete.Size = new System.Drawing.Size(75, 23);
            this.mbtndelete.TabIndex = 6;
            this.mbtndelete.Text = "Delete";
            this.mbtndelete.UseSelectable = true;
            this.mbtndelete.Click += new System.EventHandler(this.mbtndelete_Click);
            // 
            // mbtnupdate
            // 
            this.mbtnupdate.Location = new System.Drawing.Point(23, 169);
            this.mbtnupdate.Name = "mbtnupdate";
            this.mbtnupdate.Size = new System.Drawing.Size(75, 23);
            this.mbtnupdate.TabIndex = 7;
            this.mbtnupdate.Text = "Update";
            this.mbtnupdate.UseSelectable = true;
            this.mbtnupdate.Click += new System.EventHandler(this.mbtnupdate_Click);
            // 
            // msm
            // 
            this.msm.Owner = null;
            this.msm.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // AircForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 406);
            this.Controls.Add(this.mbtnupdate);
            this.Controls.Add(this.mbtndelete);
            this.Controls.Add(this.metroGrid1);
            this.Name = "AircForm";
            this.Text = "Air Crafts ";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Load += new System.EventHandler(this.AircForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.airCraftsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libertyAirDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private LibertyAirDataSet libertyAirDataSet;
        private System.Windows.Forms.BindingSource airCraftsBindingSource;
        private LibertyAirDataSetTableAdapters.AirCraftsTableAdapter airCraftsTableAdapter;
        private MetroFramework.Controls.MetroGrid metroGrid1;
        private System.Windows.Forms.DataGridViewTextBoxColumn acIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn acNumberDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mfdByDataGridViewTextBoxColumn1;
        private MetroFramework.Controls.MetroButton mbtndelete;
        private MetroFramework.Controls.MetroButton mbtnupdate;
        private MetroFramework.Components.MetroStyleManager msm;
    }
}