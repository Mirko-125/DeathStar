using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class SpisakOruzja
    {
        public virtual VojnaStanica Oruzja { get; set; }
        public virtual string Oruzje { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (obj.GetType() != this.GetType()) return false;

            var other = (SpisakOruzja)obj;

            return Oruzja == other.Oruzja && Oruzje == other.Oruzje;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + Oruzja.GetHashCode();
                hash = hash * 23 + Oruzje.GetHashCode();
                return hash;
            }
        }
    }
}
