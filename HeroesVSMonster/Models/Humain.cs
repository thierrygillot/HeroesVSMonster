using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    class Humain : Hero
    {
        public Humain(string nom, int endurance, int force, int pointsDevie)
            :base (nom,endurance,force,pointsDevie)
        {
            
        }
    }
}
