using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace le_pendu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random genereNb = new Random();
            string[] tabMot = { "chien", "porte", "boule", "wagon", "xenon", "poule", "vingt", "cenne", "carte", "somme", };
            int choixMot = genereNb.Next(tabMot.Length);
            int cpt = 0;
            
            bool finJeux = false;
            string mot = tabMot[choixMot];
            char[] tabLettre = new char[mot.Length];
            for (int i = 0; i < mot.Length; i++)
            {
                tabLettre[i] = '_';
            }

                Console.WriteLine("bienvenue sur le jeux du pendu veuillez saisir une lettre , si la lettre que vous avez choisis  corespond a une des lettre du mot generer elle changeras de place avec les tirait sinon une erreur s'afficheras, apres 5 erreur le jeux se terminera et vous aurez perdu. Bonne chance!");
                
            while(finJeux==false)
            {
              
                
                
                Console.WriteLine("votre progressions dans le mot ");
                for (int i=0; i<tabLettre.Length;i++)
                {
                     Console.Write( tabLettre[i] + " " );
                }
                Console.WriteLine("");

                Console.WriteLine("entez une lettre");
                string  choix = "";

                choix = Console.ReadLine();
                char lettre = choix[0];
                bool lettreTrouver = false;

                for (int i = 0; i < mot.Length; i++)
                {
                    if (mot[i] == lettre)
                    {
                        tabLettre[i] = lettre;
                        lettreTrouver = true;
                    }
                }   
                if(lettreTrouver==false)
                {
                    Console.WriteLine("la lettre choisis n'est pas dans le mot");
                    cpt = cpt + 1;
                }
                
                if(cpt==5)
                {
                    Console.WriteLine("vous avez atteind 5 erreur vous avez perdu");
                    finJeux = true;

                }

                bool partieGagne = true;
                for (int i=0;i<mot.Length;i++)
                {
                    if (tabLettre[i] == '_')
                    {
                        partieGagne = false;
                    }
                    
                }

                if(partieGagne)
                {
                    finJeux = true;
                    Console.WriteLine("bravo vous avez gagner!");
                }
               
            }

            Console.WriteLine("Fin du jeu");
            Console.ReadKey();
        }
    }
}
