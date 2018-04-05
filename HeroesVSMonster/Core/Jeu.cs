using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonster.Models;
using HeroesVSMonster.utils;
using static HeroesVSMonster.utils.Tools;

namespace HeroesVSMonster.Core
{
    class Jeu
    {
        private static int x = 5;
        private static int y = 5;

        public Jeu()
        {
            Personnage p = new Personnage();
            Start();
        }

        //Initialisation Affichage 
        private void Init()
        {
            Animated(5, y++, 5, $"╔════════════════════════════════════════╗");
            Animated(5, y++, 5, $"║  Bienvenue dans la Foret de Shorewood  ║");
            Animated(5, y++, 5, $"╚════════════════════════════════════════╝");
            Continue(5, y, 5);
        }

        private ConsoleKey Menu(bool byPass = false)
        {
            Console.Clear();
            x = 5;
            y = 5;

            Animated(x, y++, 5, $"╔═════════════════════════════════════════════════╗");
            Animated(x, y++, 5, $"║         Choisissez un type de personnage        ║");
            Animated(x, y++, 5, $"╠═════════════════════════════════════════════════╣");
            Animated(x, y++, 5, $"║ 1. Humain                                       ║");
            Animated(x, y++, 5, $"║ 2. Nain                                         ║");
            Animated(x, y++, 5, $"╚═════════════════════════════════════════════════╝");

            if (!byPass)
            {
                Animated(x, y++, 5, "Faites un choix : ");
                ConsoleKey response = Console.ReadKey().Key;
                return response;
            }

            return ConsoleKey.A;
        }

        private Personnage CreerHumain()
        {
            Humain newHumain = new Humain();

            CreerHumainDonnées(newHumain);
            Animated(x, y++, 5, $"Bienvenue {newHumain.Nom}");
            Continue(x, y, 5);
            return newHumain;
        }

        private void CreerHumainDonnées(Personnage p)
        {
            Console.Clear();
            x = 5;
            y = 5;

            string type = p.GetType().Name;

            Animated(x, y++, 5, $"╔═══════════════════════╗");
            Animated(x, y++, 5, $"║ Creation de l'{type.PadLeft(5)}   ║");
            Animated(x, y++, 5, $"╚═══════════════════════╝");
            p.Nom = ReadString(x, y++, 5, $"Quel est le nom de votre {type} : ");
           
        }

        private void Start()
        {
            Init();
            Menu();




        }
    }
}

