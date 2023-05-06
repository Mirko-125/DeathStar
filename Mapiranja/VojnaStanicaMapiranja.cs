using DeathStar.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Mapiranja
{
    internal class VojnaStanicaMapiranja : SubclassMap<VojnaStanica>
    {
        public VojnaStanicaMapiranja() 
        {
            Table("VOJNA");
            KeyColumn("NAZIV");

            HasMany(x => x.Oruzija)
                .KeyColumn("ORUZJE")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
            // Visevrednosni atribut

            // Ovo samo ig
        }
    }
}
