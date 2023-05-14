using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;


namespace DeathStar.Mapiranja
{
    internal abstract class SatelitMapiranja : ClassMap<Satelit>
    {
        public SatelitMapiranja() 
        {
            UseUnionSubclassForInheritanceMapping();
            Id(x => x.Naziv, "NAZIV").GeneratedBy.Guid();
            Map(x=>x.Udaljenost).Column("UDALJENOST");
            References(x => x.KruziOkoPlanete, "IDP").LazyLoad();
        }
    }
}
