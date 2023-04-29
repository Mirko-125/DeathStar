using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class Galaksija
    {
        public virtual string Naziv { get; set; }
        public virtual int? ProcenjenBrojZvezda{ get; set; }
        public virtual int? ProcenjenBrojPLaneta{ get; set; }
        public virtual string? DominatnaRasa { get; set; }
        public virtual IList<Planeta> Planete{ get; set; }
        public virtual IList<Kvadrant> Kvadranti{ get; set; }

        public Galaksija()
        {
            Planete = new List<Planeta>();
            Kvadranti = new List<Kvadrant>();
        }
    }
}


