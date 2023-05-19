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
    public partial class GalaksijaDodajForma : Form
    {
        public GalaksijaDodajForma()
        {
            InitializeComponent();
            galaksija = new GalaksijaBasic();
        }

        GalaksijaBasic galaksija;

        private void GalaksijaDodajForma_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.galaksija.naziv = textNaziv.Text;
            this.galaksija.procenjenBrojZvezda = Int64.Parse(textBrojZvezda.Text);
            this.galaksija.procenjenBrojPlaneta = Int64.Parse(textBrojPlaneta.Text);
            this.galaksija.dominantnaRasa = textDominatnaRasa.Text;
            DTOManager.dodajGalaksiju(this.galaksija);
            MessageBox.Show("Uspesno dodata galaksija");
            this.Close();
        }
    }
}
