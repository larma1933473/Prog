using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise1_lab3
{
    class Program
    {
        static int[]  GenererTabLettre(string message)
        {
            string messageMin = message.ToLower();
            int[] tabLettre = new int[26];


            for (int i = 0; i < messageMin.Length; i++)
            {
                int indice = (int)message[i] - 97;
                if (indice >= 0 && indice < 26)
                    tabLettre[indice]++;
            }
            return tabLettre;
        }
        static void AfficherNombreMot(string message)
        {
            string [] tab = message.Split(' ');
            Console.WriteLine("" + tab.Length);

        }
        static void AfficherNbLettre(string message)
        {
            int[] tabLettre = GenererTabLettre(message);

            for(var i=0;i<tabLettre.Length;i++)
            { 
                Console.WriteLine("le nombre de " + (char)(i + 97) + " est de " + tabLettre[i]);
            }
        }
        static void AfficherLettreSouvant(string message)
        {
            int grandNb = 0;
            int position = 0;
            int[] tabLettre = GenererTabLettre(message);

            for (int i = 1; i < tabLettre.Length; i++)
            {
                if (grandNb < tabLettre[i])
                {
                    grandNb = tabLettre[i];
                    position = i;
                }
            }
            Console.WriteLine("le nombre de lettre le plus élever est la lettre a" + (char)(position + 97) + " avec le nombre de lettre :" + tabLettre[position]);
        }
        static void EncoderMessage(string message)
        {
            string messageMin = message.ToLower();
            string newMessage = "";


            for (int i = 0; i < messageMin.Length; i++)
            {
                int indice = (int)message[i];
                newMessage += (char)(indice + 2);
            }
            Console.WriteLine("" + newMessage);
            

        }
       
        static void afficherMenu()
        {
            Console.WriteLine(" 1 - Permet d’afficher la longueur de la chaîne de caractères");

            Console.WriteLine(" 2-Permet de déterminer si la phrase contient «octopus»");

            Console.WriteLine(" 3 - Permet de connaître la position du premier ‘e’ (indice, IndexOf)");

            Console.WriteLine(" 4 - Permet d’afficher une sous phrase");
        }
        static void Main(string[] args)
        {
            string maPhrase = "luffy c'est le plus meilleur";

            afficherMenu();

            int choix = 0;

            choix = Convert.ToInt32(Console.ReadLine());
            switch (choix)
            {
                case 1: AfficherNombreMot(maPhrase); break;
                case 2: AfficherNbLettre(maPhrase); break;
                case 3: AfficherLettreSouvant(maPhrase); break;
                case 4: EncoderMessage(maPhrase); break;
            
            }

            Console.ReadKey();
        }
    }
}
