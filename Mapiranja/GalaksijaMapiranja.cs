using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal class GalaksijaMapiranja : ClassMap<Galaksija>
    {
        public GalaksijaMapiranja()
        {
            Table("GALAKSIJA");

            Id(x => x.Naziv, "NAZIV");
            Map(x => x.ProcenjenBrojPlaneta).Column("PROCENJEN_BROJ_PLANETA");
            Map(x => x.ProcenjenBrojZvezda).Column("PROCENJEN_BROJ_ZVEZDA");
            Map(x => x.DominatnaRasa).Column("DOMINATNA_RASA");

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
