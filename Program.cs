using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matisdestoiles
{
    class Program
    {
        static void AfficherLongueur(string message)
        {
            Console.WriteLine("" + message.Length );

        }
        static void octopus(string message)
        {
            if (message.Contains("octopus") == true)
            {
                Console.WriteLine("la phrase conteint le mot octopus" );
            }
            else
            {
                Console.WriteLine("la phrase ne contien pas le mot octopus");
            }
        }
        static void premierE(string message)
        {
            int premierE = message.IndexOf('e');
        }
        static void sousPhrase(string message)
        {
            int premierEspace = message.IndexOf(' ');
            string premierMot = message.Substring(0, premierEspace);
            Console.WriteLine("" + premierMot);

        }
        static void majuscule(string message)
        {
            String messageEnMajuscule = message.ToUpper();
            Console.WriteLine(" "+message);
        }
        static void minuscule(string message)
        {
            String messageEnMajuscule = message.ToUpper();
            Console.WriteLine(" "+ message);
        }
        static void quitter()
        {
            Console.WriteLine("  Termine le programme");
        }
        static void afficherMenu()
        {
            Console.WriteLine(" 1 - Permet d’afficher la longueur de la chaîne de caractères");

            Console.WriteLine(" 2-Permet de déterminer si la phrase contient «octopus»");

            Console.WriteLine(" 3 - Permet de connaître la position du premier ‘e’ (indice, IndexOf)");

            Console.WriteLine(" 4 - Permet d’afficher une sous phrase");

            Console.WriteLine(" 5-Transforme la chaîneen majuscule puis l’affiche");

            Console.WriteLine(" 6 - Transforme la chaîne en minuscule puis l’affiche");

            Console.WriteLine(" 7 - Termine le programme");
        }
        static void Main(string[] args)
        {
            string maPhrase = "luffy c'est le plus meilleur";

            afficherMenu();

            int choix = 0;

            choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1: AfficherLongueur(maPhrase); break;
                case 2: octopus(maPhrase); break;
                case 3: premierE(maPhrase); break;
                case 4: sousPhrase(maPhrase); break;
                case 5: majuscule(maPhrase); break;
                case 6: minuscule(maPhrase); break;
                case 7: quitter(); break;
            }

        }
    }
}
