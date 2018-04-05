using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonster.Interfaces;

namespace HeroesVSMonster.Models
{
    class Orque : Monstre, IOr
    {
        public int Or { get; set; }
        Random rnd = new Random();
        public Orque()
        {
            Or = rnd.Next(1,11);
        }
    }
}
