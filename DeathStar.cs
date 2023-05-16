using DeathStar.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathStar.Entiteti
{
    public partial class DeathStar : Form
    {
        public DeathStar()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            IgracForma forma = new IgracForma();
            forma.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GalaksijaForma forma = new GalaksijaForma();
            forma.ShowDialog();
        }

        private void Galaksije_Click(object sender, EventArgs e)
        {
            GalaksijaForma forma = new GalaksijaForma();
            forma.ShowDialog();
        }
    }
}
