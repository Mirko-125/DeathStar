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
    }
}
