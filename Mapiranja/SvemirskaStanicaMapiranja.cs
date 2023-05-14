using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal abstract class SvemirskaStanicaMapiranja : SubclassMap<SvemirskaStanica>
    {
        public SvemirskaStanicaMapiranja()
        {

            Abstract();
            Map(x => x.BrojLjudi).Column("BROJ_LJUDI");
            Map(x => x.Velicina).Column("VELICINA");

        }
    }
}
