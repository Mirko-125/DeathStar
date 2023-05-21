using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Entiteti
{
    internal class PlanetaMapiranja : ClassMap<Planeta>
    {
        public PlanetaMapiranja()
        {
            Table("PLANETA");

            Id(x => x.Id, "ID").GeneratedBy.TriggerIdentity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.GlavniGrad, "GLAVNI_GRAD");
            Map(x => x.BrojStanovnika, "BROJ_STANOVNIKA");
            Map(x => x.DominantnaRasa, "DOMINANTNA_RASA");
            Map(x => x.DrustvenoUredjenje, "DRUSTVENO_UREDJENJE");
            Map(x => x.ImeZvezdanogSistema, "IME_ZVEZDANOG_SISTEMA");
            Map(x => x.TipZvezdanogSistema, "TIP_ZVEZDANOG_SISTEMA");
            Map(x => x.X, "X");
            Map(x => x.Y, "Y");
            Map(x => x.Z, "Z");
            Map(x => x.Berilijum, "BERILIJUM");
            Map(x => x.Trilijum, "TRILIJUM");
            Map(x => x.Plutonijum, "PLUTONIJUM");
            Map(x => x.DatumKolonizacije, "DATUM_KOLONIZACIJE");

            References(x => x.UGalaksiji, "NAZIVG").LazyLoad();
            References(x => x.PosadaOsvajaca, "POSADAID").LazyLoad();
            References(x => x.IgracKojiJePoseduje, "USERNAMEI").LazyLoad();

            HasOne(x => x.IgracMaticna)
                .PropertyRef(x => x.MaticnaPlaneta)
                .LazyLoad();

            HasMany(x => x.Gradovi)
                .KeyColumns.Add("IDP")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.IstorijaOsvajanja)
                .KeyColumn("IDP")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Sateliti)
                .KeyColumn("IDP")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Pojave)
                .KeyColumn("IDP")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Brodovi)
                .KeyColumn("IDP")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}