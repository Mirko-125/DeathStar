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
            /*
            if (listaGalaksija.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite prodavnicu cija odeljenja do 5 god. zelite da vidite!");
                return;
            }

            int idProdavnice = Int32.Parse(listaGalaksija.SelectedItems[0].SubItems[0].Text);
            ProdavnicaBasic p = DTOManager.vratiProdavnicu(idProdavnice);
            OdeljenjeDo5Forma forma = new OdeljenjeDo5Forma(p);
            forma.ShowDialog();
            */
        }
    }
}
