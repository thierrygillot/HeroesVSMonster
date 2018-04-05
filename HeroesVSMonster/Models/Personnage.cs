using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    class Personnage
    {
        //att
        public string Nom { get; set; }
        public int Endurance { get; private set; }
        public int Force { get; private set; }
        public int PointsDeVie { get; set; }
        public bool EstMort;
        De de = new Models.De();

        //const
        public Personnage()
        {
            Endurance = InitChar();
            Force = InitChar();
            PointsDeVie = 20;
            
        }
        public Personnage(string nom)
        {
            Nom = nom;
            Endurance = InitChar();
            Force = InitChar();
            PointsDeVie = 20;
        }

       

        //renvoi un int initialiant les caractéristiques
        
        public int InitChar()
        {
            
            int[] tab = new int[4];
            for (int i = 0; i < tab.Length; i++)
            {

                tab[i] = de.lancer6Faces();
            }
            Array.Sort<int>(tab);
            Array.Reverse(tab);
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
               sum = sum + tab[i];
            }
            return sum;
        }

        //renvoi un int correspondant à la frappe
        public int Frappe(Personnage personnage)
        {

            De de = new Models.De();
            return de.lancer4Faces();
            

        }

      

       
    }
}