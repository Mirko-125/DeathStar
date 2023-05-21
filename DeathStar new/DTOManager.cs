using DeathStar_new;
using DeathStar_new.Entiteti;
using DeathStar_new.Forme;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
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
        public static void dodajPlanetu(PlanetaBasic p, string nazivGalaksije)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Galaksija gal = s.Load<Galaksija>(nazivGalaksije);
                Planeta o = new Planeta();

                o.Naziv = p.naziv;
                o.GlavniGrad = p.glavniGrad;
                o.DominantnaRasa = p.dominantnaRasa;
                o.DrustvenoUredjenje = p.drustvenoUredjenje;
                o.ImeZvezdanogSistema = p.imeZvezdanogSistema;
                o.TipZvezdanogSistema = p.tipZvezdanogSistema;
                o.X = p.x;
                o.Y = p.y;
                o.Z = p.z;
                o.Berilijum = p.berilijum;
                o.Trilijum = p.trilijum;
                o.Plutonijum = p.plutonijum;
                o.UGalaksiji = gal;

                s.SaveOrUpdate(o);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
        }

        public static List<SpisakOruzjaPregled> vratiSvaOruzjaStanice(int idS)
        {
            List<SpisakOruzjaPregled> spisakOruzja= new List<SpisakOruzjaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                VojnaStanica stanica = s.Load<VojnaStanica>(idS);

                IEnumerable<SpisakOruzja> spisakOruzjaSve = from p in s.Query<SpisakOruzja>()
                                                             where p.Stanica == stanica
                                                             select p;
                foreach (SpisakOruzja g in spisakOruzjaSve)
                {
                    spisakOruzja.Add(new SpisakOruzjaPregled { oruzje = g.Oruzje});
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
            return spisakOruzja;
        }

        public static void dodajOruzjeStanici(string naziv, int idStanice)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                VojnaStanica stanica = s.Load<VojnaStanica>(idStanice);
                SpisakOruzja oruzje = new SpisakOruzja();
                oruzje.Stanica = stanica;
                oruzje.Oruzje = naziv;

                s.Save(oruzje);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
        }
        public static void dodajGradPlaneti(string naziv, int idPlanete)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Planeta planeta = s.Load<Planeta>(idPlanete);
                GradoviPlanete grad = new GradoviPlanete();
                grad.GradPlaneta = planeta;
                grad.Grad = naziv;

                s.Save(grad);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }


        }
        public static List<GradoviPlanetePregled> vratiSveGradovePlanete(int idPlanete)
        {
            List<GradoviPlanetePregled> gradovi = new List<GradoviPlanetePregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Planeta planeta = s.Load<Planeta>(idPlanete);

                IEnumerable<GradoviPlanete> gradoviPlanete = from p in s.Query<GradoviPlanete>()
                                                  where p.GradPlaneta == planeta
                                                  select p;
                foreach (GradoviPlanete g in gradoviPlanete)
                {
                    gradovi.Add(new GradoviPlanetePregled { grad = g.Grad });
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
            return gradovi;
        }
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

        /*public static PlanetaBasic vratiPlanetu(int id)
        {
            try
            {
                PlanetaBasic planetaBasic= new PlanetaBasic();
                try
                {
                    ISession s = DataLayer.GetSession();

                    Planeta planeta = s.Load<Planeta>(id);
                    planetaBasic = new PlanetaBasic(planeta.Id)
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
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
            return planeta;
        }*/

        public static string osvojiPlanetu(int idPlanete, int PosadaId)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Planeta planeta = s.Load<Planeta>(idPlanete);
                Posada posada = s.Load<Posada>(PosadaId);
                Igrac prosliIgrac = planeta.IgracKojiJePoseduje;
                if (prosliIgrac == null)
                {
                    return "Izaberite planetu sa nekim igracem (U TRENUTKU INSERTOVANJA, TO SU PLANETA SA ID (NAZIVG = ANDROMEDAS)9, 10, 11";
                }

                Osvajanje osvajanje = new Osvajanje();
                osvajanje.PosadaOsvaja = posada;
                osvajanje.PlanetaOsvojena= planeta;
                osvajanje.PrethodniVlasnik = prosliIgrac;

                s.Save(osvajanje);
                s.Flush();
                s.Close();

            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
                return "Neuspesno";
            }
            return "Uspesno";
        }
        #endregion
        #region Pojava
        public static bool dodajPojavu(string naziv, string tip, bool opasnost, int idP)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Planeta planeta = s.Load<Planeta>(idP);
                Pojava pojava = new Pojava();
                pojava.Naziv = naziv;
                pojava.TipPojave = tip;
                pojava.IzazivaLiOpasnost = opasnost;
                pojava.PlanetaDeo = planeta;

                s.Save(pojava);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
                return false;
            }

            return true;

        }
        public static List<PojavaPregled> vratiSvePojavePlanete(int idP)
        {
            List<PojavaPregled> pojave = new List<PojavaPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Planeta planeta = s.Load<Planeta>(idP);

                IEnumerable<Pojava> svePojave = from p in s.Query<Pojava>()
                                                where p.PlanetaDeo == planeta
                                                select p;

                foreach (Pojava pojava in svePojave)
                {
                    pojave.Add(new PojavaPregled
                    {
                        naziv = pojava.Naziv,
                        tipPojave = pojava.TipPojave,                   
                        izazivaLiOpasnost = pojava.IzazivaLiOpasnost
                    });
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return pojave;
        }
        #endregion
        #region Kvadranti
        public static List<KvadrantPregled>vratiSveKvadranteGalaksije(string nazivG)
        {
            List<KvadrantPregled> kvadranti = new List<KvadrantPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Galaksija galaksija = s.Load<Galaksija>(nazivG);

                IEnumerable<Kvadrant> sviKvadranti = from k in s.Query<Kvadrant>()
                                                     where k.DeoGalaksije == galaksija
                                                     select k;

                foreach (Kvadrant kvadrant in sviKvadranti)
                {
                    kvadranti.Add(new KvadrantPregled
                    {
                        redniBroj = kvadrant.RedniBroj,
                        procenjeniPrecnik = kvadrant.ProcenjeniPrecnik
                    });
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return kvadranti;
        }

        public static void obrisiKvadrant(int id)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Kvadrant o = s.Load<Kvadrant>(id);

                s.Delete(o);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

        }

        public static bool dodajKvadrant(int precnik, string nazivG)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Galaksija galaksija = s.Load<Galaksija>(nazivG);
                Kvadrant kvadrant = new Kvadrant();
                kvadrant.ProcenjeniPrecnik = precnik;
                kvadrant.DeoGalaksije = galaksija;

                s.Save(kvadrant);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
                return false;
            }

            return true;

        }

        public static bool izmeniKvadrant(int id, int precnik)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                Kvadrant kvadrant = s.Load<Kvadrant>(id);
                kvadrant.ProcenjeniPrecnik = precnik;

                s.Update(kvadrant);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
                return false;
            }

            return true;
        }
        #endregion
        #region Stanice
        public static bool dodajStanicu(VojnaStanicaBasic br, int idPlanete)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                VojnaStanica stanica = new VojnaStanica();               
                Planeta planeta = s.Load<Planeta>(idPlanete);
                stanica.Naziv = br.naziv;
                stanica.Udaljenost = br.udaljenost;
                stanica.BrojLjudi= br.brojLjudi;
                stanica.Velicina = br.velicina;
                stanica.DeoPlanete = planeta;
                s.SaveOrUpdate(stanica);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
                return false;
            }
            return true;
        }
        public static bool dodajStanicu(CivilnaStanicaBasic br, int idPlanete)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                CivilnaStanica stanica = new CivilnaStanica();
                Planeta planeta = s.Load<Planeta>(idPlanete);
                stanica.Naziv = br.naziv;
                stanica.Udaljenost = br.udaljenost;
                stanica.BrojLjudi = br.brojLjudi;
                stanica.Velicina = br.velicina;
                stanica.DeoPlanete = planeta;
                stanica.Svrha = br.svrha;

                s.SaveOrUpdate(stanica);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
                return false;
            }
            return true;

        }
        public static List<SvemirskaStanicaPregled> vratiSveStanicePlanete(int idPlanete, string tip)
        {
            List<SvemirskaStanicaPregled> stanice = new List<SvemirskaStanicaPregled>();
            try
            {
                ISession session = DataLayer.GetSession();
                Planeta planeta = session.Load<Planeta>(idPlanete);
                IEnumerable<SvemirskaStanica> sveStanice;
                if (tip == "vojna")
                {
                    sveStanice = from b in session.Query<VojnaStanica>()
                                 where b.DeoPlanete == planeta
                                 select b;
                    foreach (VojnaStanica s in sveStanice)
                    {
                        stanice.Add(new VojnaStanicaPregled(
                            s.Id,
                            s.Naziv,
                            s.Udaljenost,
                            s.BrojLjudi,
                            s.Velicina
                        ));
                    }
                }
                else
                {
                    sveStanice = from b in session.Query<CivilnaStanica>()
                                 where b.DeoPlanete == planeta
                                 select b;
                    foreach (CivilnaStanica s in sveStanice)
                    {
                        stanice.Add(new CivilnaSvemirskaStanicaPregled(
                            s.Id,
                            s.Naziv,
                            s.Udaljenost,
                            s.Svrha,
                            s.BrojLjudi,
                            s.Velicina
                            ));
                    }
                }
                session.Close();

            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return stanice;

        }
        #endregion
        #region PrirodniSatelit
        public static bool dodajPrirodniSatelit(string naziv, int udaljenost, int precnik, bool naseobine, int idP)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Planeta planeta = s.Load<Planeta>(idP);
                PrirodniSatelit prirodniSatelit = new PrirodniSatelit();
                prirodniSatelit.Naziv = naziv;
                prirodniSatelit.Udaljenost = udaljenost;
                prirodniSatelit.Precnik = precnik;
                prirodniSatelit.Naseobine = naseobine;
                prirodniSatelit.KruziOkoPlanete = planeta;

                s.Save(prirodniSatelit);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
                return false;
            }

            return true;
        }
        public static List<PrirodniSatelitPregled> vratiSvePrirodneSatelite(int idP)
        {
            List<PrirodniSatelitPregled> prirodniSateliti = new List<PrirodniSatelitPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                Planeta planeta = s.Load<Planeta>(idP);

                IEnumerable<PrirodniSatelit> sviPS = from ps in s.Query<PrirodniSatelit>()
                                                     where ps.KruziOkoPlanete == planeta
                                                     select ps;

                foreach (PrirodniSatelit prirodniSatelit in sviPS)
                {
                    prirodniSateliti.Add(new PrirodniSatelitPregled
                    {
                        naziv = prirodniSatelit.Naziv,
                        udaljenost = prirodniSatelit.Udaljenost,
                        precnik = prirodniSatelit.Precnik,
                        naseobine = prirodniSatelit.Naseobine
                    });
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return prirodniSateliti;
        }
        #endregion
        #region Brodovi
        public static List<BrodPregled> vratiSveBrodovePlanete(int idPlanete, string tip)
        {
            List<BrodPregled> brodovi= new List<BrodPregled>();
            try
            {
                ISession s = DataLayer.GetSession();
                Planeta planeta = s.Load<Planeta>(idPlanete);
                IEnumerable<Brod> sviBrodovi;
                if(tip == "borbeni")
                {
                    sviBrodovi = from b in s.Query<BorbeniBrod>()
                                 where b.PlanetaKonstrukcije == planeta
                                 select b;
                    foreach (BorbeniBrod brod in sviBrodovi)
                    {
                        brodovi.Add(new BorbeniBrodPregled(
                            brod.JedinstveniBroj,
                            brod.Naziv,
                            brod.MaxWarpBrzina,
                            brod.FotonskoTorpedo,
                            brod.BrojLaserskihTopova,
                            brod.Tip
                        ));
                    }
                }
                else
                {
                    sviBrodovi = from b in s.Query<TransportniBrod>()
                                 where b.PlanetaKonstrukcije == planeta
                                 select b;
                    foreach (TransportniBrod brod in sviBrodovi)
                    {
                        brodovi.Add(new TransportniBrodPregled(
                                 brod.JedinstveniBroj,
                                 brod.Naziv,
                                 brod.MaxWarpBrzina,
                                 brod.ZastitnaOtplata,
                                 brod.Nosivost
                             ));
                    }
                }            
                s.Close();

            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return brodovi;

        }

        public static bool dodajBrod(BorbeniBrodBasic br, int idPosade, int idPlanete)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                BorbeniBrod brod = new BorbeniBrod();
                Posada posada = s.Load<Posada>(idPosade);
                Planeta planeta = s.Load<Planeta>(idPlanete);
                brod.Naziv = br.naziv;
                brod.MaxWarpBrzina = br.maxWarpBrzina;
                brod.BrojLaserskihTopova = br.brojLaserskihTopova;
                brod.Tip = br.tip;
                brod.FotonskoTorpedo = br.fotonskoTorpedo;
                brod.PosadaKojaPoseduje = posada;
                brod.PlanetaKonstrukcije = planeta;

                s.SaveOrUpdate(brod);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
                return false;
            }
            return true;
        }
        public static bool dodajBrod(TransportniBrodBasic br, int idPosade, int idPlanete)
        {
            try
            {
                ISession s = DataLayer.GetSession();
                TransportniBrod brod = new TransportniBrod();
                Posada posada = s.Load<Posada>(idPosade);
                Planeta planeta = s.Load<Planeta>(idPlanete);
                brod.Naziv = br.naziv;
                brod.MaxWarpBrzina = br.maxWarpBrzina;
                brod.Nosivost = br.nosivost;
                brod.PosadaKojaPoseduje = posada;
                brod.ZastitnaOtplata = br.zastitnaOtplata;
                brod.PlanetaKonstrukcije = planeta;

                s.SaveOrUpdate(brod);

                s.Flush();

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
                return false;
            }
            return true;

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
                    igraci.Add(new IgracPregled(i.Username, i.Ime, i.Prezime, i.Pol, i.Drzava, i.DatumOtvaranjaNaloga, i.DatumRodjenja, i.Email, i.URLAvatara, i.Opis));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return igraci;
        }

        public static void dodajIgraca(IgracBasic i)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Igrac o = new Igrac();
                Planeta planeta = s.Query<Planeta>()
                    .FirstOrDefault(p => !s.Query<Igrac>().Any(ig => ig.MaticnaPlaneta == p));

                o.Ime = i.ime;
                o.Prezime = i.prezime;
                o.Pol = i.pol;
                o.Email = i.email;
                o.Opis = i.opis;
                o.URLAvatara = i.urlAvatara;
                o.DatumRodjenja = i.datumRodjenja;
                o.DatumOtvaranjaNaloga = i.datumOtvaranjaNaloga;
                o.Drzava = i.drzava;
                o.MaticnaPlaneta = planeta;
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
        #region Savez
        public static void dodajSavez(SavezBasic u)
        {
            try
            {
                ISession s = DataLayer.GetSession();

                Savez un = new Savez();

                un.Naziv = u.naziv;
                un.DatumFormiranja = u.datumFormiranja;
                s.SaveOrUpdate(un);
                s.Flush();
                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }
        }
        public static List<SavezPregled> vratiSveSaveze()
        {
            List<SavezPregled> savezi = new List<SavezPregled>();
            try
            {
                ISession s = DataLayer.GetSession();

                IEnumerable<Savez> sviSavezi = from o in s.Query<Savez>()
                                               select o;

                foreach (Savez u in sviSavezi)
                {
                    savezi.Add(new SavezPregled(u.Naziv, u.DatumFormiranja));
                }

                s.Close();
            }
            catch (Exception ec)
            {
                new InnerExceptionHandler().handle(ec);
            }

            return savezi;
        }
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
