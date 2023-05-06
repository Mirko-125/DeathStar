using DeathStar.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Mapiranja
{
    internal class CivilnaStanicaMapiranja : SubclassMap<CivilnaStanica>
    {
        public CivilnaStanicaMapiranja()
        {
            Table("CIVILNA_STANICA");
            KeyColumn("NAZIV");

            Map(x => x.Svrha).Column("SVRHA");

        }
    }
}
