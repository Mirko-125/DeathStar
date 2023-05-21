using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar_new.Mapiranja
{
    internal class CivilnaStanicaMapiranja : SubclassMap<CivilnaStanica>
    {
        public CivilnaStanicaMapiranja()
        {
            Table("CIVILNA_SVEMIRSKA_STANICA");
            Abstract();
            Map(x => x.Svrha).Column("SVRHA");
        }
    }
}
