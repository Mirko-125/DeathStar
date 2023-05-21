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
    public partial class SvemirskeStaniceForma : Form
    {
        int idPlanete;
        public SvemirskeStaniceForma()
        {
            InitializeComponent();
        }

        public SvemirskeStaniceForma(int idPlanete)
        {
            InitializeComponent();
            this.idPlanete = idPlanete;
        }

        private void SvemirskeStaniceForma_Load(object sender, EventArgs e)
        {
            this.Text = "STANICE";
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            this.listaCivilnihStanica.Items.Clear();
            this.listaVojnihStanica.Items.Clear();

            List<SvemirskaStanicaPregled> vojneStanice = DTOManager.vratiSveStanicePlanete(idPlanete, "vojna");
            List<SvemirskaStanicaPregled> civilneStanice = DTOManager.vratiSveStanicePlanete(idPlanete, "civiline");

            foreach (VojnaStanicaPregled s in vojneStanice)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    s.id.ToString(),
                    s.naziv,
                    s.udaljenost.ToString(),
                    s.brojLjudi.ToString(),
                    s.velicina.ToString()
                });
                this.listaVojnihStanica.Items.Add(listViewItem);
            }

            foreach (CivilnaSvemirskaStanicaPregled s in civilneStanice)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    s.id.ToString(),
                    s.naziv,
                    s.udaljenost.ToString(),
                    s.brojLjudi.ToString(),
                    s.velicina.ToString(),
                    s.svrha
                });
                this.listaCivilnihStanica.Items.Add(listViewItem);
            }
            this.listaCivilnihStanica.Refresh();
            this.listaVojnihStanica.Refresh();
        }

        private void PrikazOruzja_Click(object sender, EventArgs e)
        {
            if (this.listaVojnihStanica.SelectedItems.Count == 0)
            {
                MessageBox.Show("MOLIM IZABERITE VOJNU STANICU");
                return;
            }
            int id = Int32.Parse(listaVojnihStanica.SelectedItems[0].SubItems[0].Text);
            SpisakOruzjaForma spisakOruzjaForma = new SpisakOruzjaForma(id);
            spisakOruzjaForma.ShowDialog();
        }

        private void dodajStanicu_Click(object sender, EventArgs e)
        {
            KonstrukcijaStaniceForma forma = new KonstrukcijaStaniceForma(idPlanete);
            forma.ShowDialog();
            this.popuniPodacima();
        }
    }
}
