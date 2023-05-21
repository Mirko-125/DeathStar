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
    public partial class PlaneteForma : Form
    {
        GalaksijaBasic galaksija;
        public PlaneteForma()
        {
            InitializeComponent();
        }

        public PlaneteForma(GalaksijaBasic G)
        {
            InitializeComponent();
            galaksija = G;
        }

        private void Planete_Load(object sender, EventArgs e)
        {
            this.Text = "GALAKSIJA " + galaksija.naziv.ToUpper();
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            this.listaPlaneta.Items.Clear();
            List<PlanetaPregled> planete = DTOManager.vratiSvePlaneteGalaksije(galaksija.naziv);
            foreach (PlanetaPregled p in planete)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                    p.idPlanete.ToString(),
                    p.naziv,
                    p.glavniGrad,
                    p.brojStanovnika.ToString(),
                    p.dominantnaRasa,
                    p.drustvenoUredjenje,
                    p.imeZvezdanogSistema,
                    p.tipZvezdanogSistema,
                    p.x.ToString(),
                    p.y.ToString(),
                    p.z.ToString(),
                    p.berilijum,
                    p.trilijum,
                    p.plutonijum,
                    p.datumKolonizacije.ToShortDateString()
                });
                this.listaPlaneta.Items.Add(listViewItem);

            }
            this.listaPlaneta.Refresh();
        }

        private void prikaziBrodove_Click(object sender, EventArgs e)
        {
            if (listaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite planetu cije brodove zelite da vidite!");
                return;
            }
            int id = Int32.Parse(listaPlaneta.SelectedItems[0].SubItems[0].Text);
            string naziv = listaPlaneta.SelectedItems[0].SubItems[1].Text;
            BrodoviForma brodoviForma = new BrodoviForma(naziv, id);
            brodoviForma.ShowDialog();
        }

        private void OsvojiPlanetu_Click(object sender, EventArgs e)
        {
            if (listaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite planetu cije brodove zelite da vidite!");
                return;
            }
            int id = Int32.Parse(listaPlaneta.SelectedItems[0].SubItems[0].Text);
            OsvajanjeForma osvajanjeForma = new OsvajanjeForma(id);
            osvajanjeForma.ShowDialog();
        }

        private void Gradovi_Click(object sender, EventArgs e)
        {
            if (listaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite planetu cije brodove zelite da vidite!");
                return;
            }
            int id = Int32.Parse(listaPlaneta.SelectedItems[0].SubItems[0].Text);
            GradoviForma gradoviForma = new GradoviForma(id);
            gradoviForma.ShowDialog();
        }

        private void SvemirskeStaniceButton_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(listaPlaneta.SelectedItems[0].SubItems[0].Text);
            SvemirskeStaniceForma forma = new SvemirskeStaniceForma(id);
            forma.ShowDialog();
        }

        private void dodajPlanetuButton_Click(object sender, EventArgs e)
        {
            PlanetaDodajForma forma = new PlanetaDodajForma(galaksija);
            forma.ShowDialog();
            this.popuniPodacima();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listaPlaneta.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite sa prirodnim satelitima etc");
                return;
            }
            int id = Int32.Parse(listaPlaneta.SelectedItems[0].SubItems[0].Text);
            PrirodniSatelitiIPojaveForma forma = new PrirodniSatelitiIPojaveForma(id);
            forma.ShowDialog();
        }
    }
}
