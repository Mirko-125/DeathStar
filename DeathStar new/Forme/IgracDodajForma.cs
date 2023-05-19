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
    public partial class IgracDodajForma : Form
    {
        public IgracDodajForma()
        {
            InitializeComponent();
            igrac = new IgracBasic();
        }
        IgracBasic igrac;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dodaj_Click(object sender, EventArgs e)
        {
            this.igrac.username = username.Text;
            this.igrac.ime = ime.Text;
            this.igrac.prezime = prezime.Text;
            if(radioButton1.Checked)
            {
                this.igrac.pol = "zensko";
            }
            else if(radioButton2.Checked)
            {
                this.igrac.pol = "musko";
            }
            this.igrac.drzava = drzava.Text;
            this.igrac.datumRodjenja = dateTimePicker1.Value;
            this.igrac.datumOtvaranjaNaloga = dateTimePicker2.Value;
            this.igrac.email = email.Text;
            this.igrac.urlAvatara = urlavatar.Text;
            this.igrac.opis = richTextBox1.Text;
            DTOManager.dodajIgraca(this.igrac);
            MessageBox.Show("Uspesno dodat igrac");
            this.Close();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
