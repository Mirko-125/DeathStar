using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;

namespace DeathStar.Mapiranja
{
    internal class TransportniBrodMapiranja : SubclassMap<TransportniBrod>
    {
        public TransportniBrodMapiranja()
        {
            Table("TRANSPORTNI_BROD");
            KeyColumn("JEDINSTVENI_BROJ");

            Map(x => x.ZastitnaOtplata).Column("ZASTITNA_OTPLATA_FLAG");
            Map(x => x.Nosivost).Column("NOSIVOST");

            //Strani kljuc/kljucevi
        }
    }
}
