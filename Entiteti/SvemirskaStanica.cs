using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal abstract class SvemirskaStanica : Satelit
    {
        public virtual int? BrojLjudi { get; set; }
        public virtual int Velicina { get; set; }
       
        public SvemirskaStanica()
        {

        }
    }
}
