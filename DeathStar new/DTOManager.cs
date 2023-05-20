using DeathStar_new;
using DeathStar_new.Entiteti;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeathStar_new
{
    internal class DTOManager
    {
        #region Galaksija
        public static List<GalaksijaPregled> vratiSveGalaksije()
        {
            List<GalaksijaPregled> galaksije = new List<GalaksijaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Galaksija> sveGalaksije = from o in s.Query<Galaksija>()
                                                      select o;

                foreach (Galaksija g in sveGalaksije)
                {
                    galaksije.Add(new GalaksijaPregled(g.Naziv, g.ProcenjenBrojZvezda, g.ProcenjenBrojPlaneta, g.DominantnaRasa));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return galaksije;
        }

        public static void dodajGalaksiju(GalaksijaBasic g)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Galaksija o = new Galaksija();

                o.Naziv = g.naziv;
                o.ProcenjenBrojPlaneta = g.procenjenBrojPlaneta;
                o.ProcenjenBrojZvezda = g.procenjenBrojZvezda;
                o.DominantnaRasa = g.dominantnaRasa;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
        }

        public static void obrisiGalaksiju(string naziv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Galaksija o = s.Load<Galaksija>(naziv);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
            
        }

        public static GalaksijaBasic vratiGalaksiju(string naziv)
        {
            GalaksijaBasic galaksijaBasic = new GalaksijaBasic();
            try
            {
                ISession s = DataLayer.GetSession();

                Galaksija galaksija = s.Load<Galaksija>(naziv);
                galaksijaBasic = new GalaksijaBasic(galaksija.Naziv,
                galaksija.ProcenjenBrojZvezda,
                galaksija.ProcenjenBrojPlaneta,
                galaksija.DominantnaRasa);
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return galaksijaBasic; 
        }
        #endregion

        #region Planete
        public static List<PlanetaPregled> vratiSvePlaneteGalaksije(string galaksijaNaziv)
        {
            List<PlanetaPregled> planete = new List<PlanetaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Galaksija galaksija = s.Load<Galaksija>(galaksijaNaziv);

                IEnumerable<Planeta> svePlanete = from p in s.Query<Planeta>()
                                                                      where p.UGalaksiji == galaksija
                                                                      select p;

                foreach (Planeta planeta in svePlanete)
                {
                    planete.Add(new PlanetaPregled
                    {
                        idPlanete = planeta.Id,
                        naziv = planeta.Naziv,
                        glavniGrad = planeta.GlavniGrad,
                        brojStanovnika = planeta.BrojStanovnika,
                        dominantnaRasa = planeta.DominantnaRasa,
                        drustvenoUredjenje = planeta.DrustvenoUredjenje,
                        imeZvezdanogSistema = planeta.ImeZvezdanogSistema,
                        tipZvezdanogSistema = planeta.TipZvezdanogSistema,
                        x = planeta.X,
                        y = planeta.Y,
                        z = planeta.Z,
                        berilijum = planeta.Berilijum.ToString(),
                        trilijum = planeta.Trilijum.ToString(),
                        plutonijum = planeta.Plutonijum.ToString(),
                        datumKolonizacije = planeta.DatumKolonizacije
                    });
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return planete;
        }
        #endregion
        #region Igrac
        public static List<IgracPregled> vratiSveIgrace()
        {
            List<IgracPregled> igraci = new List<IgracPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Igrac> sviIgraci = from o in s.Query<Igrac>()
                                       select o;

                foreach (Igrac i in sviIgraci)
                {
                    igraci.Add(new IgracPregled(i.Username, i.Ime, i.Prezime, i.Pol, i.Drzava,i.DatumOtvaranjaNaloga,i.DatumRodjenja,i.Email,i.URLAvatara,i.Opis));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return igraci;
        }

        public static void dodajIgraca(IgracBasic i, int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Igrac o = new Igrac();
                Planeta p = s.Load<Planeta>(id);

                o.Ime = i.ime;
                o.Prezime = i.prezime;
                o.Pol = i.pol;
                o.Email = i.email;
                o.Opis = i.opis;
                o.URLAvatara = i.urlAvatara;
                o.DatumRodjenja = i.datumRodjenja;
                o.DatumOtvaranjaNaloga = i.datumOtvaranjaNaloga;
                o.Drzava = i.drzava;
                o.MaticnaPlaneta = p;
                o.Username = i.username;
                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
        }

        public static void obrisiIgraca(string naziv)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Igrac o = s.Load<Igrac>(naziv);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
        }
        /*public static IgracBasic vratiIgraca(string naziv)
        {
            IgracBasic igracBasic = new IgracBasic();
            try
            {
                ISession s = DataLayer.GetSession();
                
                o.Ime = i.ime;
                o.Prezime = i.prezime;
                o.Pol = i.pol;
                o.Email = i.email;
                o.Opis = i.opis;
                o.URLAvatara = i.urlAvatara;
                o.DatumRodjenja = i.datumRodjenja;
                o.DatumOtvaranjaNaloga = i.datumOtvaranjaNaloga;
                o.Drzava = i.drzava;
                o.MaticnaPlaneta = p;
                o.Username = i.username;
                s.SaveOrUpdate(o);   
                
                Igrac igrac = s.Load<Igrac>(naziv);
                igracBasic = new IgracBasic(igrac.Username, igrac.Ime, igrac.Prezime, igrac.Pol, igrac.Drzava, igrac.DatumOtvaranjaNaloga, igrac.DatumRodjenja, igrac.Email, igrac.URLAvatara, igrac.Opis, igrac.DeoPosade, igrac.MaticnaPlaneta, igrac.DeoSaveza);
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return igracBasic;
        }
        */
        #endregion

        public static DialogResult confirmMessage(string izabranoTelo)
        {
            string poruka = "Da li zelite da obrisete " + izabranoTelo;
            string title = "Pitanje";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(poruka, title, buttons);
            return result;
        }
    }
}
