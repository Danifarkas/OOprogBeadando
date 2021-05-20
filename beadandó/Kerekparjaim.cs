using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace beadandó
{
    public partial class Kerekparjaim : Form
    {

        List<Kerekpar> aktivbringa = new List<Kerekpar>();

        List<Atalakitott> atalakitottbringak = new List<Atalakitott>();


        public Kerekparjaim()
        {
            InitializeComponent();
            Beolvas();
            BeolvasElektromos();
        }

        private void BeolvasElektromos()
        {
            if (File.Exists("elektromos.txt"))
            {



                atalakitottbringak.Clear();
                lbChangedBikes.Items.Clear();
                StreamReader r = new StreamReader("elektromos.txt");
                while (!r.EndOfStream)
                {

                    Atalakitott bicikli = new Atalakitott();
                    bicikli.Marka = r.ReadLine();

                    bicikli.Tipus = r.ReadLine();

                    bicikli.Tömeg = Convert.ToDecimal(r.ReadLine());

                    bicikli.Teljesitmeny = Convert.ToInt32(r.ReadLine());

                    bicikli.Motor = r.ReadLine();



                   atalakitottbringak.Add(bicikli);

                   lbChangedBikes.Items.Add(bicikli.Marka);

                }
                r.Close();

            }
            
        }

        private void Beolvas()
        {
            if (File.Exists("aktivkerekparok.txt"))
            {
                aktivbringa.Clear();
                lbActiveBikes.Items.Clear();
                StreamReader r = new StreamReader("aktivkerekparok.txt");
                while (!r.EndOfStream)
                {

                    Kerekpar bicikli = new Kerekpar();
                    bicikli.Marka = r.ReadLine();

                    bicikli.Tipus = r.ReadLine();

                    bicikli.Tömeg = Convert.ToDecimal(r.ReadLine());

                    aktivbringa.Add(bicikli);

                    lbActiveBikes.Items.Add(bicikli.Marka);

                }
                r.Close();
            }
            

        }

        private void btnBikeAdd_Click(object sender, EventArgs e)
        {
            label4 uj = new label4();


            if (uj.ShowDialog() == DialogResult.OK)
            {
                Beolvas();
                BeolvasElektromos();
            }
        }

        private void lbActiveBikes_SelectedIndexChanged(object sender, EventArgs e)
        {if (lbActiveBikes.SelectedIndex >=0)
            {
                tbMarkaShow.Text = aktivbringa[lbActiveBikes.SelectedIndex].Marka;
                tbTipusShow.Text = aktivbringa[lbActiveBikes.SelectedIndex].Tipus;
                tbSulyShow.Text = aktivbringa[lbActiveBikes.SelectedIndex].Tömeg.ToString();
            }
            
           



        }

        private void btnBikeRetire_Click(object sender, EventArgs e)
        {
            atalakit uj = new atalakit();
            if (uj.ShowDialog() == DialogResult.OK)
            {
                BeolvasElektromos();
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbChangedBikes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbChangedBikes.SelectedIndex >= 0)
            {
                tbEmarkaShow.Text = atalakitottbringak[lbChangedBikes.SelectedIndex].Marka;
                tbEtipusShow.Text = atalakitottbringak[lbChangedBikes.SelectedIndex].Tipus;
                tbEsulyShow.Text = atalakitottbringak[lbChangedBikes.SelectedIndex].Tömeg.ToString();
                tbTeljesitmenyShow.Text = atalakitottbringak[lbChangedBikes.SelectedIndex].Teljesitmeny.ToString();
                tbMotorMárkaShow.Text = atalakitottbringak[lbChangedBikes.SelectedIndex].Motor;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbSulyShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbTipusShow_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMarkaShow_TextChanged(object sender, EventArgs e)
        {

        }
    } 
}
