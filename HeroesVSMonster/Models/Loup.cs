using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonster.Interfaces;

namespace HeroesVSMonster.Models
{
    class Loup:Monstre, ICuir
    {
        public int Cuir { get; set; }
        public Loup()
      
        {

        }
    }
}
