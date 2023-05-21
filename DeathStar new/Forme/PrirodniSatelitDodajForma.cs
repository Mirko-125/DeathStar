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
    public partial class PrirodniSatelitDodajForma : Form
    {
        int idPlanete;
        public PrirodniSatelitDodajForma()
        {
            InitializeComponent();
           
        }
        public PrirodniSatelitDodajForma(int id)
        {
            InitializeComponent();
            idPlanete = id;
        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool naseobine=false;
            if (radioButton1.Checked)
            {
                naseobine = true;
            }
            else if (radioButton2.Checked)
            {
                naseobine = false;
            }
            if (DTOManager.dodajPrirodniSatelit(textBox1.Text, Int32.Parse(textBox2.Text), Int32.Parse(textBox3.Text), naseobine, idPlanete))
            {
                MessageBox.Show("Upešno dodavanje");
            }
            else
            {
                MessageBox.Show("Neuspežno dodavanje");
            }
        }
    }
}
