using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_to
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] tabCase = new char[9];
            bool finPartie = false;
            int joueur = 1;

            for(int i = 0; i < tabCase.Length; i++)
            {
                tabCase[i] = '-';
            }

            while(finPartie==false)
            {
                
                bool tours = false;

                while (tours == false)
                {
                    Console.WriteLine(" " + tabCase[0] + " " + tabCase[1].ToString() + " " + tabCase[2].ToString() + " \n" + tabCase[3].ToString() + " " + tabCase[4].ToString() + " " + tabCase[5].ToString() + " \n" + tabCase[6].ToString() + " " + tabCase[7].ToString() + " " + tabCase[8].ToString());
                    int choixCase = 0;

                    choixCase = Convert.ToInt32(Console.ReadLine());

               
                    if (tabCase[choixCase] == '-')
                    {
                        if (joueur == 1)
                        {
                            tabCase[choixCase] = 'X';
                            tours = true;
                        }
                        else if(joueur==2)
                        {
                            tabCase[choixCase] = 'O';
                            tours = true;
                        }
                    }
                    else
                    {
                        Console.WriteLine("veuiller rechoisir une case n'ayant rien a l'intérieur");
                    }

                }
                if(tabCase[0]==tabCase[1]&&tabCase[0]==tabCase[2])
                {
                    if(tabCase[0] != '-' )
                    {
                        Console.WriteLine("bravo tu as gagner la partie");
                        finPartie = true;
                    }
                }
                else if(tabCase[3] == tabCase[4] && tabCase[3] == tabCase[5])
                {
                    if (tabCase[4] != '-')
                    {
                        Console.WriteLine("bravo tu as gagner la partie");
                        finPartie = true;
                    }
                }
                else if(tabCase[6] == tabCase[7] && tabCase[6] == tabCase[8])
                {
                    if (tabCase[7] != '-')
                    {
                        Console.WriteLine("bravo tu as gagner la partie");
                        finPartie = true;
                    }
                }
                else if(tabCase[0] == tabCase[3] && tabCase[0] == tabCase[6])
                {
                    if (tabCase[0] != '-')
                    {
                        Console.WriteLine("bravo tu as gagner la partie");
                        finPartie = true;
                    }
                }
                else if(tabCase[2] == tabCase[4] && tabCase[2] == tabCase[7])
                {
                    if (tabCase[2] != '-')
                    {
                        Console.WriteLine("bravo tu as gagner la partie");
                        finPartie = true;
                    }
                }
                else if(tabCase[2] == tabCase[5] && tabCase[2] == tabCase[8])
                {
                    if (tabCase[3] != '-')
                    {
                        Console.WriteLine("bravo tu as gagner la partie");
                        finPartie = true;
                    }
                }
                else if(tabCase[0] == tabCase[4] && tabCase[0] == tabCase[8])
                {
                    if (tabCase[0] != '-')
                    {
                        Console.WriteLine("bravo tu as gagner la partie");
                        finPartie = true;
                    }
                }
                else if (tabCase[2] == tabCase[4] && tabCase[2] == tabCase[6])
                {
                    if (tabCase[3] != '-')
                    {
                        Console.WriteLine("bravo tu as gagner la partie");
                        finPartie = true;
                    }
                }

                bool egalite = true;
                for(int i=0;i<tabCase.Length;i++)
                {
                    if (tabCase[i] == '-')
                    {
                        egalite = false;
                    } 
                }

                if (egalite == true)
                {
                    finPartie = true;
                }

                if (joueur==1)
                {
                    joueur = 2;
                    
                }
                else
                {
                    joueur = 1;
                    
                }
            }
        }
    }
}
