using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar_new.Entiteti
{
    internal class Planeta
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set;}
        public virtual string GlavniGrad { get; set; }
        public virtual Int64 BrojStanovnika { get; set; }
        public virtual string DominantnaRasa { get; set; }
        public virtual string DrustvenoUredjenje { get; set; }
        public virtual string ImeZvezdanogSistema { get; set; }
        public virtual string TipZvezdanogSistema { get; set; }
        public virtual int X { get; set; }
        public virtual int Y { get; set; }
        public virtual int Z { get; set; }
        public virtual int Berilijum { get; set; }
        public virtual int Trilijum { get; set; }
        public virtual int Plutonijum { get; set; }
        public virtual DateTime DatumKolonizacije { get; set; }
        public virtual IList<GradoviPlanete> Gradovi { get; set; }
        public virtual Posada PosadaOsvajaca { get; set; }
        public virtual IList<Osvajanje> IstorijaOsvajanja { get; set; }
        public virtual Igrac IgracMaticna { get; set; }
        public virtual Igrac IgracKojiJePoseduje { get; set; }
        public virtual Galaksija UGalaksiji { get; set; }
        public virtual IList<PrirodniSatelit> Sateliti { get; set; }
        public virtual IList<SvemirskaStanica> Stanice { get; set; }
        public virtual IList<Brod> Brodovi { get; set; }
        public virtual IList<Pojava> Pojave { get; set; }
        public Planeta()
        {
            Gradovi= new List<GradoviPlanete>();    
            Sateliti = new List<PrirodniSatelit>();
            Stanice = new List<SvemirskaStanica>();
            IstorijaOsvajanja = new List<Osvajanje>();
            Pojave = new List<Pojava>();
            Brodovi = new List<Brod>();
        }
    }
}
