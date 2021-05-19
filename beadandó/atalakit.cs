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
    public partial class atalakit : Form
    {


        List<Kerekpar> AtalakitandoLista = new List<Kerekpar>();


        Atalakitott A;
        public atalakit()
        {
            InitializeComponent();
            Atalakitando();
        }

        private void Atalakitando()
        {
            if (File.Exists("aktivkerekparok.txt"))
            {
                AtalakitandoLista.Clear();
                lbAtalakitando.Items.Clear();
                StreamReader r = new StreamReader("aktivkerekparok.txt");
                while (!r.EndOfStream)
                {

                    Kerekpar bicikli = new Kerekpar();
                    bicikli.Marka = r.ReadLine();

                    bicikli.Tipus = r.ReadLine();

                    bicikli.Tömeg = Convert.ToDecimal(r.ReadLine());

                    AtalakitandoLista.Add(bicikli);

                    lbAtalakitando.Items.Add(bicikli.Marka);

                }
                r.Close();
            }
        }

        private void btnHozzaad_Click(object sender, EventArgs e)
        {
            A = new Atalakitott(tbMarkaShow.Text, tbTipusShow.Text, Convert.ToDecimal(tbSulyShow.Text), Convert.ToInt32(nudTeljesitmenyAdd.Value), tbMotorMarkaAdd.Text) ;
            StreamWriter w = new StreamWriter("elektromos.txt", true);
            w.WriteLine(tbMarkaShow.Text);
            w.WriteLine(tbTipusShow.Text);
            w.WriteLine(tbSulyShow.Text);
            w.WriteLine(nudTeljesitmenyAdd.Value);
            w.WriteLine(tbMotorMarkaAdd.Text);

            w.Close();

            DialogResult = DialogResult.OK;





        }

        private void lbAtalakitando_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbAtalakitando.SelectedIndex > 0)
            {
                tbMarkaShow.Text = AtalakitandoLista[lbAtalakitando.SelectedIndex].Marka;
                tbTipusShow.Text = AtalakitandoLista[lbAtalakitando.SelectedIndex].Tipus;
                tbSulyShow.Text = AtalakitandoLista[lbAtalakitando.SelectedIndex].Tömeg.ToString();
            }
            
        }
    }
}
