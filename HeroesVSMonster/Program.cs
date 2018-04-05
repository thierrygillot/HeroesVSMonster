using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonster.Models;
using J = HeroesVSMonster.Core;

namespace HeroesVSMonster
{
    class Program
    {
        static void Main(string[] args)
        {
            //J.Jeu j = new J.Jeu();
            Personnage o = new Orque();
            Console.WriteLine(o.ToString());

            Console.Read();

        }
    }
}
