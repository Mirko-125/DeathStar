using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathStar_new.Forme
{
    public partial class KvadrantiForma : Form
    {
        GalaksijaBasic galaksija;
        public KvadrantiForma()
        {
            
        }

        public KvadrantiForma(GalaksijaBasic g)
        {
            InitializeComponent();
            galaksija = g;
        }

        private void KvadrantiForma_Load(object sender, EventArgs e)
        {
            this.Text = "GALAKSIJA " + galaksija.naziv.ToUpper();
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            this.listaKvadranta.Items.Clear();
            List<KvadrantPregled> kvadranti = DTOManager.vratiSveKvadranteGalaksije(galaksija.naziv);
            foreach (KvadrantPregled kvadrant in kvadranti)
            {
                  ListViewItem listViewItem = new ListViewItem(new string[] {
                        kvadrant.redniBroj.ToString(),
                        kvadrant.procenjeniPrecnik.ToString()
                        });
                 this.listaKvadranta.Items.Add(listViewItem);
            }
            this.listaKvadranta.Refresh();
        }

        private void dodajKvadrant_Click(object sender, EventArgs e)
        {
            if (DTOManager.dodajKvadrant(Int32.Parse(textPrecnik.Text), galaksija.naziv))
            {
                MessageBox.Show("Uspesno dodat kvadrant!");
                this.popuniPodacima();
            }
        }

        private void izmeniKvadrant_Click(object sender, EventArgs e)
        {
            if (listaKvadranta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kvadrant koji zelite da izmenite!");
                return;
            }

            if (DTOManager.izmeniKvadrant(Int32.Parse(listaKvadranta.SelectedItems[0].SubItems[0].Text), Int32.Parse(textPrecnik.Text)))
            {
                MessageBox.Show("Uspesno izmenjen kvadrant!");
                this.popuniPodacima();
            }

        }

        private void obrisiKvadrant_Click(object sender, EventArgs e)
        {
            if (listaKvadranta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite kvadrant koji zelite da obrisete!");
                return;
            }

            int id = Int32.Parse(listaKvadranta.SelectedItems[0].SubItems[0].Text);

            if (DTOManager.confirmMessage("izabran kvadrant?") == DialogResult.OK)
            {
                DTOManager.obrisiKvadrant(id);
                MessageBox.Show("Brisanje kvadranta je uspesno obavljeno!");
                this.popuniPodacima();
            }
            else
            {

            }
        }

        private void listaKvadranta_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
