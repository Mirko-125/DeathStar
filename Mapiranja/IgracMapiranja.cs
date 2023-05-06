using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal class IgracMapiranja : ClassMap<Igrac>
    {
        public IgracMapiranja()
        {
            Table("IGRAC");
            Id(x => x.Username, "USERNAME").GeneratedBy.Assigned();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Pol).Column("SEX");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.Opis).Column("OPIS");
            Map(x => x.URLAvatara).Column("AVATAR_URL");
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
            Map(x => x.DatumOtvaranjaNaloga).Column("DATUM_PRIDRUZIVANJA");
            Map(x => x.Drzava).Column("DRZAVA");

            // Strani kljucevi

            References(x => x.SavezKomePripada, "NAZIVS").LazyLoad();

            // Osvajanje trenutno ne znam

            // Planete koje poseduje +

            References(x => x.MaticnaPlaneta, "IDP").LazyLoad();

            HasMany(x => x.PosedujePlanete)
               .KeyColumn("USERNAMEI")
               .LazyLoad()
               .Cascade.All()
               .Inverse();

        }
    }
}
