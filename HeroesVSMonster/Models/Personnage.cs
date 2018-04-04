using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    class Personnage
    {
        public string Nom { get; set; }
        public int Endurance { get; private set; }
        public int Force { get; private set; }
        public int PointsDeVie { get; set; }
        public int Or { get; set; }
        public bool EstMort;

        public Personnage()
        {

        }

        public Personnage(int endurance, int force, int pointsDevie)
        {
            Endurance = endurance;
            Force = force;
            PointsDeVie = pointsDevie;
        }

        public Personnage(string nom, int endurance,int force, int pointsDevie)
        {
            Nom = nom;
            Endurance = endurance;
            Force = force;
            PointsDeVie = pointsDevie;
        }

        public int Frappe()
        {
            De de = new De();
            return de.LancerDe4Faces();
        }

      



        public override string ToString()
        {
            return $"{this.GetType().Name} {Nom} possède {Force} de Force, {Endurance} d'Endurance, {PointsDeVie} de points de vie et {Or} d'or.";
        }
    }
}
