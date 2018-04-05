using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HeroesVSMonster.Interfaces;

namespace HeroesVSMonster.Models
{
    class Hero : Personnage, IOr, ICuir
    {

        

        public Hero()
        {

        }

        public Hero(string nom)
            :base (nom)
        {

        }
        public int Cuir { get;  set;}
        public int Or { get; set; }
        
           

        public int Depouiller()
        {
            return 0;
        }

        //Restaure les points de vie
        public void SeReposer()
        {
            PointsDeVie = 20;

        }

        public override string ToString()
        {
            return $"{this.GetType().Name} {Nom} possède {Force} de Force, {Endurance} d'Endurance, {PointsDeVie} de points de vie et {Or} d'or et {0} de cuivre.";
        }

    }
}
