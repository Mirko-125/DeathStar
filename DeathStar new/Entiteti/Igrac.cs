using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class Igrac
    {
        public virtual string Username { get; protected set; }
        public virtual string Ime { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string Pol { get; set; }
        public virtual string Drzava { get; set; }
        public virtual DateTime DatumOtvaranjaNaloga { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Email { get; set; }
        public virtual string URLAvatara { get; set; }
        public virtual string Opis { get; set; }

        public virtual Posada DeoPosade { get; set; }
        public virtual Planeta MaticnaPlaneta { get; set; }
        public virtual IList<Planeta> PosedujePlanete { get; set; }
        public virtual Savez SavezKomePripada { get; set; }
        public Igrac()
        {
            PosedujePlanete = new List<Planeta>();
        }
    }
}
