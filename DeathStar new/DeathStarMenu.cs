using DeathStar_new.Forme;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathStar_new
{
    public partial class DeathStarMenu : Form
    {
        public DeathStarMenu()
        {
            InitializeComponent();
        }

        private void Igraci_Click(object sender, EventArgs e)
        {
            IgracForma forma = new IgracForma();
            forma.ShowDialog();
        }

        private void Galaksije_Click(object sender, EventArgs e)
        {
            GakaksijaForma forma = new GakaksijaForma();
            forma.ShowDialog();
        }

        private void Savezi_Click(object sender, EventArgs e)
        {
            SavezForma forma = new SavezForma();
            forma.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // obrisi na kraju
            Form1 forma = new Form1();
            forma.ShowDialog();
        }
    }
}
