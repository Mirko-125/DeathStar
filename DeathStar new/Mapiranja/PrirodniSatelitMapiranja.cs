using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Mapiranja
{
    internal class PrirodniSatelitMapiranja : ClassMap<PrirodniSatelit>
    {     
        public PrirodniSatelitMapiranja()
        {        
            Table("PRIRODNI_SATELIT");

            Id(x => x.Naziv, "NAZIV").GeneratedBy.Assigned();
            Map(x => x.Udaljenost).Column("UDALJENOST");        
            Map(x => x.Precnik, "PRECNIK");
            Map(x => x.Naseobine, "NASEOBINE");

            References(x => x.KruziOkoPlanete, "IDP").LazyLoad();
        }
    }
}
