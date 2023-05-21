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
    public partial class IgracForma : Form
    {
        public IgracForma()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void popuniTabeluIgraca()
        {
            listaIgraca.Items.Clear();
            List<IgracPregled> igraci = DTOManager.vratiSveIgrace();
            foreach(IgracPregled i in igraci)
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    i.username,
                    i.ime,
                    i.prezime,
                    i.pol,
                    i.drzava,
                    i.datumRodjenja.ToShortDateString(),
                    i.datumOtvaranjaNaloga.ToShortDateString(),
                    i.email,
                    i.urlAvatara,
                    i.opis
                }) ;
                listaIgraca.Items.Add(listViewItem);
            }
            listaIgraca.Refresh();
        }

        private void IgracForma_Load(object sender, EventArgs e)
        {
            popuniTabeluIgraca();
        }

        private void Dodaj_Igraca_Click(object sender, EventArgs e)
        {
            IgracDodajForma formaDodaj = new IgracDodajForma();
            formaDodaj.ShowDialog();
            this.popuniTabeluIgraca();
        }

        private void Obrisi_Igraca_Click(object sender, EventArgs e)
        {
            if (listaIgraca.SelectedItems.Count == 0)
            {
                MessageBox.Show("Izaberite galaksiju koju zelite da obrisete!");
                return;
            }

            string usernameX = listaIgraca.SelectedItems[0].SubItems[0].Text;

            if (DTOManager.confirmMessage("izabranog igraca") == DialogResult.OK)
            {
                DTOManager.obrisiIgraca(usernameX);
                MessageBox.Show(usernameX + " is no more");
                this.popuniTabeluIgraca();
            }
            else
            {
                MessageBox.Show("Greska prilikom brisanja " + usernameX);
            }
        }

        private void Izmeni_Igraca_Click(object sender, EventArgs e)
        {
            IgracIzmeniForma formaIzmeni = new IgracIzmeniForma(listaIgraca.SelectedItems[0].SubItems[0].Text);
            formaIzmeni.ShowDialog();
            this.popuniTabeluIgraca();
        }
    }
}