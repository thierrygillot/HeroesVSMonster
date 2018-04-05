using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    class Monstre : Personnage
    {
        public int Or { get; set; }
        public int cuivre { get; set; }
        public Monstre()
        {

        }
        public override string ToString()
        {
            return $"{this.GetType().Name} possède {Force} de Force, {Endurance} d'Endurance, {PointsDeVie} de points de vie et {Or} d'or et {cuivre} de cuivre.";
        }
    }
}
