﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DeathStar.Entiteti;
using FluentNHibernate.Mapping;

namespace DeathStar.Mapiranja
{
    internal class OsvajanjeMapiranja : ClassMap<Osvajanje>
    {
        public OsvajanjeMapiranja()
        {
            Table("OSVAJANJE");

            Id(x => x.Id, "ID").GeneratedBy.Identity();
            Map(x => x.DatumOsvajanja).Column("DATUM_OSVAJANJA");

            //References(x => x.PosadaOsvaja).Column("POSADAID").LazyLoad();
            References(x => x.PrethodniVlasnik).Column("USERNAMEI").LazyLoad();
            References(x => x.PlanetaOsvojena).Column("IDP").LazyLoad();
        }

    }
}
