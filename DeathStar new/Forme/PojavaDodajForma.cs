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
    public partial class PojavaDodajForma : Form
    {
        bool danger = true;
        int idPlanete;
        public PojavaDodajForma()
        {
            InitializeComponent();
        }
        public PojavaDodajForma(int id)
        {
            InitializeComponent();
            idPlanete = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                danger = true;
            }
            else if(radioButton2.Checked)
            {
                danger = false;
            }
            if(DTOManager.dodajPojavu(textBox2.Text,textBox1.Text,danger,idPlanete))
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
