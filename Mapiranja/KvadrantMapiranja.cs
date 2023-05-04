using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal class KvadrantMapiranja : ClassMap<Kvadrant>
    {
        public KvadrantMapiranja()
        {
            Table("KVADRANT");

            Id(x => x.RedniBroj, "REDNI_BROJ").GeneratedBy.Identity();
            Map(x => x.ProcenjeniPrecnik).Column("PROCENJENI_PRECNIK");
            References(x => x.GalaksijaDeo).Column("NAZIVGALAKSIJE").LazyLoad();
        }
    }
}
