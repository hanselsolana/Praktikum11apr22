namespace praktikum11apr
{
    partial class Form1
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
            this.cmbbox = new System.Windows.Forms.ComboBox();
            this.cmbbox2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblmanager1 = new System.Windows.Forms.Label();
            this.lblcaptain1 = new System.Windows.Forms.Label();
            this.lblmanager2 = new System.Windows.Forms.Label();
            this.lblcaptain2 = new System.Windows.Forms.Label();
            this.lblstadium = new System.Windows.Forms.Label();
            this.lblcapacity = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbbox
            // 
            this.cmbbox.FormattingEnabled = true;
            this.cmbbox.Items.AddRange(new object[] {
            "Everton"});
            this.cmbbox.Location = new System.Drawing.Point(12, 35);
            this.cmbbox.Name = "cmbbox";
            this.cmbbox.Size = new System.Drawing.Size(302, 28);
            this.cmbbox.TabIndex = 0;
            this.cmbbox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbbox2
            // 
            this.cmbbox2.FormattingEnabled = true;
            this.cmbbox2.Items.AddRange(new object[] {
            "Liverpool"});
            this.cmbbox2.Location = new System.Drawing.Point(481, 35);
            this.cmbbox2.Name = "cmbbox2";
            this.cmbbox2.Size = new System.Drawing.Size(307, 28);
            this.cmbbox2.TabIndex = 1;
            this.cmbbox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(376, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Manager: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Captain: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Captain: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Manager: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Stadium: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Capacity: ";
            // 
            // lblmanager1
            // 
            this.lblmanager1.AutoSize = true;
            this.lblmanager1.Location = new System.Drawing.Point(128, 93);
            this.lblmanager1.Name = "lblmanager1";
            this.lblmanager1.Size = new System.Drawing.Size(51, 20);
            this.lblmanager1.TabIndex = 10;
            this.lblmanager1.Text = "label2";
            // 
            // lblcaptain1
            // 
            this.lblcaptain1.AutoSize = true;
            this.lblcaptain1.Location = new System.Drawing.Point(128, 147);
            this.lblcaptain1.Name = "lblcaptain1";
            this.lblcaptain1.Size = new System.Drawing.Size(51, 20);
            this.lblcaptain1.TabIndex = 11;
            this.lblcaptain1.Text = "label2";
            // 
            // lblmanager2
            // 
            this.lblmanager2.AutoSize = true;
            this.lblmanager2.Location = new System.Drawing.Point(583, 96);
            this.lblmanager2.Name = "lblmanager2";
            this.lblmanager2.Size = new System.Drawing.Size(51, 20);
            this.lblmanager2.TabIndex = 12;
            this.lblmanager2.Text = "label2";
            // 
            // lblcaptain2
            // 
            this.lblcaptain2.AutoSize = true;
            this.lblcaptain2.Location = new System.Drawing.Point(583, 147);
            this.lblcaptain2.Name = "lblcaptain2";
            this.lblcaptain2.Size = new System.Drawing.Size(51, 20);
            this.lblcaptain2.TabIndex = 13;
            this.lblcaptain2.Text = "label2";
            // 
            // lblstadium
            // 
            this.lblstadium.AutoSize = true;
            this.lblstadium.Location = new System.Drawing.Point(375, 263);
            this.lblstadium.Name = "lblstadium";
            this.lblstadium.Size = new System.Drawing.Size(51, 20);
            this.lblstadium.TabIndex = 14;
            this.lblstadium.Text = "label2";
            // 
            // lblcapacity
            // 
            this.lblcapacity.AutoSize = true;
            this.lblcapacity.Location = new System.Drawing.Point(375, 336);
            this.lblcapacity.Name = "lblcapacity";
            this.lblcapacity.Size = new System.Drawing.Size(51, 20);
            this.lblcapacity.TabIndex = 15;
            this.lblcapacity.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblcapacity);
            this.Controls.Add(this.lblstadium);
            this.Controls.Add(this.lblcaptain2);
            this.Controls.Add(this.lblmanager2);
            this.Controls.Add(this.lblcaptain1);
            this.Controls.Add(this.lblmanager1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbbox2);
            this.Controls.Add(this.cmbbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbox;
        private System.Windows.Forms.ComboBox cmbbox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblmanager1;
        private System.Windows.Forms.Label lblcaptain1;
        private System.Windows.Forms.Label lblmanager2;
        private System.Windows.Forms.Label lblcaptain2;
        private System.Windows.Forms.Label lblstadium;
        private System.Windows.Forms.Label lblcapacity;
    }
}

