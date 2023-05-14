using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal class PosadaMapiranja : ClassMap<Posada>
    {
        public PosadaMapiranja() 
        {
            /*
            Table("POSADA");

            Id(x => x.Id, "POSADAID").GeneratedBy.Identity();

            References(x => x.Igrac, "USERNAMEI").LazyLoad();
            References(x => x.Savez, "NAZIVS").LazyLoad();

            HasMany(x => x.Brodovi)
                .KeyColumn("JEDINSTVENI_BROJ")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Osvajanja)
                .KeyColumn("?") // Kljuc osvajanja
                .LazyLoad()
                .Cascade.All()
                .Inverse();
            */
        }
    }
}
