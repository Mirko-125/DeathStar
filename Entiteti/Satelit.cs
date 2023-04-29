using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal abstract class Satelit
    {
        public virtual string Naziv { get; set; }
        public virtual int Udaljenost { get; set; }

        public virtual Planeta KruziOkoPlanete { get; set; }
        public Satelit()
        {

        }
    }
}
