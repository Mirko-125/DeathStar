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
    public partial class IgracIzmeniForma : Form
    {
        private string username;
        public IgracIzmeniForma()
        {
            InitializeComponent();
        }
        public IgracIzmeniForma(string ng)
        {
            InitializeComponent();
            username = ng;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            IgracBasic igrac = new IgracBasic
            {
                ime = textBox1.Text,
                prezime = textBox2.Text,
                drzava = textBox3.Text,
                email = textBox4.Text,
                urlAvatara = textBox5.Text,
                opis = richTextBox1.Text
            };
            if(DTOManager.izmeniIgraca(igrac,username))
            {
                MessageBox.Show("Uspesno ažuriran igrač");
            }
            this.Close();
        }
    }
}
