using DeathStar.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Mapiranja
{
    internal class GradoviPlaneteMapiranja : ClassMap<GradoviPlanete>
    {
        public GradoviPlaneteMapiranja()
        {
            CompositeId()
                .KeyReference(x => x.GradPlaneta, "IDP")
                .KeyProperty(x => x.Grad, "GRAD");
        }
    }
}
