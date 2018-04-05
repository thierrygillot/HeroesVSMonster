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

        public Hero()
        {

        }

        public Hero(string nom)
            :base (nom)
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
