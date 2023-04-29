using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class Osvajanje
    {
        public virtual int Id { get; protected set; }
        public virtual DateOnly DatumOsvajanja { get; set; }
        public virtual Posada PosadaOsvaja{ get; set; }
        public virtual Igrac PrethodniVlasnik { get; set; }
        public virtual Planeta PlanetaOsvojena { get; set; }
    }
}
