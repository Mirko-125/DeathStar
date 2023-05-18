using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class VojnaStanica : SvemirskaStanica
    {
        public virtual IList<SpisakOruzja> Oruzja { get; set; }
        public VojnaStanica()
        {
            Oruzja = new List<SpisakOruzja>();
        }
    }
}
