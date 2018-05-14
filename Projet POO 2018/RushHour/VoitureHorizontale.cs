using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RushHour
{
    class VoitureHorizontale : Voiture
    {
        public VoitureHorizontale(int taille, int x, int y) : base(taille,x,y)
        {
        }

        public override void SeDeplacer(int direction)
        {
            X += direction;
            /* 
             * if(direction<0)
             * {
             * plateau.Occuper(id, X, Y)
             * plateau.Liberer(id, X+taille,Y)
             *}
             * else
             * {
             * plateau.Liberer(id,X,Y)
             * plateau.Occuper(id,X+taille,Y)
             * }
            
            */
        }
    }
}
