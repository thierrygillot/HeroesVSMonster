using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonster.Interfaces;

namespace HeroesVSMonster.Models
{
    class Dragonnet:Personnage, IOr, ICuir
    {
        public int Cuir { get; set; }
        public int Or { get; set; }

        public Dragonnet()
        {
            
        }
    }

    
}
