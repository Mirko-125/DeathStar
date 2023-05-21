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
    public partial class GradoviForma : Form
    {
        int idPlanete;
        public GradoviForma()
        {
            InitializeComponent();
        }

        public GradoviForma(int idP)
        {
            InitializeComponent();
            this.idPlanete= idP;
        }

        private void GradoviForma_Load(object sender, EventArgs e)
        {
            this.Text = "GRADOVI";
            popuniPodacima();
        }

        private void popuniPodacima()
        {
            this.GradoviView.Items.Clear();
            List<GradoviPlanetePregled> gradovi = DTOManager.vratiSveGradovePlanete(idPlanete);
            foreach (GradoviPlanetePregled grad in gradovi)
            {
                ListViewItem listViewItem = new ListViewItem(new string[] {
                        grad.grad,
                        });
                this.GradoviView.Items.Add(listViewItem);
            }
            this.GradoviView.Refresh();
        }

        private void dodajButton_Click(object sender, EventArgs e)
        {
            DTOManager.dodajGradPlaneti(this.GradText.Text, idPlanete);
            MessageBox.Show("Uspesno unet grad!");
            popuniPodacima();
        }

        private void GradText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
