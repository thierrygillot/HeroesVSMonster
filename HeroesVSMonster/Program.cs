using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonster.Models;

namespace HeroesVSMonster
{
    class Program
    {
        static void Main(string[] args)
        {

            //caracteristiques
            De d = new De();
            int end = d.LancerDe6Faces();
            int force = d.LancerDe6Faces();

            //Perso
            Humain h = new Humain("Moi", end, force, 100);
            Console.WriteLine(h.ToString());

            Console.Read();


        }
    }
}
