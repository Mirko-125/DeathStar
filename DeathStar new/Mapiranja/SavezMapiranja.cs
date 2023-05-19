using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar_new.Mapiranja
{
    internal class SavezMapiranja : ClassMap<Savez>
    {
        public SavezMapiranja()
        {
            Table("SAVEZ");

            Id(x => x.Naziv, "NAZIV").GeneratedBy.Assigned();
            Map(x => x.DatumFormiranja, "DATUM_FORMIRANJA");
            References(x => x.DeoSaveza, "NAZIVS").LazyLoad();
            References(x => x.DeoPosade, "POSADAID").LazyLoad();

            HasMany(x => x.Savezi)
                .KeyColumn("SAVEZ_DEO")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
                
           HasMany(x => x.Igraci)
                .KeyColumn("SAVEZ")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
