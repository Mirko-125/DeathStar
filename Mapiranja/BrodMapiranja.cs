using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal class BrodMapiranja : ClassMap<Brod>
    {
        public BrodMapiranja()
        {
            UseUnionSubclassForInheritanceMapping();
            Id(x => x.JedinstveniBroj, "JEDINSTVENI_BROJ").GeneratedBy.Guid();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.MaxWarpBrzina, "MAKSIMALNA_WARP_BRZINA");

            References(x => x.PosadaKojaPoseduje, "POSADAID").LazyLoad();
            References(x => x.PlanetaKonstrukcije, "IDP").LazyLoad();
        }
    }
}
