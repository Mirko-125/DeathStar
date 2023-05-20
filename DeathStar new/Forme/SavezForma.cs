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
    public partial class SavezForma : Form
    {
        public void popuniTabeluSaveza()
        {
            listaSaveza.Items.Clear();
            List<SavezPregled> savezi = DTOManager.vratiSveSaveze();
            foreach(SavezPregled u in savezi)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    u.naziv,
                    u.datumFormiranja.ToShortDateString()
                });
                listaSaveza.Items.Add(listViewItem);
            }
            listaSaveza.Refresh();
        }
        public SavezForma()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dodaj_Savez_Click(object sender, EventArgs e)
        {
            SavezDodajForma formaIzmeni = new SavezDodajForma();
            formaIzmeni.ShowDialog();
            this.popuniTabeluSaveza();
        }

        private void Pridruzi_Savez_Click(object sender, EventArgs e)
        {
            SavezPridruziForma savezPridruzi = new SavezPridruziForma();
            savezPridruzi.ShowDialog();
            this.popuniTabeluSaveza();
        }
    }
}
