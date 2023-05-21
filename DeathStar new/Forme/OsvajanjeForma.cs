using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathStar_new.Forme
{
    public partial class OsvajanjeForma : Form
    {
        private int idPlanete;
        public OsvajanjeForma()
        {
            InitializeComponent();
        }

        public OsvajanjeForma(int idPlanete)
        {
            InitializeComponent();
            this.idPlanete = idPlanete;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void OsvajanjeForma_Load(object sender, EventArgs e)
        {

        }

        private void Osvoji_Click(object sender, EventArgs e)
        {
            string message = DTOManager.osvojiPlanetu(idPlanete, (int)this.numericUpDown1.Value);
            if (message == "Neuspesno")
            {

            }
            else
            {
                MessageBox.Show(message);
            }
        }
    }
}
