﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DeathStar.Entiteti
{
    internal class Pojava
    {
        public virtual string Naziv { get; set; }
        public virtual DateOnly? DatumFormiranja { get; set; }
        public virtual string TipPojave { get; set; }
        public virtual bool IzazivaLiOpasnost { get; set; }
        public virtual Planeta PlanetaDeo { get; set; }
    }
}
