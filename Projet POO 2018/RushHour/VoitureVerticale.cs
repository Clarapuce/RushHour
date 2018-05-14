using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RushHour
{
    class VoitureVerticale : Voiture
    {
        public VoitureVerticale(int taille, int x, int y) : base(taille,x,y)
        {
        }
        public override void SeDeplacer(int direction)
        {
            Y += direction;
            /* 
             * if(direction<0)
             * {
             * plateau.Occuper(id, X, Y)
             * plateau.Liberer(id, X+3,Y)
             *}
             * else
             * {
             * plateau.Liberer(id,X,Y)
             * plateau.Occuper(id,X+3,Y)
             * }
            
            */
            // plateau.Bouger(Id, direction)
        }
    }
}
