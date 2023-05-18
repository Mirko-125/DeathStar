using DeathStar.Entiteti;
using DeathStar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace DeathStar_new
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void findGalaxy_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Galaksija galaksija = s.Load<Galaksija>("Mlecni putV");
                MessageBox.Show(galaksija.ProcenjenBrojPlaneta.ToString());
                Kvadrant kvadrant = s.Load<Kvadrant>(1);
                MessageBox.Show(kvadrant.ProcenjeniPrecnik.ToString());

                /*Kvadrant kvadrant = s.Load<Kvadrant>(1);

                MessageBox.Show(kvadrant.ProcenjeniPrecnik.ToString());*/

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
        }
    }
}
