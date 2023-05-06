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
            Table("PLANETA");
            Id(x => x.JedinstveniBroj, "JEDINSTVENI_BROJ").GeneratedBy.Identity();

            Map(x => x.Naziv, "NAZIV");
            Map(x => x.MaxWarpBrzina, "MAX_WARP_BRZINA");

            References(x => x.PosadaKojaPoseduje, "POSADAID").LazyLoad();
            References(x => x.PlanetaKonstrukcije, "IDP").LazyLoad();
        }
    }
}
