using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class Kvadrant
    {
        public virtual int RedniBroj{ get; protected set; }
        public virtual double ProcenjeniPrecnik { get; set; }
        public virtual Galaksija GalaksijaDeo{ get; set; }
    }
}
