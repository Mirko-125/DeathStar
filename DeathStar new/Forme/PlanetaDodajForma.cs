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
    public partial class PlanetaDodajForma : Form
    {
        PlanetaBasic planeta;
        GalaksijaBasic galaksija;
        public PlanetaDodajForma()
        {
            InitializeComponent();
        }
        public PlanetaDodajForma(GalaksijaBasic g)
        {
            InitializeComponent();
            planeta= new PlanetaBasic();
            galaksija = g;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.planeta.naziv = textBox3.Text;
            this.planeta.glavniGrad = textBox2.Text;
            this.planeta.dominantnaRasa = textBox4.Text;
            this.planeta.drustvenoUredjenje = textBox5.Text;
            this.planeta.imeZvezdanogSistema = textBox6.Text;
            this.planeta.tipZvezdanogSistema = textBox7.Text;
            this.planeta.x = Int32.Parse(textBox8.Text);
            this.planeta.y = Int32.Parse(textBox9.Text);
            this.planeta.z = Int32.Parse(textBox10.Text);
            this.planeta.berilijum = Int32.Parse(textBox11.Text);
            this.planeta.trilijum = Int32.Parse(textBox12.Text);
            this.planeta.plutonijum = Int32.Parse(textBox13.Text);

            DTOManager.dodajPlanetu(planeta,galaksija.naziv);
            MessageBox.Show("Uspesno dodata galaksija");
            this.Close();
        }
    }
}
