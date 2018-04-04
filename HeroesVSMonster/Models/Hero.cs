using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    class Hero : Personnage
    {
        public Dictionary<string, int> sacAdos;

        public Hero(string nom, int endurance, int force, int pointsDevie)
            :base (nom,endurance,force,pointsDevie)
        {

        }


        public int Depouiller()
        {
            return 0;
        }

        public int SeReposer()
        {
            return 0;
        }
        


    }
}
