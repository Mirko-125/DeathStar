using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class PrirodniSatelit : Satelit
    {
        public virtual int Precnik { get; set; }
        public virtual bool? Naseobine { get; set; }
        public PrirodniSatelit() 
        {
            
        }
    }
}
