using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar_new.Entiteti
{
    internal class PrirodniSatelit 
    {
        public virtual string Naziv { get; set; }
        public virtual int Udaljenost { get; set; }
        public virtual Planeta KruziOkoPlanete { get; set; }
        public virtual int Precnik { get; set; }
        public virtual bool Naseobine { get; set; }
    }
}
