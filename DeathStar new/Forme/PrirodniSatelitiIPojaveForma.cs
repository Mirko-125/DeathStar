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
    public partial class PrirodniSatelitiIPojaveForma : Form
    {
        int idplanete;
        public PrirodniSatelitiIPojaveForma()
        {
            InitializeComponent();
        }
        public PrirodniSatelitiIPojaveForma(int idp)
        {
            InitializeComponent();
            this.idplanete = idp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mora da se prosledi id planete!! promeniti!
            PrirodniSatelitDodajForma forma = new PrirodniSatelitDodajForma(idplanete);
            forma.ShowDialog();
        }

        private void listaMeseca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void popuniTabeluPrirodnihSatelita()
        {
            listaMeseca.Items.Clear();
            List<PrirodniSatelitPregled> prirodniSateliti = DTOManager.vratiSvePrirodneSatelite(idplanete);
            foreach (PrirodniSatelitPregled p in prirodniSateliti)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    p.naziv,
                    p.udaljenost.ToString(),
                    p.precnik.ToString(),
                    p.naseobine.ToString()
                });
                listaMeseca.Items.Add(listViewItem);
            }
            listaMeseca.Refresh();
        }

        private void IgracForma_Load(object sender, EventArgs e)
        {
            popuniTabeluPrirodnihSatelita();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
