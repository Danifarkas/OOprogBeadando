
namespace beadandó
{
    partial class atalakit
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
            this.gbEbringaAdatok = new System.Windows.Forms.GroupBox();
            this.nudTeljesitmenyAdd = new System.Windows.Forms.NumericUpDown();
            this.tbMotorMarkaAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHozzaad = new System.Windows.Forms.Button();
            this.lbAtalakitando = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSulyShow = new System.Windows.Forms.TextBox();
            this.tbTipusShow = new System.Windows.Forms.TextBox();
            this.tbMarkaShow = new System.Windows.Forms.TextBox();
            this.gbEbringaAdatok.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeljesitmenyAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // gbEbringaAdatok
            // 
            this.gbEbringaAdatok.Controls.Add(this.nudTeljesitmenyAdd);
            this.gbEbringaAdatok.Controls.Add(this.tbMotorMarkaAdd);
            this.gbEbringaAdatok.Controls.Add(this.label5);
            this.gbEbringaAdatok.Controls.Add(this.label6);
            this.gbEbringaAdatok.Location = new System.Drawing.Point(335, 24);
            this.gbEbringaAdatok.Name = "gbEbringaAdatok";
            this.gbEbringaAdatok.Size = new System.Drawing.Size(343, 101);
            this.gbEbringaAdatok.TabIndex = 15;
            this.gbEbringaAdatok.TabStop = false;
            this.gbEbringaAdatok.Text = "Kerékpár Elektromossá Tétele";
            // 
            // nudTeljesitmenyAdd
            // 
            this.nudTeljesitmenyAdd.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudTeljesitmenyAdd.Location = new System.Drawing.Point(24, 62);
            this.nudTeljesitmenyAdd.Maximum = new decimal(new int[] {
            750,
            0,
            0,
            0});
            this.nudTeljesitmenyAdd.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudTeljesitmenyAdd.Name = "nudTeljesitmenyAdd";
            this.nudTeljesitmenyAdd.Size = new System.Drawing.Size(120, 20);
            this.nudTeljesitmenyAdd.TabIndex = 13;
            this.nudTeljesitmenyAdd.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // tbMotorMarkaAdd
            // 
            this.tbMotorMarkaAdd.Location = new System.Drawing.Point(210, 62);
            this.tbMotorMarkaAdd.Margin = new System.Windows.Forms.Padding(2);
            this.tbMotorMarkaAdd.Name = "tbMotorMarkaAdd";
            this.tbMotorMarkaAdd.Size = new System.Drawing.Size(92, 20);
            this.tbMotorMarkaAdd.TabIndex = 12;
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
            // btnHozzaad
            // 
            this.btnHozzaad.Location = new System.Drawing.Point(403, 182);
            this.btnHozzaad.Margin = new System.Windows.Forms.Padding(2);
            this.btnHozzaad.Name = "btnHozzaad";
            this.btnHozzaad.Size = new System.Drawing.Size(224, 67);
            this.btnHozzaad.TabIndex = 14;
            this.btnHozzaad.Text = "Kerékpár Hozzáadása";
            this.btnHozzaad.UseVisualStyleBackColor = true;
            this.btnHozzaad.Click += new System.EventHandler(this.btnHozzaad_Click);
            // 
            // lbAtalakitando
            // 
            this.lbAtalakitando.FormattingEnabled = true;
            this.lbAtalakitando.Location = new System.Drawing.Point(80, 30);
            this.lbAtalakitando.Name = "lbAtalakitando";
            this.lbAtalakitando.Size = new System.Drawing.Size(135, 173);
            this.lbAtalakitando.TabIndex = 16;
            this.lbAtalakitando.SelectedIndexChanged += new System.EventHandler(this.lbAtalakitando_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 160);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Súly";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(234, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Típus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Márka";
            // 
            // tbSulyShow
            // 
            this.tbSulyShow.Location = new System.Drawing.Point(236, 175);
            this.tbSulyShow.Margin = new System.Windows.Forms.Padding(2);
            this.tbSulyShow.Name = "tbSulyShow";
            this.tbSulyShow.Size = new System.Drawing.Size(76, 20);
            this.tbSulyShow.TabIndex = 19;
            // 
            // tbTipusShow
            // 
            this.tbTipusShow.Location = new System.Drawing.Point(236, 128);
            this.tbTipusShow.Margin = new System.Windows.Forms.Padding(2);
            this.tbTipusShow.Name = "tbTipusShow";
            this.tbTipusShow.Size = new System.Drawing.Size(76, 20);
            this.tbTipusShow.TabIndex = 18;
            // 
            // tbMarkaShow
            // 
            this.tbMarkaShow.Location = new System.Drawing.Point(236, 63);
            this.tbMarkaShow.Margin = new System.Windows.Forms.Padding(2);
            this.tbMarkaShow.Name = "tbMarkaShow";
            this.tbMarkaShow.Size = new System.Drawing.Size(76, 20);
            this.tbMarkaShow.TabIndex = 17;
            // 
            // atalakit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 275);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbSulyShow);
            this.Controls.Add(this.tbTipusShow);
            this.Controls.Add(this.tbMarkaShow);
            this.Controls.Add(this.lbAtalakitando);
            this.Controls.Add(this.gbEbringaAdatok);
            this.Controls.Add(this.btnHozzaad);
            this.Name = "atalakit";
            this.Text = "atalakit";
            this.gbEbringaAdatok.ResumeLayout(false);
            this.gbEbringaAdatok.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudTeljesitmenyAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbEbringaAdatok;
        private System.Windows.Forms.NumericUpDown nudTeljesitmenyAdd;
        private System.Windows.Forms.TextBox tbMotorMarkaAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHozzaad;
        private System.Windows.Forms.ListBox lbAtalakitando;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSulyShow;
        private System.Windows.Forms.TextBox tbTipusShow;
        private System.Windows.Forms.TextBox tbMarkaShow;
    }
}