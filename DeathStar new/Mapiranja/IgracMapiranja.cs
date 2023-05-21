using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar_new.Mapiranja
{
    internal class IgracMapiranja : ClassMap<Igrac>
    {
        public IgracMapiranja()
        {
            Table("IGRAC");
            Id(x => x.Username, "USERNAME").GeneratedBy.Assigned();

            Map(x => x.Ime).Column("IME");
            Map(x => x.Prezime).Column("PREZIME");
            Map(x => x.Pol).Column("POL");
            Map(x => x.Email).Column("EMAIL");
            Map(x => x.Opis).Column("OPIS");
            Map(x => x.URLAvatara).Column("AVATAR");
            Map(x => x.DatumRodjenja).Column("DATUM_RODJENJA");
            Map(x => x.DatumOtvaranjaNaloga).Column("DATUM_OTVARANJA_NALOGA");
            Map(x => x.Drzava).Column("DRZAVA");

            References(x => x.DeoSaveza, "NAZIVS").LazyLoad();
            References(x => x.MaticnaPlaneta, "IDP").LazyLoad().Unique();
            References(x => x.DeoPosade, "POSADAID").LazyLoad();

            HasMany(x => x.PosedujePlanete)
               .KeyColumn("USERNAMEI")
               .LazyLoad()
               .Cascade.All()
               .Inverse();

            HasMany(x => x.IstorijaBivsihPlaneta)
               .KeyColumn("USERNAMEI")
               .LazyLoad()
               .Cascade.All()
               .Inverse();

        }
    }
}
