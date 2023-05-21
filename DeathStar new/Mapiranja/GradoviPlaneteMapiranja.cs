using DeathStar_new.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar_new.Mapiranja
{
    internal class GradoviPlaneteMapiranja : ClassMap<GradoviPlanete>
    {
        public GradoviPlaneteMapiranja()
        {
            Table("GRADOVI_PLANETE");
            CompositeId()
                .KeyReference(x => x.GradPlaneta, "IDP")
                .KeyProperty(x => x.Grad, "GRAD");          
        }
    }
}
