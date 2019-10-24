using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trouver_le_nombre
{
    class Program
    {
        static void AfficherMenu()
        {
            Console.WriteLine(" bienvenue sur 'trouver le nombre' appuyer sur 1 pour jouer en mode facile , sur 2 pour jouer en mode moyen et sur 3 pour jouer en mode difficile!");
        }
        static void modeFacile()
        {
            Random nombre = new Random();
            int nombreGenerer;
            nombreGenerer = nombre.Next(0, 101);
            bool finManche = false;

            while (finManche == false)
            {
                Console.WriteLine("vous avez choisis le mode facile, veuiller choisir un nombre");

                int nombrechoisie = 0;

                Convert.ToInt32(Console.ReadLine());

                if (nombrechoisie < nombreGenerer)
                {
                    Console.WriteLine("le nombre choisis est plus petit que le nombre a trouver essayer a nouveaux! ");
                }
                if (nombrechoisie == nombreGenerer)
                {
                    Console.WriteLine("bien jouer vous avez trouver le nombre !");
                    finManche = true;
                }
                if (nombrechoisie > nombreGenerer + 5 || nombrechoisie < nombreGenerer - 5)
                {
                    Console.WriteLine("vous etes proche du nombre a trouver");

                }
                else if (nombrechoisie > nombreGenerer)
                {
                    Console.WriteLine("le nombre choisis est plus grand que le nombre a trouver essayer a nouveaux! ");
                }
            }


        }
        static void modeMoyen()
        {
            Random nombre = new Random();
            int nombreGenerer;
            nombreGenerer = nombre.Next(0, 1001);
            bool finManche = false;

            while (finManche == false)

            {
                Console.WriteLine("vous avez choisis le mode moyen, veuiller choisir un nombre");

                int nombrechoisie = 0;

                Convert.ToInt32(Console.ReadLine());

                if (nombrechoisie < nombreGenerer)
                {
                    Console.WriteLine("le nombre choisis est plus petit que le nombre a trouver essayer a nouveaux! ");
                }
                if (nombrechoisie == nombreGenerer)
                {
                    Console.WriteLine("bien jouer vous avez trouver le nombre !");
                    finManche = true;
                }
                if (nombrechoisie > nombreGenerer + 5 || nombrechoisie < nombreGenerer - 5)
                {
                    Console.WriteLine("vous etes proche du nombre a trouver");
                }
                else if (nombrechoisie > nombreGenerer)
                {
                    Console.WriteLine("le nombre choisis est plus grand que le nombre a trouver essayer a nouveaux! ");
                }
            }
        }
        static void modeDifficile()
        {
            Random nombre = new Random();
            int nombreGenerer;
            nombreGenerer = nombre.Next(0, 10001);
            bool finManche = false;

            while (finManche == false)

            {
                Console.WriteLine("vous avez choisis le mode Difficile, veuiller choisir un nombre");

                int nombrechoisie = 0;

                Convert.ToInt32(Console.ReadLine());

                if (nombrechoisie < nombreGenerer)
                {
                    Console.WriteLine("le nombre choisis est plus petit que le nombre a trouver essayer a nouveaux! ");
                }
                if (nombrechoisie == nombreGenerer)
                {
                    Console.WriteLine("bien jouer vous avez trouver le nombre !");
                    finManche = true;

                }
                if (nombrechoisie > nombreGenerer + 5 || nombrechoisie < nombreGenerer - 5)
                {
                    Console.WriteLine("vous etes proche du nombre a trouver");
                }
                else if (nombrechoisie > nombreGenerer)
                {
                    Console.WriteLine("le nombre choisis est plus grand que le nombre a trouver essayer a nouveaux! ");
                }
            }
        }

        static void Main(string[] args)
        {

            int choix = 0;

            AfficherMenu();
            choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1: modeFacile(); break;
                case 2: modeMoyen(); break;
                case 3: modeDifficile(); break;
            }

        }
    }
}
