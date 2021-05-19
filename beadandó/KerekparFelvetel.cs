using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace beadandó
{
    public partial class label4 : Form
    {
        Kerekpar k;
        Atalakitott a;
        public label4()
        {
            InitializeComponent();
        }

        internal Kerekpar K { get => k; set => k = value; }
        internal Atalakitott A { get => a; set => a = value; }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            if ( tbMarka.Text != "" && cbTipus.Text != "")
            {
                if(rbNemElektromos.Checked)
                {


                    K = new Kerekpar(tbMarka.Text, cbTipus.Text, nudSuly.Value);
                    StreamWriter w = new StreamWriter("aktivkerekparok.txt", true);
                    w.WriteLine(tbMarka.Text);
                    w.WriteLine(cbTipus.Text);
                    w.WriteLine(nudSuly.Value);

                    w.Close();

                    DialogResult = DialogResult.OK;
                }

                if (rbElektromos.Checked)
                {
                    A = new Atalakitott(tbMarka.Text, cbTipus.Text, nudSuly.Value, Convert.ToInt32(nudTeljesitmeny.Value), tbMotorMarka.Text );
                    StreamWriter w = new StreamWriter("elektromos.txt", true);
                    w.WriteLine(tbMarka.Text);
                    w.WriteLine(cbTipus.Text);
                    w.WriteLine(nudSuly.Value);
                    w.WriteLine(nudTeljesitmeny.Value);
                    w.WriteLine(tbMotorMarka.Text);

                    w.Close();

                    DialogResult = DialogResult.OK;
                }

            }
            else
            {
                MessageBox.Show("Az adatok hiányosan vannak megadva");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rbNemElektromos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rbElektromos_CheckedChanged(object sender, EventArgs e)
        {
            gbEbringaAdatok.Visible = !gbEbringaAdatok.Visible;
        }
    }
}
