using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathStar_new.Forme
{
    public partial class GakaksijaForma : Form
    {
        public GakaksijaForma()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (listaGalaksija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite galaksiju cije planete zelite da vidite.");
                return;
            }

            string nazivGalaksije = listaGalaksija.SelectedItems[0].SubItems[0].Text;
            GalaksijaBasic g = DTOManager.vratiGalaksiju(nazivGalaksije);
            PlaneteForma planeteForma = new PlaneteForma(g);
            planeteForma.ShowDialog();
            
        }

        private void GakaksijaForma_Load(object sender, EventArgs e)
        {
            popuniTabeluGalaksijama();
        }

        public void popuniTabeluGalaksijama()
        {
            listaGalaksija.Items.Clear();
            List<GalaksijaPregled> galaksije = DTOManager.vratiSveGalaksije();

            foreach(GalaksijaPregled g in galaksije)
            {
                ListViewItem listViewItem= new ListViewItem(new string[] {
                    g.naziv,
                    g.procenjenBrojZvezda.ToString(),
                    g.procenjenBrojPlaneta.ToString(),
                    g.dominantnaRasa
                    });
                listaGalaksija.Items.Add(listViewItem);
            }

            listaGalaksija.Refresh();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            GalaksijaDodajForma formaDodaj = new GalaksijaDodajForma();
            formaDodaj.ShowDialog();
            this.popuniTabeluGalaksijama();
        }

        private void obrisiGalaksiju_Click(object sender, EventArgs e)
        {
            if (listaGalaksija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite galaksiju koju zelite da obrisete!");
                return;
            }

            string nazivGalaksije = listaGalaksija.SelectedItems[0].SubItems[0].Text;
            string poruka = "Da li zelite da obrisete izabranu galaksiju?";
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);

            if (result == DialogResult.OK)
            {
                DTOManager.obrisiGalaksiju(nazivGalaksije);
                MessageBox.Show("Brisanje galaksije je uspesno obavljeno!");
                this.popuniTabeluGalaksijama();
            }
            else
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listaGalaksija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite galaksiju cije kvadrante zelite da vidite.");
                return;
            }

            string nazivGalaksije = listaGalaksija.SelectedItems[0].SubItems[0].Text;
            GalaksijaBasic g = DTOManager.vratiGalaksiju(nazivGalaksije);
            KvadrantiForma kvadrantiForma = new KvadrantiForma(g);
            kvadrantiForma.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listaGalaksija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite galaksiju koju zelite da izmenite.");
                return;
            }

            GalaksijaIzmeniForma formaIzmeni = new GalaksijaIzmeniForma(listaGalaksija.SelectedItems[0].SubItems[0].Text);
            formaIzmeni.ShowDialog();
            this.popuniTabeluGalaksijama();
        }

        private void listaGalaksija_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
