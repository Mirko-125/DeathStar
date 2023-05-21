using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;

namespace DeathStar_new.Mapiranja
{
    internal class BorbeniBrodMapiranja : SubclassMap<BorbeniBrod>
    {
        public BorbeniBrodMapiranja()
        {
            Table("BORBENI_BROD");
            Abstract();

            Map(x => x.FotonskoTorpedo).Column("FOTONSKO_TORPEDO");
            Map(x => x.BrojLaserskihTopova).Column("BROJ_LASERSKIH_TOPOVA");
            Map(x => x.Tip).Column("TIP_BRODA"); 
        }
    }
}
