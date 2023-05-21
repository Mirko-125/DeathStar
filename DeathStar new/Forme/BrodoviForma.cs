using DeathStar_new.Entiteti;
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
    public partial class BrodoviForma : Form
    {
        public BrodoviForma()
        {
            InitializeComponent();
        }

        public BrodoviForma(string planetaNaziv, int idPlanete)
        {
            InitializeComponent();
            this.planetaNaziv = planetaNaziv;
            this.idPlanete = idPlanete;
        }

        string planetaNaziv;
        int idPlanete;

        private void BrodoviForma_Load(object sender, EventArgs e)
        {
            this.Text = "PLANETA " + planetaNaziv.ToUpper();
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            this.listaBorbenihBrodova.Items.Clear();
            this.listaTransportnihBrodova.Items.Clear();

            List<BrodPregled> borbeniBrodovi = DTOManager.vratiSveBrodovePlanete(idPlanete, "borbeni");
            List<BrodPregled> transportniBrodovi = DTOManager.vratiSveBrodovePlanete(idPlanete, "transportni");

            foreach (BorbeniBrodPregled brod in borbeniBrodovi)
            {
                string flag = brod.fotonskoTorpedo ? "da" : "ne";
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    brod.jedinstveniBroj.ToString(),
                    brod.naziv,
                    brod.maxWarpBrzina.ToString(),
                    brod.brojLaserskihTopova.ToString(),
                    brod.tip,
                    flag
                });
                this.listaBorbenihBrodova.Items.Add(listViewItem);
            }

            foreach (TransportniBrodPregled brod in transportniBrodovi)
            {
                string zastitnaOtplata = brod.zastitnaOtplata ? "da" : "ne";
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    brod.jedinstveniBroj.ToString(),
                    brod.naziv,
                    brod.maxWarpBrzina.ToString(),
                    brod.nosivost.ToString(),
                    zastitnaOtplata,
                    });
                this.listaTransportnihBrodova.Items.Add(listViewItem);
            }
            this.listaBorbenihBrodova.Refresh();
            this.listaTransportnihBrodova.Refresh();
        }

        private void listaBorbenihBrodova_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void konstruisiBrod_Click(object sender, EventArgs e)
        {
            KonstrukcijaBrodaForma forma = new KonstrukcijaBrodaForma(idPlanete);
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
