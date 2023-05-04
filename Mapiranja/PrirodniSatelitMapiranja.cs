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
            KeyColumn("NAZIV");

            Map(x => x.Precnik).Column("PRECNIK");
            Map(x => x.Naseobine).Column("NASEOBINE_FLAG");

            // Proveri strani kljuc
        }
    }
}
