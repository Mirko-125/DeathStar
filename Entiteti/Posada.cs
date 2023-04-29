using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class Posada
    {
        public virtual int Id { get; protected set; }
        public virtual Igrac? Igrac { get; set; }
        public virtual Savez? Savez { get; set; }
        public virtual IList<Brod> Brodovi { get; set; }
        public virtual IList<Osvajanje> Osvajanja{ get; set; }
        public Posada()
        {
            Brodovi = new List<Brod>();
            Osvajanja= new List<Osvajanje>();
        }
    }
}
