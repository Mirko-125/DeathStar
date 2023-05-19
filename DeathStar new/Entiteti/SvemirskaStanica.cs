using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar_new.Entiteti
{
    internal abstract class SvemirskaStanica 
    {
        public virtual int Id { get; protected set; }
        public virtual string Naziv { get; set; }
        public virtual int Udaljenost { get; set; }
        public virtual Planeta DeoPlanete { get; set; }
        public virtual int BrojLjudi { get; set; }
        public virtual int Velicina { get; set; }
       
        public SvemirskaStanica()
        {

        }
    }
}
