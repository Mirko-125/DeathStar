using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Mapiranja
{
    internal class BrodMapiranja : ClassMap<Brod>
    {
        public BrodMapiranja()
        {
            UseUnionSubclassForInheritanceMapping();
            Id(x => x.JedinstveniBroj, "JEDINSTVENI_BROJ").GeneratedBy.SequenceIdentity("S19040.SHARED_JEDINSTVENI_BROJ_SEQ");

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.MaxWarpBrzina, "MAKSIMALNA_WARP_BRZINA");

            References(x => x.PosadaKojaPoseduje, "POSADAID").LazyLoad();
            References(x => x.PlanetaKonstrukcije, "IDP").LazyLoad();
        }
    }
}
