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
    public partial class GalaksijaIzmeniForma : Form
    {
        public GalaksijaIzmeniForma()
        {
            InitializeComponent();
        }

        public GalaksijaIzmeniForma(string ng)
        {      
            InitializeComponent();
            nazivGalaksije = ng;
        }

        private string nazivGalaksije;

        private void GalaksijaIzmeniForma_Load(object sender, EventArgs e)
        {

        }

        private void azurirajBtn_Click(object sender, EventArgs e)
        {
            GalaksijaBasic galaksija = new GalaksijaBasic(nazivGalaksije, Int64.Parse(textBrojZvezda.Text), Int64.Parse(textBrojPlaneta.Text), textDominatnaRasa.Text);
            DTOManager.dodajGalaksiju(galaksija);
            MessageBox.Show("Uspesno azurirana galaksija");
            this.Close();
        }
    }
}
