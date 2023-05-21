using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Mapiranja
{
    internal class PojavaMapiranja : ClassMap<Pojava>
    {
        public PojavaMapiranja()
        {
            Table("POJAVA");
            Id(x => x.Naziv, "NAZIV").GeneratedBy.Assigned();
            Map(x => x.TipPojave).Column("TIP_POJAVE");
            Map(x => x.IzazivaLiOpasnost).Column("IZAZIVA_LI_OPASNOST");
            Map(x => x.Udaljenost).Column("UDALJENOST");
            References(x => x.PlanetaDeo).Column("IDP").LazyLoad();
        }
    }
}
