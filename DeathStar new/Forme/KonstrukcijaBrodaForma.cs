using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace DeathStar_new.Forme
{
    public partial class KonstrukcijaBrodaForma : Form
    {
        int idPlanete;
        public KonstrukcijaBrodaForma()
        {
            InitializeComponent();
        }

        public KonstrukcijaBrodaForma(int idPlanete)
        {
            InitializeComponent();
            this.idPlanete = idPlanete;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void borbeniRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (borbeniRadio.Checked)
            {
                BorbeniBrodGroup.Enabled = true;
            }
            else
            {
                BorbeniBrodGroup.Enabled = false;
            }
        }

        private void BorbeniBrodGroup_Enter(object sender, EventArgs e)
        {
           
        }

        private void transportniRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (transportniRadio.Checked)
            {
                TransportniBrodGroup.Enabled = true;
            }
            else
            {
                TransportniBrodGroup.Enabled= false;
            }
        }

        private void Konstruisi_Click(object sender, EventArgs e)
        {
           
            if (borbeniRadio.Checked)
            {
                BorbeniBrodBasic brod = new BorbeniBrodBasic
                {
                    naziv = this.NazivText.Text,
                    maxWarpBrzina = Int32.Parse(this.MaxWarpBrzinaText.Text),
                    brojLaserskihTopova = Int32.Parse(this.BrojLaserskihTopovaText.Text),
                    tip = this.TipComboBox.SelectedItem.ToString(),
                    fotonskoTorpedo = this.FotonskoTorpedoCheckBox.Checked
                };
                if (DTOManager.dodajBrod(brod, Int32.Parse(this.PosadaIdText.Text), this.idPlanete))
                {
                    MessageBox.Show("Uspesno dodat borbeni brod");
                }
            }

            else if (transportniRadio.Checked)
            {
                TransportniBrodBasic brod = new TransportniBrodBasic
                {
                    naziv = this.NazivText.Text,
                    maxWarpBrzina = Int32.Parse(this.MaxWarpBrzinaText.Text),
                    nosivost = Int32.Parse(this.NosivostText.Text),
                    zastitnaOtplata = ZASTITNAOTPLATA.Checked
                };
                if (DTOManager.dodajBrod(brod, Int32.Parse(this.PosadaIdText.Text), this.idPlanete))
                {
                    if (ZASTITNAOTPLATA.Checked)
                        MessageBox.Show("Uspesno dodat transportni brod koji ima zastitnu otplatu!");
                    else
                        MessageBox.Show("Uspesno dodat transportni brod :(");
                }
            }

            else
            {
                MessageBox.Show("MOLIM SELEKTUJTE BORBENI ILI TRANSPORTNI!!");
                return;
            }
             
            
            this.Close();
        }
    }
}
