using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVSMonster.Models
{
    
    class De
    {

        public int LancerDe6Faces()
        {
            Random rnd = new Random();
            float[] tab = new float[4];
            for (int i = 0; i < 4; i++)
            {
                float x = rnd.Next(1, 7);
                tab[i] = x;

            }
            tab.OrderByDescending(n => n);
            float sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum = sum + tab[i];
            }
            float result = (sum / 18) * 100;
            return (int)result;
        }

        public int LancerDe4Faces()
        {
            Random rnd = new Random();
            float[] tab = new float[4];
            for (int i = 0; i < 4; i++)
            {
                float x = rnd.Next(1, 4);
                tab[i] = x;

            }
            tab.OrderByDescending(n => n);
            float sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum = sum + tab[i];
            }
            float result = (sum / 18) * 100;
            return (int)result;
        }










    }
}
