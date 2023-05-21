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
    public partial class SpisakOruzjaForma : Form
    {
        int idStanice;
        public SpisakOruzjaForma()
        {
            InitializeComponent();
        }

        public SpisakOruzjaForma(int idS)
        {
            InitializeComponent();
            idStanice = idS;
        }

        private void SpisakOruzjaForma_Load(object sender, EventArgs e)
        {
            this.Text = "SPISAK ORUZJA";
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            this.OruzjaView.Items.Clear();
            List<SpisakOruzjaPregled> oruzja = DTOManager.vratiSvaOruzjaStanice(idStanice);
            foreach (SpisakOruzjaPregled oruzje in oruzja)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                        oruzje.oruzje,
                        });
                this.OruzjaView.Items.Add(listViewItem);
            }
            this.OruzjaView.Refresh();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DTOManager.dodajOruzjeStanici(this.OruzjeText.Text, idStanice);
            MessageBox.Show("Uspesno uneto oruzje!");
            popuniPodacima();
        }
    }
}
