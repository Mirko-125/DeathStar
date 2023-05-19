using DeathStar_new.Entiteti;
using DeathStar_new;
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

/*dodaj brod(biraj posadu i planetu),
prikazi borbene brodove,
osvoji planetu (create osvajanje)
sagradi svemirsku stanicu (napravi jednu pa drugu)
dodeli planetu(add planet to user)
unisti planetu(remove planet)
prikazi prirodne satelite i pojave (prvo jedno pa drugo)
dodaj grad(biraj planetu)
select kvadranti(po galaksiji)
prikazi igrace
dodaj igraca
obrisi igraca
izmeni igraca
prikazi saveze
dodaj savez,
pridruzi savez
prikazi galaksije
prikazi kvadrante*/

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void showPlayers_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Savez savez = s.Load<Savez>("Alijansa slobodnih planeta");
                MessageBox.Show(savez.DatumFormiranja.ToString());
                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
        }

        private void dodajOsvajanje_Click(object sender, EventArgs e)
        {
        /* public virtual DateTime DatumOsvajanja { get; set; }
        public virtual Posada PosadaOsvaja { get; set; }
        public virtual Igrac PrethodniVlasnik { get; set; }
        public virtual Planeta PlanetaOsvojena { get; set; }*/
        ISession s = DataLayer.GetSession();
            s.Close();
        }

        private void brodoviPosade_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
    
                Posada posada = s.Load<Posada>(3);
                MessageBox.Show(posada.Id.ToString());
                IList<Brod> brodovi = s.QueryOver<Brod>()
                    .JoinQueryOver(x => x.PosadaKojaPoseduje)
                    .Where(x => x.Id == posada.Id)
                    .List();
                foreach (Brod brod in brodovi)
                {
                     MessageBox.Show(brod.JedinstveniBroj.ToString());
                }
            }
            catch(Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
        }

        private void osvojiPlanetu_Click(object sender, EventArgs e)
        {
            //idp9, posada3, MocniMacevnik// 
            try
            {
                ISession s = DataLayer.GetSession();
                Planeta planeta = s.Load<Planeta>(12);
                Posada posada = s.Load<Posada>(5);
                Igrac igrac = posada.Igrac;
                Osvajanje osvajanje = new Osvajanje();
                osvajanje.PlanetaOsvojena = planeta;
                osvajanje.PosadaOsvaja = posada;
                osvajanje.PrethodniVlasnik = igrac;
                planeta.PosadaOsvajaca = posada;
                posada.Osvajanja.Add(osvajanje);
                s.Save(osvajanje);
                s.Save(planeta);
                s.Save(posada);
                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

        }

        private void showSatelitiAndStations_Click(object sender, EventArgs e)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Planeta planeta = s.Load<Planeta>(8);
                SvemirskaStanica stanica = s.Load<VojnaStanica>("Zvezda smrti");
                MessageBox.Show(stanica.Udaljenost.ToString());
                IList<PrirodniSatelit> sateliti = s.QueryOver<PrirodniSatelit>()
                        .JoinQueryOver(x => x.KruziOkoPlanete)
                        .Where(x => x.Id == planeta.Id)
                        .List();
                foreach (PrirodniSatelit satelit in sateliti)
                {
                    MessageBox.Show(satelit.Udaljenost.ToString());
                }
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

        }
    }
}
