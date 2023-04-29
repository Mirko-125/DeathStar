using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    enum tipBroda { Razarac, Krstarica, Fregata };
    internal abstract class Brod
    {
        public virtual int JedinstveniBroj { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual double MaxWarpBrzina { get; set; }
        public virtual Planeta PlanetaKonstrukcije { get; set; }
        public virtual Posada PosadaKojaPoseduje { get; set; }
        public Brod()
        {

        }
    }

    internal class BorbeniBrod : Brod
    {
        public virtual bool FotonskoTorpedo { get; set; }
        public virtual int BrojLaserskihTopova { get; set; }
        public virtual tipBroda Tip { get; set; }
    }
    internal class TransportniBrod : Brod
    {
        public virtual bool ZastitnaOtplata { get; set; }
        public virtual double Nosivost { get; set; }
    }
}