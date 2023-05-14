using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class Savez
    {
        public virtual string Naziv { get; set; }
        public virtual DateTime DatumFormiranja { get; set; }
        public virtual Savez SavezDeo { get; set; }
        public virtual IList<Savez> Savezi{ get; set; }
        public virtual IList<Igrac> Igraci { get; set; }
        public virtual Posada PosadaDeo{ get; set; }
        public Savez ()
        {
            Igraci = new List<Igrac> ();
            Savezi = new List<Savez> ();
        }
    }
}
