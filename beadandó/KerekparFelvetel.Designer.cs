
namespace beadandó
{
    partial class label4
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
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudSuly = new System.Windows.Forms.NumericUpDown();
            this.cbTipus = new System.Windows.Forms.ComboBox();
            this.tbMarka = new System.Windows.Forms.TextBox();
            this.rbElektromos = new System.Windows.Forms.RadioButton();
            this.rbNemElektromos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.tbMotorMarka = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbEbringaAdatok = new System.Windows.Forms.GroupBox();
            this.nudTeljesitmeny = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).BeginInit();
            this.gbEbringaAdatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeljesitmeny)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(168, 288);
            this.btnHozzaad.Margin = new System.Windows.Forms.Padding(2);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(224, 67);
            this.btnHozzaad.TabIndex = 0;
            this.btnHozzaad.Text = "Kerékpár Hozzáadása";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kerékpár Márkája";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kerékpár Típusa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 33);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kerékpár súlya";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // nudSuly
            // 
            this.nudSuly.Location = new System.Drawing.Point(292, 80);
            this.nudSuly.Margin = new System.Windows.Forms.Padding(2);
            this.nudSuly.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.nudSuly.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudSuly.Name = "nudSuly";
            this.nudSuly.Size = new System.Drawing.Size(90, 20);
            this.nudSuly.TabIndex = 4;
            this.nudSuly.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // cbTipus
            // 
            this.cbTipus.FormattingEnabled = true;
            this.cbTipus.Items.AddRange(new object[] {
            "Országúti",
            "Mountainbike",
            "Gravel",
            "Cross"});
            this.cbTipus.Location = new System.Drawing.Point(159, 78);
            this.cbTipus.Margin = new System.Windows.Forms.Padding(2);
            this.cbTipus.Name = "cbTipus";
            this.cbTipus.Size = new System.Drawing.Size(92, 21);
            this.cbTipus.TabIndex = 5;
            // 
            // tbMarka
            // 
            this.tbMarka.Location = new System.Drawing.Point(45, 78);
            this.tbMarka.Margin = new System.Windows.Forms.Padding(2);
            this.tbMarka.Name = "tbMarka";
            this.tbMarka.Size = new System.Drawing.Size(92, 20);
            this.tbMarka.TabIndex = 6;
            // 
            // rbElektromos
            // 
            this.rbElektromos.AutoSize = true;
            this.rbElektromos.Location = new System.Drawing.Point(425, 65);
            this.rbElektromos.Name = "rbElektromos";
            this.rbElektromos.Size = new System.Drawing.Size(77, 17);
            this.rbElektromos.TabIndex = 7;
            this.rbElektromos.Text = "Elektromos";
            this.rbElektromos.UseVisualStyleBackColor = true;
            this.rbElektromos.CheckedChanged += new System.EventHandler(this.rbElektromos_CheckedChanged);
            // 
            // rbNemElektromos
            // 
            this.rbNemElektromos.AutoSize = true;
            this.rbNemElektromos.Checked = true;
            this.rbNemElektromos.Location = new System.Drawing.Point(425, 105);
            this.rbNemElektromos.Name = "rbNemElektromos";
            this.rbNemElektromos.Size = new System.Drawing.Size(101, 17);
            this.rbNemElektromos.TabIndex = 8;
            this.rbNemElektromos.TabStop = true;
            this.rbNemElektromos.Text = "Nem elektromos";
            this.rbNemElektromos.UseVisualStyleBackColor = true;
            this.rbNemElektromos.CheckedChanged += new System.EventHandler(this.rbNemElektromos_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Motor Teljesítménye (watt)";
            // 
            // tbMotorMarka
            // 
            this.tbMotorMarka.Location = new System.Drawing.Point(210, 62);
            this.tbMotorMarka.Margin = new System.Windows.Forms.Padding(2);
            this.tbMotorMarka.Name = "tbMotorMarka";
            this.tbMotorMarka.Size = new System.Drawing.Size(92, 20);
            this.tbMotorMarka.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 28);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Motor Márkája";
            // 
            // gbEbringaAdatok
            // 
            this.gbEbringaAdatok.Controls.Add(this.nudTeljesitmeny);
            this.gbEbringaAdatok.Controls.Add(this.tbMotorMarka);
            this.gbEbringaAdatok.Controls.Add(this.label5);
            this.gbEbringaAdatok.Controls.Add(this.label6);
            this.gbEbringaAdatok.Location = new System.Drawing.Point(90, 137);
            this.gbEbringaAdatok.Name = "gbEbringaAdatok";
            this.gbEbringaAdatok.Size = new System.Drawing.Size(343, 101);
            this.gbEbringaAdatok.TabIndex = 13;
            this.gbEbringaAdatok.TabStop = false;
            this.gbEbringaAdatok.Text = "Elektromos Kerékpár Adatok";
            this.gbEbringaAdatok.Visible = false;
            // 
            // nudTeljesitmeny
            // 
            this.nudTeljesitmeny.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTeljesitmeny.Location = new System.Drawing.Point(24, 62);
            this.nudTeljesitmeny.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.nudTeljesitmeny.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTeljesitmeny.Name = "nudTeljesitmeny";
            this.nudTeljesitmeny.Size = new System.Drawing.Size(120, 20);
            this.nudTeljesitmeny.TabIndex = 13;
            this.nudTeljesitmeny.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gbEbringaAdatok);
            this.Controls.Add(this.rbNemElektromos);
            this.Controls.Add(this.rbElektromos);
            this.Controls.Add(this.tbMarka);
            this.Controls.Add(this.cbTipus);
            this.Controls.Add(this.nudSuly);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHozzaad);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "label4";
            this.Text = "KerekparFelvetel";
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).EndInit();
            this.gbEbringaAdatok.ResumeLayout(false);
            this.gbEbringaAdatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeljesitmeny)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudSuly;
        private System.Windows.Forms.ComboBox cbTipus;
        private System.Windows.Forms.TextBox tbMarka;
        private System.Windows.Forms.RadioButton rbElektromos;
        private System.Windows.Forms.RadioButton rbNemElektromos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbMotorMarka;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox gbEbringaAdatok;
        private System.Windows.Forms.NumericUpDown nudTeljesitmeny;
    }
}