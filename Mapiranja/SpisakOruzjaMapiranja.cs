using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal class SpisakOruzjaMapiranja : ClassMap<SpisakOruzja>
    {
        public SpisakOruzjaMapiranja()
        {
            CompositeId()
                .KeyReference(x => x.Oruzje, "IDP")
                .KeyProperty(x => x.Oruzje, "GRAD");
        }
    }
}
