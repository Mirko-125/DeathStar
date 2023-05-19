using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Mapiranja
{
    internal class GalaksijaMapiranja : ClassMap<Galaksija>
    {
        public GalaksijaMapiranja()
        {
            Table("GALAKSIJA");

            Id(x => x.Naziv, "NAZIV").GeneratedBy.Assigned();
            Map(x => x.ProcenjenBrojPlaneta).Column("PROCENJEN_BROJ_PLANETA");
            Map(x => x.ProcenjenBrojZvezda).Column("PROCENJEN_BROJ_ZVEZDA");
            Map(x => x.DominantnaRasa).Column("DOMINANTNA_RASA");

            HasMany(x => x.Planete)
                .KeyColumn("NAZIVG")
                .LazyLoad()
                .Cascade.All()
                .Inverse();

            HasMany(x => x.Kvadranti)
                .KeyColumn("NAZIVG")
                .LazyLoad()
                .Cascade.All()
                .Inverse();
        }
    }
}
