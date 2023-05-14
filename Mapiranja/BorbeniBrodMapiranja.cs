using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;

namespace DeathStar.Mapiranja
{
    internal class BorbeniBrodMapiranja : SubclassMap<BorbeniBrod>
    {
        public BorbeniBrodMapiranja()
        {
            Table("BORBENI_BROD");
            Abstract();

            Map(x => x.FotonskoTorpedo).Column("FOTONSKO_TORPEDO_FLAG");
            Map(x => x.BrojLaserskihTopova).Column("BROJ_LASERSKIH_TOPOVA");
            Map(x => x.Tip).Column("TIP_BRODA"); // Ovde je tip Enum, proveri to
             
            //Posto je subclass ne bi trebalo da radim veze ovde?
        }
    }
}
