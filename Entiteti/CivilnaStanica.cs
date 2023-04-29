using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class CivilnaStanica : SvemirskaStanica
    {
        public virtual string? Svrha { get; set; }
        public CivilnaStanica() 
        {
        
        }
    }
}
