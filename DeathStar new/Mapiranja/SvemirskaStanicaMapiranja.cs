using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Mapiranja
{
    internal class SvemirskaStanicaMapiranja : ClassMap<SvemirskaStanica>
    {
        public SvemirskaStanicaMapiranja()
        {
            UseUnionSubclassForInheritanceMapping();
            Id(x => x.Id).GeneratedBy.SequenceIdentity("S19040.SHARED_STANICA_ID_SEQ");
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Udaljenost).Column("UDALJENOST");          
            Map(x => x.BrojLjudi).Column("BROJ_LJUDI");
            Map(x => x.Velicina).Column("VELICINA");

            References(x => x.DeoPlanete, "IDP").LazyLoad();
        }
    }
}
