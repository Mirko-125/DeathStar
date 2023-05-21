using FluentNHibernate.Conventions.Inspections;
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
    public partial class KonstrukcijaStaniceForma : Form
    {
        int idPlanete;
        public KonstrukcijaStaniceForma()
        {
            InitializeComponent();
        }

        public KonstrukcijaStaniceForma(int idPlanete)
        {
            InitializeComponent();
            this.idPlanete = idPlanete;
        }

        private void Konstruisi_Click(object sender, EventArgs e)
        {
            string naziv = this.NazivText.Text;
            int udaljenost = Int32.Parse(this.UdaljenostText.Text);
            int brojLjudi = Int32.Parse(this.BrojLjudiText.Text);
            int velicina = Int32.Parse(this.velicinaTextBox.Text);
            if (vojnaRadio.Checked)
            {
                VojnaStanicaBasic stanica = new VojnaStanicaBasic
                {
                    naziv = naziv,
                    udaljenost = udaljenost,
                    brojLjudi = brojLjudi,
                    velicina = velicina
                };
                if (DTOManager.dodajStanicu(stanica, this.idPlanete))
                {
                    MessageBox.Show("Uspesno dodata stanica");
                }
            }
            else if (civilnaRadio.Checked)
            {
                CivilnaStanicaBasic stanica = new CivilnaStanicaBasic
                {
                    naziv = naziv,
                    udaljenost = udaljenost,
                    brojLjudi = brojLjudi,
                    velicina = velicina,
                    svrha = this.SvrhaComboBox.SelectedItem.ToString()
                };
                if (DTOManager.dodajStanicu(stanica, this.idPlanete))
                {
                    MessageBox.Show("Uspesno dodata stanica");
                }
            }

        }
    }
}
