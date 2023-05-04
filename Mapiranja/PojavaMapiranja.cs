using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal class PojavaMapiranja : ClassMap<Pojava>
    {
        public PojavaMapiranja()
        {
            Table("POJAVA");
            Map(x => x.Naziv).Column("NAZIV");
            Map(x => x.TipPojave).Column("TIP_POJAVE");
            Map(x => x.IzazivaLiOpasnost).Column("IZAZIVA_LI_OPASNOST");

            References(x => x.PlanetaDeo).Column("IDP").LazyLoad();
        }
    }
}
