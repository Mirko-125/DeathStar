using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar_new.Entiteti
{
    internal class GradoviPlanete
    {
        public virtual Planeta GradPlaneta { get; set; }
        public virtual string Grad { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            var other = (GradoviPlanete)obj;

            return GradPlaneta == other.GradPlaneta && Grad == other.Grad;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + GradPlaneta.GetHashCode();
                hash = hash * 23 + Grad.GetHashCode();
                return hash;
            }
        }
    }
}
