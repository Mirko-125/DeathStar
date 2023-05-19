using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Mapiranja
{
    internal class PosadaMapiranja : ClassMap<Posada>
    {
        public PosadaMapiranja() 
        {
            Table("POSADA");
            Id(x => x.Id, "ID").GeneratedBy.Identity();

            HasOne(x => x.Igrac).PropertyRef(x => x.DeoPosade);
            HasOne(x => x.Savez).PropertyRef(x => x.DeoPosade);

            HasMany(x => x.Brodovi)
                .KeyColumn("PosadaID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Osvajanja)
                .KeyColumn("PosadaID")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

        }
    }
}
