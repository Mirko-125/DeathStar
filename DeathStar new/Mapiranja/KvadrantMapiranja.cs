using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Mapiranja
{
    internal class KvadrantMapiranja : ClassMap<Kvadrant>
    {
        public KvadrantMapiranja()
        {
            Table("KVADRANT");

            Id(x => x.RedniBroj, "REDNI_BROJ").GeneratedBy.TriggerIdentity();
            Map(x => x.ProcenjeniPrecnik).Column("PROCENJENI_PRECNIK");
            References(x => x.DeoGalaksije).Column("NAZIVG").LazyLoad();
        }
    }
}
