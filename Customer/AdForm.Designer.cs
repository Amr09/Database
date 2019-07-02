namespace Customer
{
    partial class AdForm
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
            this.btnAirC = new System.Windows.Forms.Button();
            this.btnrou = new System.Windows.Forms.Button();
            this.btnArf = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAirC
            // 
            this.btnAirC.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnAirC.BackgroundImage = global::Customer.Resource1.image;
            this.btnAirC.Location = new System.Drawing.Point(57, 110);
            this.btnAirC.Name = "btnAirC";
            this.btnAirC.Size = new System.Drawing.Size(92, 42);
            this.btnAirC.TabIndex = 0;
            this.btnAirC.Text = "AirCrafts";
            this.btnAirC.UseVisualStyleBackColor = false;
            this.btnAirC.Click += new System.EventHandler(this.btnAirC_Click);
            // 
            // btnrou
            // 
            this.btnrou.BackgroundImage = global::Customer.Resource1.image;
            this.btnrou.Location = new System.Drawing.Point(255, 110);
            this.btnrou.Name = "btnrou";
            this.btnrou.Size = new System.Drawing.Size(80, 42);
            this.btnrou.TabIndex = 1;
            this.btnrou.Text = "Route";
            this.btnrou.UseVisualStyleBackColor = true;
            this.btnrou.Click += new System.EventHandler(this.btnrou_Click);
            // 
            // btnArf
            // 
            this.btnArf.BackgroundImage = global::Customer.Resource1.image;
            this.btnArf.Location = new System.Drawing.Point(454, 110);
            this.btnArf.Name = "btnArf";
            this.btnArf.Size = new System.Drawing.Size(81, 42);
            this.btnArf.TabIndex = 2;
            this.btnArf.Text = "AirFare";
            this.btnArf.UseVisualStyleBackColor = true;
            this.btnArf.Click += new System.EventHandler(this.btnArf_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Customer.Resource1.image;
            this.button4.Location = new System.Drawing.Point(57, 210);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(92, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Flight Schedule";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(255, 210);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 34);
            this.button5.TabIndex = 4;
            this.button5.Text = "Branches";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(454, 210);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // AdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = global::Customer.Resource1.london_night;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(623, 433);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnArf);
            this.Controls.Add(this.btnrou);
            this.Controls.Add(this.btnAirC);
            this.Name = "AdForm";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdForm_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAirC;
        private System.Windows.Forms.Button btnrou;
        private System.Windows.Forms.Button btnArf;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
    }
}