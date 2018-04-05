using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    
    class De
    {
        Random rnd = new Random();

        //const
        public De()
        {

        }
        
        //lancer De 6 faces
        public int lancer6Faces()
        {
            return rnd.Next(1, 7);
        }

        //lancer des 4 faces
        public int lancer4Faces()
        {
            return rnd.Next(1, 5);
        }
            
    }
}
