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
            Console.WriteLine("Bienvenue dans la forêt de Shorewood");
            Console.WriteLine("quel type de Personnage voulez-vous être : ");
            Console.WriteLine("h.Humain");
            Console.WriteLine("n.Nain");
            ConsoleKeyInfo key = Console.ReadKey();
            Personnage p = new Personnage();
            string nomPersonnage;

            switch (key.KeyChar)
            {
                case 'h':
                    Console.Write("Vous avez choisit d'être un humain, comment voulez vous l'appeler: ");
                    nomPersonnage = Console.ReadLine();
                    p = new Humain(nomPersonnage);
                    break;
                case 'n':
                    Console.Write("Vous avez choisit d'être un Nain, comment voulez vous l'appeler: ");
                    nomPersonnage = Console.ReadLine();
                    p = new Nain(nomPersonnage);
                    break;
            }

            Console.WriteLine(p.ToString());
            

            
            






            Console.Read();


            
           
          


        }
    }
}
