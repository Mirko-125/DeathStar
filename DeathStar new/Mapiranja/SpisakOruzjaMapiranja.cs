using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Mapiranja
{
    internal class SpisakOruzjaMapiranja : ClassMap<SpisakOruzja>
    {
        public SpisakOruzjaMapiranja()
        {
            CompositeId()
                .KeyReference(x => x.Oruzja, "IDS")
                .KeyProperty(x => x.Oruzje, "Oruzje");
        }
    }
}
