using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RushHour
{
    abstract class Voiture
    {
        // Donne la taille de la voiture (2 ou 3), modifiable uniquement dans le constructeur
        public int Taille  { get; private set; }

        // Donne la couleur de la voiture, choisi dans l'énumération de couleurs. Permettra l'affichage de la voiture. Modifiable uniquement dans le constructeur
        public string Couleur { get; private set; }

        // X et Y sont les coordonnées du points le plus en haut/ à gauche de la voiture
        public int X { get; protected set; }
        public int Y { get; protected  set; }

        //Id donné à la voitur, servira à la nommer plus facilement ou à récupérer facilement sa couleur
        public int Id { get; private set; }

        // variable static donnant le nombre de voitures déjà crées afin de renseigner l'id de la voiture.
        static private int _nbVoitures = 0;


        //private static ConsoleColor[] _couleurs = { ConsoleColor.DarkBlue, ConsoleColor.DarkGreen, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.Red, ConsoleColor.Cyan, ConsoleColor.Green, ConsoleColor.Blue, ConsoleColor.DarkYellow, ConsoleColor.DarkMagenta };
        public Voiture(int taille, int x, int y)
        {
            _nbVoitures += 1;
            Id = _nbVoitures;
            Taille = taille;
            X = x;
            Y = y;
            
        }

        //methode qui sera un deplacement horizontal ou vertical selon la classe fille
        abstract public void SeDeplacer(int direction);

        // methode permettant de donner les caractéristiques de la voiture pour les tests

        public override string ToString()
        {
            return "Je suis la voiture numero "+Id+"\nTaille : "+Taille+"\n Position : "+X+" ; "+Y;
        }

    }
}
