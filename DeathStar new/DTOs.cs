using DeathStar_new.Entiteti;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DeathStar_new
{
    #region Brod , Transportni brod, Borbeni brod // licni komentari
    public class BrodBasic
    {
        public int jedinstveniBroj;
        public string naziv;
        public double maxWarpBrzina;
        public PlanetaBasic planetaKonstrukcije;
        public PosadaBasic posadaKojuPoseduje;

        public BrodBasic() { }

        public BrodBasic(int jedinstveniBroj, string naziv, double maxWarpBrzina, PlanetaBasic planetaKonstrukcije, PosadaBasic posadaKojuPoseduje)
        {
            this.jedinstveniBroj = jedinstveniBroj;
            this.naziv = naziv;
            this.maxWarpBrzina = maxWarpBrzina;
            this.planetaKonstrukcije = planetaKonstrukcije;
            this.posadaKojuPoseduje = posadaKojuPoseduje;
        }
    }
    public class BorbeniBrodBasic : BrodBasic
    {
        public bool fotonskoTorpedo;
        public int brojLaserskihTopova;
        public string tip;
        public BorbeniBrodBasic() { }
        // radim po nekom sablonu, trebalo bi dobro da je, proveri da li u ovaj pun konstruktor trebaju i atributi iz nadklase ili ne
        public BorbeniBrodBasic(int jedinstveniBroj, string naziv, double maxWarpBrzina, PlanetaBasic platenaKonstrukcije, PosadaBasic posadaKojuPoseduje, bool fotonskoTorpedo, int brojLaserskihTopova, string tip) : base(jedinstveniBroj, naziv, maxWarpBrzina, platenaKonstrukcije, posadaKojuPoseduje)
        {
            this.fotonskoTorpedo = fotonskoTorpedo;
            this.brojLaserskihTopova = brojLaserskihTopova;
            this.tip = tip;
        }
    }
    public class TransportniBrodBasic : BrodBasic
    {
        public bool zastitnaOtplata; // ;D
        public double nosivost;
        public TransportniBrodBasic() { }
        public TransportniBrodBasic(int jedinstveniBroj, string naziv, double maxWarpBrzina, PlanetaBasic platenaKonstrukcije, PosadaBasic posadaKojuPoseduje, bool zastitnaOtplata, double nosivost) : base(jedinstveniBroj, naziv, maxWarpBrzina, platenaKonstrukcije, posadaKojuPoseduje)
        {
            this.zastitnaOtplata = zastitnaOtplata;
            this.nosivost = nosivost;
        }
    }
    public class BrodPregled
    {
        public int jedinstveniBroj;
        public string naziv;
        public double maxWarpBrzina;
        // koliko sam shvatio u pregled idu stvari koje su samo domace dok u basic ide i domace i strano
        public BrodPregled() { }
        public BrodPregled(int jedinstveniBroj, string naziv, double maxWarpBrzina)
        {
            this.jedinstveniBroj = jedinstveniBroj;
            this.naziv = naziv;
            this.maxWarpBrzina = maxWarpBrzina;
        }
    }
    public class BorbeniBrodPregled : BrodPregled
    {
        public bool fotonskoTorpedo;
        public int brojLaserskihTopova;
        public string tip;
        public BorbeniBrodPregled() { }
        public BorbeniBrodPregled(int jedinstveniBroj, string naziv, double maxWarpBrzina, bool fotonskoTorpedo, int brojLaserskihTopova, string tip) : base(jedinstveniBroj, naziv, maxWarpBrzina)
        {
            this.fotonskoTorpedo = fotonskoTorpedo;
            this.brojLaserskihTopova = brojLaserskihTopova;
            this.tip = tip;
        }
    }
    public class TransportniBrodPregled : BrodPregled
    {
        public bool zastitnaOtplata;
        public double nosivost;
        public TransportniBrodPregled() { }
        public TransportniBrodPregled(int jedinstveniBroj, string naziv, double maxWarpBrzina, bool zastitnaOtplata, double nosivost) : base(jedinstveniBroj, naziv, maxWarpBrzina)
        {
            this.zastitnaOtplata = zastitnaOtplata;
            this.nosivost = nosivost;
        }
    }
    #endregion

    #region Stanice, svemirske, vojnce, sateliti... i spisak oruzja // proveri visevrednosni atribut
    public class SatelitBasic
    {
        public string naziv;
        public int udaljenost;
        public PlanetaBasic kruziOkoPlanete;
        public SatelitBasic() { }
        public SatelitBasic(string naziv, int udaljenost, PlanetaBasic kruziOkoPlanete)
        {
            this.naziv = naziv;
            this.udaljenost = udaljenost;
            this.kruziOkoPlanete = kruziOkoPlanete;
        }
    }
    public class PrirodniSatelitBasic : SatelitBasic
    {
        public int precnik;
        public bool naseobine;
        public PrirodniSatelitBasic() { }
        public PrirodniSatelitBasic(string naziv, int udaljenost, PlanetaBasic kruziOkoPlanete, int precnik, bool naseobine) : base(naziv, udaljenost, kruziOkoPlanete)
        {
            this.precnik = precnik;
            this.naseobine = naseobine;
        }
    }
    public class SvemirskaStanicaBasic : SatelitBasic
    {
        public int brojLjudi;
        public int velicina;
        public SvemirskaStanicaBasic() { }
        public SvemirskaStanicaBasic(string naziv, int udaljenost, PlanetaBasic kruziOkoPlanete, int brojLjudi, int velicina) : base(naziv, udaljenost, kruziOkoPlanete)
        {
            this.brojLjudi = brojLjudi;
            this.velicina = velicina;
        }
    }
    public class CivilnaStanicaBasic : SvemirskaStanicaBasic
    {
        public string svrha;
        public CivilnaStanicaBasic() { }
        public CivilnaStanicaBasic(string naziv, int udaljenost, PlanetaBasic kruziOkoPlanete, string svrha, int brojLjudi, int velicina) : base(naziv, udaljenost, kruziOkoPlanete, brojLjudi, velicina)
        {
            this.svrha = svrha;
        }
    }
    public class VojnaStanicaBasic : SvemirskaStanicaBasic
    {
        public IList<SpisakOruzjaBasic> oruzja;
        public VojnaStanicaBasic()
        {
            oruzja = new List<SpisakOruzjaBasic>();
        }
        public VojnaStanicaBasic(string naziv, int udaljenost, PlanetaBasic kruziOkoPlanete, int brojLjudi, int velicina) : base(naziv, udaljenost, kruziOkoPlanete, brojLjudi, velicina)
        {
            // doublecheckuj ovo
        }
    }
    public class SpisakOruzjaBasic
    {
        public VojnaStanicaBasic oruzja;
        public string oruzje;
        public SpisakOruzjaBasic() { }
        public SpisakOruzjaBasic(VojnaStanicaBasic oruzja, string oruzje)
        {
            this.oruzja = oruzja;
            this.oruzje = oruzje;
        }
    }
    public class SatelitPregled
    {
        public string naziv;
        public int udaljenost;
        // ispravi me ako gresim ali trebalo bi da je ovako
        public SatelitPregled() { }
        public SatelitPregled(string naziv, int udaljenost)
        {
            this.naziv = naziv;
            this.udaljenost = udaljenost;
        }
    }
    public class PrirodniSatelitPregled : SatelitPregled
    {
        public int precnik;
        public bool naseobine;
        public PrirodniSatelitPregled() { }
        public PrirodniSatelitPregled(string naziv, int udaljenost, int precnik, bool naseobine) : base(naziv, udaljenost)
        {
            this.precnik = precnik;
            this.naseobine = naseobine;
        }
    }
    public class SvemirskaStanicaPregled : SatelitPregled
    {
        public int brojLjudi;
        public int velicina;
        public SvemirskaStanicaPregled() { }
        public SvemirskaStanicaPregled(string naziv, int udaljenost, int brojLjudi, int velicina) :base(naziv, udaljenost)
        {
            this.brojLjudi = brojLjudi;
            this.velicina = velicina;
        }
    }
    public class CivilnaSvemirskaStanicaPregled : SvemirskaStanicaPregled
    {
        public string svrha;
        public CivilnaSvemirskaStanicaPregled() { }
        public CivilnaSvemirskaStanicaPregled(string naziv, int udaljenost, string svrha, int brojLjudi, int velicina) : base(naziv, udaljenost, brojLjudi, velicina)
        {
            this.svrha = svrha;
        }
    }
    public class VojnaStanicaPregled : SvemirskaStanicaPregled
    {
        public VojnaStanicaPregled()
        {
            // nzm sad kako da prikaze spsak oruzja
        }
        public VojnaStanicaPregled(string naziv, int udaljenost, int brojLjudi, int velicina) : base(naziv, udaljenost, brojLjudi, velicina)
        {
            // doublecheckuj ovo
        }
    }
    public class SpisakOruzjaPregled
    {
        public string oruzje;
        public SpisakOruzjaPregled() { }
        public SpisakOruzjaPregled(string oruzje)
        {
            this.oruzje = oruzje;
        }
    }
    #endregion

    #region Igrac, sumnjive liste
    public class IgracBasic
    {
        public string username;
        public string ime;
        public string prezime;
        public string pol;
        public string drzava;
        public DateTime datumOtvaranjaNaloga;
        public DateTime datumRodjenja;
        public string email;
        public string urlAvatara;
        public string opis;
        //kljucevi...
        public PosadaBasic deoPosade;
        public PlanetaBasic maticnaPlaneta;
        public IList<PlanetaBasic> posedujePlanete;
        public SavezBasic savezKomePripada;
        public IgracBasic()
        {
            posedujePlanete = new List<PlanetaBasic>();
        }
        public IgracBasic(string username, string ime, string prezime, string pol, string drzava, DateTime datumOtvaranjaNaloga, DateTime datumRodjenja, string email, string urlAvatara, string opis, PosadaBasic deoPosade, PlanetaBasic maticnaPlaneta, SavezBasic savezKomePripada)
        {
            this.username = username;
            this.ime = ime;
            this.prezime = prezime;
            this.pol = pol;
            this.drzava = drzava;
            this.datumOtvaranjaNaloga = datumOtvaranjaNaloga;
            this.datumRodjenja = datumRodjenja;
            this.email = email;
            this.urlAvatara = urlAvatara;
            this.opis = opis;
            this.deoPosade = deoPosade;
            this.maticnaPlaneta = maticnaPlaneta;
            this.savezKomePripada = savezKomePripada;
        }
    }
    public class IgracPregled
    {
        public string username;
        public string ime;
        public string prezime;
        public string pol;
        public string drzava;
        public DateTime datumOtvaranjaNaloga;
        public DateTime datumRodjenja;
        public string email;
        public string urlAvatara;
        public string opis;
        public IgracPregled()
        {

        }
        public IgracPregled(string username, string ime, string prezime, string pol, string drzava, DateTime datumOtvaranjaNaloga, DateTime datumRodjenja, string email, string urlAvatara, string opis)
        {
            this.username = username;
            this.ime = ime;
            this.prezime = prezime;
            this.pol = pol;
            this.drzava = drzava;
            this.datumOtvaranjaNaloga = datumOtvaranjaNaloga;
            this.datumRodjenja = datumRodjenja;
            this.email = email;
            this.urlAvatara = urlAvatara;
            this.opis = opis;
        }
    }
    #endregion

    #region Planeta i njeni gradovi, proveriti liste!
    public class PlanetaBasic
    {
        public int idPlanete;
        public string naziv;
        public string glavniGrad;
        public Int64 brojStanovnika;
        public string dominantnaRasa;
        public string drustvenoUredjenje;
        public string imeZvezdanogSistema;
        public string tipZvezdanogSistema;
        public int x;
        public int y;
        public int z;
        public int berilijum;
        public int trilijum;
        public int plutonijum;
        public DateTime datumKolonizacije;

        public IList<GradoviPlaneteBasic> gradovi;
        public PosadaBasic posadaOsvajaca;
        public PosadaBasic posadaKolonista;
        public IgracBasic igracMaticna;
        public IgracBasic igracKojiPoseduje;
        public GalaksijaBasic uGalaksiji;
        public IList<SatelitBasic> sateliti;
        public IList<BrodBasic> brodovi;
        public IList<PojavaBasic> pojave;

        public PlanetaBasic()
        {
            gradovi = new List<GradoviPlaneteBasic>();
            sateliti = new List<SatelitBasic>();
            brodovi = new List<BrodBasic>();
            pojave = new List<PojavaBasic>();
        }
        public PlanetaBasic(int idPlanete, string naziv, string glavniGrad, Int64 brojStanovnika, string dominantnaRasa, string drustvenoUredjenje, string imeZvezdanogSistema, string tipZvezdanogSistema, int x, int y, int z, string berilijum, string trilijum, string plutonijum, DateTime datumKolonizacije, PosadaBasic posadaOsvajaca, PosadaBasic posadaKolonista, IgracBasic igracMaticna, IgracBasic igracKojiPoseduje, GalaksijaBasic uGalaksiji)
        {
            this.idPlanete = idPlanete;
            this.naziv = naziv;
            this.glavniGrad = glavniGrad;
            this.brojStanovnika = brojStanovnika;
            this.dominantnaRasa = dominantnaRasa;
            this.drustvenoUredjenje = drustvenoUredjenje;
            this.imeZvezdanogSistema = imeZvezdanogSistema;
            this.tipZvezdanogSistema = tipZvezdanogSistema;
            this.x = x;
            this.y = y;
            this.z = z;
            this.berilijum = Int32.Parse(berilijum);
            this.trilijum = Int32.Parse(trilijum);
            this.plutonijum = Int32.Parse(plutonijum);
            this.datumKolonizacije = datumKolonizacije;
            this.posadaOsvajaca = posadaOsvajaca;
            this.posadaKolonista = posadaKolonista;
            this.igracMaticna = igracMaticna;
            this.igracKojiPoseduje = igracKojiPoseduje;
            this.uGalaksiji = uGalaksiji;
        }
    }
    public class GradoviPlaneteBasic
    {
        public PlanetaBasic gradPlaneta;
        public string grad;
        public GradoviPlaneteBasic() { }
        public GradoviPlaneteBasic(PlanetaBasic gradPlaneta, string grad)
        {
            this.gradPlaneta = gradPlaneta;
            this.grad = grad;
        }
    }
    public class PlanetaPregled
    {
        public int idPlanete;
        public string naziv;
        public string glavniGrad;
        public Int64 brojStanovnika;
        public string dominantnaRasa;
        public string drustvenoUredjenje;
        public string imeZvezdanogSistema;
        public string tipZvezdanogSistema;
        public int x;
        public int y;
        public int z;
        public string berilijum;
        public string trilijum;
        public string plutonijum;
        public DateTime datumKolonizacije;

        public PlanetaPregled() { }
        public PlanetaPregled(int idPlanete, string naziv, string glavniGrad, Int64 brojStanovnika, string dominantnaRasa, string drustvenoUredjenje, string imeZvezdanogSistema, string tipZvezdanogSistema, int x, int y, int z, string berilijum, string trilijum, string plutonijum, DateTime datumKolonizacije)
        {
            this.idPlanete = idPlanete;
            this.naziv = naziv;
            this.glavniGrad = glavniGrad;
            this.brojStanovnika = brojStanovnika;
            this.dominantnaRasa = dominantnaRasa;
            this.drustvenoUredjenje = drustvenoUredjenje;
            this.imeZvezdanogSistema = imeZvezdanogSistema;
            this.tipZvezdanogSistema = tipZvezdanogSistema;
            this.x = x;
            this.y = y;
            this.z = z;
            this.berilijum = berilijum;
            this.trilijum = trilijum;
            this.plutonijum = plutonijum;
            this.datumKolonizacije = datumKolonizacije;
        }
    }
    public class GradoviPlanetePregled
    {
        public string grad;
        public GradoviPlanetePregled() { }
        public GradoviPlanetePregled(string grad)
        {
            this.grad = grad;
        }
    }
    #endregion

    #region Savez
    public class SavezBasic
    {
        public string naziv;
        public DateTime datumFormiranja;

        public SavezBasic savezDeo;
        public IList<SavezBasic> savezi;
        public IList<IgracBasic> igraci;
        public PosadaBasic posadaDeo;

        public SavezBasic()
        {
            savezi = new List<SavezBasic>();
            igraci = new List<IgracBasic>();
        }
        public SavezBasic(string naziv, DateTime datumFormiranja, SavezBasic savezDeo, PosadaBasic posadaDeo)
        {
            this.naziv = naziv;
            this.datumFormiranja = datumFormiranja;
            this.savezDeo = savezDeo;
            this.posadaDeo = posadaDeo;
        }
    }
    public class SavezPregled
    {
        public string naziv;
        public DateTime datumFormiranja;
        public SavezPregled() { }
        public SavezPregled(string naziv, DateTime datumFormiranja)
        {
            this.naziv = naziv;
            this.datumFormiranja = datumFormiranja;
        }
    }
    #endregion

    #region Galaksija
    public class GalaksijaBasic
    {
        public string naziv;
        public Int64 procenjenBrojZvezda;
        public Int64 procenjenBrojPlaneta;
        public string dominantnaRasa;

        public IList<PlanetaBasic> planete;
        public IList<KvadrantBasic> kvadranti;

        public GalaksijaBasic() 
        {
            planete = new List<PlanetaBasic>();
            kvadranti = new List<KvadrantBasic>();
        }
        public GalaksijaBasic(string naziv, Int64 procenjenBrojZvezda, Int64 procenjenBrojPlaneta, string dominantnaRasa)
        {
            this.naziv = naziv;
            this.procenjenBrojZvezda = procenjenBrojZvezda;
            this.procenjenBrojPlaneta = procenjenBrojPlaneta;
            this.dominantnaRasa = dominantnaRasa;
        }
    }
    public class GalaksijaPregled
    {
        public string naziv;
        public Int64 procenjenBrojZvezda;
        public Int64 procenjenBrojPlaneta;
        public string dominantnaRasa;

        public GalaksijaPregled() { }
        public GalaksijaPregled(string naziv, Int64 procenjenBrojZvezda, Int64 procenjenBrojPlaneta, string dominantnaRasa)
        {
            this.naziv = naziv;
            this.procenjenBrojZvezda = procenjenBrojZvezda;
            this.procenjenBrojPlaneta = procenjenBrojPlaneta;
            this.dominantnaRasa = dominantnaRasa;
        }
    }
    #endregion

    #region Pojava
    public class PojavaBasic
    {
        public string naziv;
        public string tipPojave;
        public bool izazivaLiOpasnost;
        public PlanetaBasic planetaDeo;
        public PojavaBasic() { }
        public PojavaBasic(string naziv, string tipPojave, bool izazivaLiOpasnost, PlanetaBasic planetaDeo)
        {
            this.naziv = naziv;
            this.tipPojave = tipPojave;
            this.izazivaLiOpasnost = izazivaLiOpasnost;
            this.planetaDeo = planetaDeo;
        }
    }
    public class PojavaPregled
    {
        public string naziv;
        public string tipPojave;
        public bool izazivaLiOpasnost;
        public PojavaPregled() { }
        public PojavaPregled(string naziv, string tipPojave, bool izazivaLiOpasnost)
        {
            this.naziv = naziv;
            this.tipPojave = tipPojave;
            this.izazivaLiOpasnost = izazivaLiOpasnost;
        }
    }
    #endregion

    #region Posada i osvajanja
    public class PosadaBasic
    {
        public int idPosade;
        public IgracBasic igrac;
        public SavezBasic savez;
        public IList<BrodBasic> brodovi;
        public IList<OsvajanjeBasic> osvajanja;
        public PosadaBasic()
        {
            brodovi = new List<BrodBasic>();
            osvajanja = new List<OsvajanjeBasic>();
        }

        public PosadaBasic(int idPosade, IgracBasic igrac, SavezBasic savez)
        {
            this.idPosade = idPosade;
            this.igrac = igrac;
            this.savez = savez;
        }
    }

    public class OsvajanjeBasic
    {
        public int idPosade;
        public DateTime datumOsvajanja;

        public PosadaBasic posadaOsvaja;
        public IgracBasic prethodniVlasnik;
        public PlanetaBasic planetaOsvojena;

        public OsvajanjeBasic() { }
        public OsvajanjeBasic(int idPosade, DateTime datumOsvajanja, PosadaBasic posadaOsvaja, IgracBasic prethodniVlasnik, PlanetaBasic planetaOsvojena)
        {
            this.idPosade = idPosade;
            this.datumOsvajanja = datumOsvajanja;
            this.posadaOsvaja = posadaOsvaja;
            this.prethodniVlasnik = prethodniVlasnik;
            this.planetaOsvojena = planetaOsvojena;
        }
    }
    public class PosadaPregled
    { 
        public int idPosade;
        public PosadaPregled() { }
        public PosadaPregled(int idPosade)
        {
            this.idPosade = idPosade;
        }
    }

    public class OsvajanjaPregled
    {
        public int idPosade;
        public DateTime datumOsvajanja;

        public OsvajanjaPregled() { }
        public OsvajanjaPregled(int idPosade, DateTime datumOsvajanja)
        {
            this.idPosade = idPosade;
            this.datumOsvajanja = datumOsvajanja;
        }
    }
    #endregion

    #region Kvadrant
    public class KvadrantBasic
    {
        public int redniBroj;
        public double procenjeniPrecnik;
        public GalaksijaBasic galaksijaDeo;
        public KvadrantBasic() { }
        public KvadrantBasic(int redniBroj, double procenjeniPrecnik, GalaksijaBasic galaksijaDeo)
        {
            this.redniBroj = redniBroj;
            this.procenjeniPrecnik = procenjeniPrecnik;
            this.galaksijaDeo = galaksijaDeo;
        }
    }
    public class KvadrantPregled
    {
        public int redniBroj;
        public double procenjeniPrecnik;
        public KvadrantPregled(){}
        public KvadrantPregled(int redniBroj, double procenjeniPrecnik)
        {
            this.redniBroj = redniBroj;
            this.procenjeniPrecnik = procenjeniPrecnik;
        }
    }
    #endregion
}
