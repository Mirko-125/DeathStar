using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal class PrirodniSatelitMapiranja : SubclassMap<PrirodniSatelit>
    {     
        public PrirodniSatelitMapiranja()
        {
            Table("PRIRODNI_SATELIT");
            Abstract();
            Map(x => x.Precnik, "PRECNIK");
            Map(x => x.Naseobine, "NASEOBINE");
        }
    }
}
