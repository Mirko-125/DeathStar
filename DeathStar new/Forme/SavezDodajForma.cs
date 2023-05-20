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
    public partial class SavezDodajForma : Form
    {
        public SavezDodajForma()
        {
            InitializeComponent();
            savez = new SavezBasic();
        }
        SavezBasic savez;

        private void formiraj_Click(object sender, EventArgs e)
        {
            this.savez.naziv = nazivSaveza.Text;
            this.savez.datumFormiranja = dateTimePicker1.Value;
            DTOManager.dodajSavez(savez);
            MessageBox.Show("Nov savez je u galaksiji"); 
            this.Close();
        }
    }
}
