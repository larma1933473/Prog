using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Projet_Jé
{
    class Program
    {
        static void GameOverDette()
        {
            Console.WriteLine("\nGameover, vous etes trop endetter.");
        }
        static void GameOverMil(ref int compteur)
        {
            Console.WriteLine("\nBravo, vous êtes devenu un millionaire en " + compteur + " jours");
        }
        static void Intro()
        {
            Console.WriteLine("\nBienvenue à Video Games Empire Tycoon. Le but du jeu est simple. Vous devez faire le plus d'argent possible. Vous gagner lorsque vous avez 1 millions$.\nVous perdez si vous êtes dans le 1 millions de dollars en dettes. Bonne chance!\n");
            Console.WriteLine("A chaque 15 jours, un évènement se produit. Des évènements ayant de plus grandes récompenses ou conséquences seront ajoutés au fur et a mesure que vous augmenter=z de niveau.\nVous augmenter de niveau selon votre montant total d'argent.\n");
            Console.WriteLine("Pour accéder au menu d'améliorations, appuyez sur < a >. (Appuyer plusieurs fois si sa ne marche pas).\n");
            Console.WriteLine("Pour commencer la partie, appuyer sur n'importe touche.\n");
            Console.ReadKey();
            Console.Clear();
        }
        public struct situationChance
        {
            public string situation;
            public int cout;
            public int niveaux;

            public situationChance(string _situation, int _cout, int _niveaux) : this()
            {
                situation = _situation;
                cout = _cout;
                niveaux = _niveaux;

            }
        }

        static int niveaux = 1;




        static situationChance[] CreerTableauSituation()
        {
            Console.Clear();
            situationChance[] tabSituation = new situationChance[25];
            tabSituation[0] = new situationChance("\nOh mince! votre ordinateur de travail a cessser de fonctionner vous le tirez par la fenetre ... vous devez débourser 3 000$", -2100, 2);
            tabSituation[1] = new situationChance("\nquelqu'un vous poursuit en cours pour plagias sur un des jeux que vous avez créer... débourser 6 789$ ", -6789, 3);
            tabSituation[2] = new situationChance("\nsix bouleaux,ma maison est en feu ...payer 40 000$ ", -40000, 5);
            tabSituation[3] = new situationChance("\ndes voyous persent vos pneux d'auto payer 10 000$ pour les frais de remorquage,de réparations et d'obtention de nouveaux pneux ", -10000, 3);
            tabSituation[4] = new situationChance("\nvous passez une soiré avec vinssou au casino qui vous a couter tres cher... payer 90 000$ ", -90000, 6);
            tabSituation[5] = new situationChance("\nc'est dur la vie hein? la police s'en caliss ...payer 80 0000$ ", -80000, 6);
            tabSituation[6] = new situationChance("\nun hacker vol vos donner et vous demende de payer une rancon de 8000$ pour les récupérer...payer 8 000$ ", -8000, 3);
            tabSituation[7] = new situationChance("\nvous avez perdu le contenue monetaire de votre portefeuille...vous perdez 160$ ", -160, 1);
            tabSituation[8] = new situationChance("\nvous acheter un avion pour le fun ...payer 450 000$ ", -450000, 6);
            tabSituation[9] = new situationChance("\ndans la ferme a maturin il y a des animaux payer payer comme des bon grelots... payer 50 000$ ", -50000, 5);
            tabSituation[10] = new situationChance("\nle dalai lama vient vous rendre visite et vous transforme en boudiste... vous lui donnez 30 000$ ", -30000, 4);
            tabSituation[11] = new situationChance("\nc'est l'heure de dire au revoir ! c'est l'heure de dire au revoir a ton argent !payer le soleil des télétubies parce qu'il a pas été payer depuis 5 ans...payer 120 000 $ ", -120000, 6);
            tabSituation[12] = new situationChance("\nVotre maman a oublié son porte-feuille sur le comptoire avant de partir au travail. Vous avez vous trouver 3 000$ ", -3000, 2);
            tabSituation[13] = new situationChance("\nUn youtubeur a fais un lets play sur un de vos jeux videos il cela a attiré de l'attention...gagner 20 000$ ", 20000, 4);
            tabSituation[14] = new situationChance("\nIGN a evaluer votre jeu avec un 9.5 / 10. Votre jeu a gagner de la popularité... gagner 15 000$ ", 25000, 4);
            tabSituation[15] = new situationChance("\nVous trouver 1$ sur le trottoir ", 1, 1);
            tabSituation[16] = new situationChance("\nVotre ami viens vous aider pour la conquete du marcher des jeux videos...gagner 3 000$ ", 3000, 2);
            tabSituation[17] = new situationChance("\nVotre prof de progammation Vinsoulier Sous-Morin vous accompagne a un casino... Bravo, vous avez gagner 10 000$ ", 10000, 3);
            tabSituation[18] = new situationChance("\nVous vous etes inscris a un give away et vous gagnez... gagner 2 000$ ", 2000, 2);
            tabSituation[19] = new situationChance("\nVous gagner a un grateux...ganger 10 000$ ", 28000, 5);
            tabSituation[20] = new situationChance("\nTVA vous accorde un interview pour un de vos jeux...ganer 25 000$ ", 25000, 5);
            tabSituation[21] = new situationChance("\nVous avez trouver 50$ dans les poches d'un vieux cotton-ouaté...gagner 50$ ", 50, 1);
            tabSituation[22] = new situationChance("\napres la pluie vient le soleil...ganger 600$", 600, 1);
            tabSituation[23] = new situationChance("\nUbisoft sort un nouveaux jeux votre taux de vente baisse...vous perdez 28 000$", -28000, 4);
            tabSituation[24] = new situationChance("\nvous passez sous une échelle... vous perdez 45 000$", -45000, 4);



            return tabSituation;
        }
        static situationChance ChoisirSituationChance(situationChance[] tabSituation, int nivJoueur)
        {
            bool niveauxChance = false;
            Random chance = new Random();
            situationChance situation = new situationChance();
            while (niveauxChance == false)
            {
                int carteChance = chance.Next(25);
                if (tabSituation[carteChance].niveaux <= nivJoueur)
                {
                    situation = tabSituation[carteChance];
                    niveauxChance = true;
                }



            }
            return situation;
        }
        public static bool shopping = false;
        static void GenererArgent()
        {
            long montantTotal = 250; // Long = plus grosse limite que int
            int montant = 0;
            int multiplicateur = 1;
            int multiplicateurSaison = 1;
            int compteur = 0;
            int compteurEvent = 0;
            int nivJoueur = 1;
            bool TaskEnd = false;



            Console.ForegroundColor = ConsoleColor.Green;
            Task.Run(() => //Une task s'effectue INDÉPENDAMMENT du Main. On peut lui mettre un Thread.Sleep sans affecter le Main, ou garder à jour des données. LORSQUE LA TASK TERMINE, TOUTE DONNÉES QU'ELLE CONTIENT SONT PERDUES.
            {
                while (TaskEnd == false)
                {
                    while (shopping)
                    {

                    }
                    Console.CursorVisible = false;
                    Console.SetCursorPosition(0, 0);
                    Console.Write("\n\n\nArgent total: " + montantTotal + "$.                                                           \n");
                    Console.WriteLine("\nJour: " + compteur);
                    montantTotal += montant * multiplicateur * multiplicateurSaison;
                    System.Threading.Thread.Sleep(1000); //En millisecondes, 1000 = 1 seconde
                    compteur++;
                    compteurEvent++;



                    if (montantTotal >= 500 && niveaux == 1)
                    {
                        niveaux++;

                        Console.WriteLine("\nvous passez au niveaux 2");


                    }
                    if (montantTotal >= 1000 && niveaux == 2)
                    {
                        niveaux++;
                        Console.WriteLine("\nvous passez au niveaux 3");

                        // montant = 0;
                    }
                    if (montantTotal >= 25000 && niveaux == 3)
                    {
                        niveaux++;
                        Console.WriteLine("\nvous passez au niveaux 4");

                        //montant = 0;
                    }
                    if (montantTotal >= 100000 && niveaux == 4)
                    {
                        Console.WriteLine("\nvous passez au niveaux 5");
                        niveaux++;
                        //montant = 0;
                    }
                    if (montantTotal >= 500000 && niveaux == 5)
                    {
                        Console.WriteLine("\nvous passez au niveaux 6");
                        niveaux++;
                        // montant = 0;
                    }


                    if (compteurEvent == 15) // a chaque 15 jour un évenement se produit
                    {

                        situationChance[] tabSituation = CreerTableauSituation();
                        situationChance situation = ChoisirSituationChance(tabSituation, nivJoueur);
                        Console.WriteLine(situation.situation);
                        montantTotal = situation.cout + montantTotal;
                        nivJoueur = niveaux;



                        compteurEvent = 0;


                    }
                    if (montantTotal < -1000000)
                    {
                        shopping = false;
                        TaskEnd = true;
                        GameOverDette();
                    }
                    else if (montantTotal > 1000000)
                    {
                        shopping = false;
                        TaskEnd = true;
                        GameOverMil(ref compteur);
                    }
                }

            });



            bool a = false; // menu amélioration
            while (a == false)
            {
                if ((Console.ReadKey(true).Key == ConsoleKey.A))
                {

                    shopping = true;


                    Console.WriteLine("\nQuelle amélioration voulez-vous acheter? Pour choisir une amélioration, appuyer sur la touche du numéro lui étant assigné.\n\n" +
                   "1- Achat d'un ordinateur le plus cheap sur le marcher : 50$/jour. Cout : 200$\n");
                    AfficherOrdiCheap();
                    Console.WriteLine("\n2- Avoir accès à des bourses et fonds de pension des banques : +200$/jour. Cout : 400$\n");
                    AfficherPretBanque();
                    Console.WriteLine("\n\n3- Vous engager un employé ayant un niveau d'expérience médiocre : +100$/jour. Cout : 1000$\n");
                    AfficherEmployéMédiocre();
                    Console.WriteLine("\n4- Vous engagez un comptable pour gérer vos finances : +300$/jours. Cout : 3000$");
                    AfficherComptable();
                    Console.WriteLine("\n5-Vous achetez un petit bureaux miteux : +10 000$/jour. Cout : -20 000 pour l'achat et -3500$/jour pour les frais de location.");
                    AfficherBureau1();
                    Console.WriteLine("\n6- Vous engagez une équipe de programmeur ayant un niveau de compétence moyen : +20 000$/jour. Cout : -50 000$ pour l'achat et -5000$/jour pour le salaire des employés.");
                    AfficherEquipeProg();
                    Console.WriteLine("\n7- Vous achetez un bureau de gamme standard en plein centre-ville : +30 000$/jour. Cout : 100 000$ pour l'achat et -5000/jour pour les frais de location.");
                    AfficherBureauVille();
                    Console.WriteLine("\n8- Vous achetez du matériel de meilleur pour vos employés : +50 000$/jour. Cout : -250 000$.\n");
                    AfficherMateriel();
                    Console.WriteLine("\n9- Vous engagez une équipe de programmeur ayant un niveau de compétence exceptionnelle\n");
                    AfficherEquipeProg();


                    ConsoleKey key = Console.ReadKey(true).Key;



                    if ((key == ConsoleKey.Q)) // pour quitter le menu
                    {
                        Console.Clear();
                        shopping = false;
                    }
                    else if ((key == ConsoleKey.D1) && montantTotal >= 200) //ConsoleKey.(Clé) --> ordi cheap
                    {
                        montantTotal -= 200;
                        montant += 50;
                        shopping = false;
                    }
                    else if ((key == ConsoleKey.D2) && montantTotal >= 400) // bourse et fond de pension des banks
                    {
                        montantTotal -= 400;
                        montant += 200;
                        shopping = false;
                    }
                    else if ((key == ConsoleKey.D3) && montantTotal >= 1000) // employé compétences faibles
                    {
                        montantTotal -= 1000;
                        montant += 500;
                        shopping = false;
                    }
                    else if ((key == ConsoleKey.D4) && montantTotal >= 3000) // comptable
                    {
                        montantTotal -= 3000;
                        montant += 300;
                        shopping = false;
                    }
                    else if ((key == ConsoleKey.D5) && montantTotal >= 20000) //bureau miteux
                    {
                        montantTotal -= 20000;
                        montant += 10000;
                        montant -= 3500;
                        shopping = false;
                    }
                    else if ((key == ConsoleKey.D6) && montantTotal >= 50000) // équipe d'employé compétence standard
                    {
                        montantTotal -= 50000;
                        montant += 20000;
                        montant -= 5000;
                        shopping = false;
                    }
                    else if ((key == ConsoleKey.D7) && montantTotal >= 100000) // bureaux de gamme standard
                    {
                        montantTotal -= 100000;
                        montant += 30000;
                        montant -= 5000;
                        shopping = false;
                    }
                    else if ((key == ConsoleKey.D8) && montantTotal >= 250000) // meilleur équipement pour les employés
                    {
                        montantTotal -= 250000;
                        montant += 50000;
                        shopping = false;
                    }
                    else if ((key == ConsoleKey.D9) && montantTotal >= 250000) // équipe de programmeur ayant compétences exceptionnelle
                    {
                        montantTotal -= 500000;
                        montant += 75000;
                        shopping = false;
                    }
                    else
                        shopping = false;
                    Console.Clear();





                }
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("                                                                      ");



            }




        }



        //dessins ascii
        static void AfficherOrdiCheap()
        {
            Console.Write("           __________                                 \n" +
                "         .'----------`.                              \n" +
                "         | .--------. |                             \n" +
                "         | |########| |       __________              \n" +
                "         | |########| |      /__________|             \n" +
                ".--------| `--------' |------|    --=-- |-------------.\n" +
                "|        `----,-.-----'      |o ======  |             | \n" +
                "|       ______|_|________    |__________|             | \n" +
                "|      /  %%%%%%%%%%%%   /                            | \n" +
                "|     /  %%%%%%%%%%%%%% /                             | \n" +
                "|     ^^^^^^^^^^^^^^^^^^^                             | \n" +
                "+-----------------------------------------------------+\n");

        }
        static void AfficherPretBanque()
        {
            Console.Write("___________________________________\n" +
                "|#######====================#######|\n" +
                "|#(1)*UNITED STATES OF AMERICA*(1)#|\n" +
                "|#**         | === |   ******** **#|\n" +
                "|*# {G}      | (o) |             #*|\n" +
                "|#*  ******  | |v| |    O N E    *#|\n" +
                "|#(1)        | === |           (1)#|\n" +
                "|##=========ONE DOLLAR===========##|\n" +
                "------------------------------------");


        }
        static void AfficherEmployéMédiocre()
        {
            Console.Write(" ############# \n" +
                " ##         ## \n" +
                " #  ~~   ~~  # \n" +
                " #  ()   ()  #\n" +
                " (     ^     )\n" +
                " |           |\n" +
                " |  {===}    | \n" +
                "  \\         / \n");

        }

        static void AfficherComptable()
        {
            Console.Write("    .------\\ /------.\n" +
                "    |       -       |\n" +
                "    |               |\n" +
                "    |               |\n" +
                "    |               |\n" +
                " _________________________\n" +
                " =============.===========\n" +
                "     / ~~~~~    ~~~~~ \\ \n" +
                "    / |     |   |   |  \\ \n" +
                "   W   ---  / \\  ---   W\n" +
                "   \\.      |o o|      ./\n" +
                "   |                   |\n" +
                "    \\    #########    /\n" +
                "     \\  ## ----- ##  /\n" +
                "      \\##         ##/\n" +
                "       \\_____v_____/\n\n");

        }
        static void AfficherBureau1()
        {
            Console.Write(" _________\n" +
                "| = = = = |\n" +
                "|         |\n" +
                "| |  || | |\n" +
                "|         |\n" +
                "| |  || | |\n" +
                "|         |\n" +
                "| |  || | |\n" +
                "| |  || | |\n" +
                "|         |\n" +
                "| ||||||| |\n" +
                "| ||||||| |\n" +
                "| ||||||| |\n" +
                "|_________|\n");

        }
        static void AfficherEquipeProg()
        {
            Console.Write(" O " + "  O " + "  O \n" +
                        "<|\\ " + "<|\\ " + "<|\\ \n" +
                        " | " + "  | " + "  | \n" +
                        " |\\ " + " |\\ " + " |\\ \n" +
                        "/ |" + " / |" + " / |\n");
        }

        static void AfficherBureauVille()
        {
            Console.Write("\n                       .|\n" +
                "                       | |\n" +
                "                       |'|            ._____\n" +
                "               ___    |  |            |.   |' .---\"|\n" +
                "       _    .-'   '-. |  |     .--'|  ||   | _|    |\n" +
                "    .-'|  _.|  |    ||   '-__  |   |  |    ||      |\n" +
                "    |' | |.    |    ||       | |   |  |    ||      |\n" +
                " ___|  '-'     '    \"\"       '-'   '-.'    '`      |____\n" +
                "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n");
        }
        static void AfficherMateriel()
        {
            Console.Write("  ,=====================.\n" +
                "  |G GATEWAY2000 /P5-90/|\n" +
                "  |.-------------------.|\n" +
                "  ||[ _ o     . .  _ ]_||\n" +
                "  |`-------------------'|\n" +
                "  ||                   ||\n" +
                "  |`-------------------'|\n" +
                "  ||                   ||\n" +
                "  |`-------------------'|\n" +
                "  ||                   ||\n" +
                "  |`-----------------_-'|\n" +
                "  ||[=========]| o  (@) |\n" +
                "  |`---------=='/u\\ --- |\n" +
                "  |------_--------------|\n" +
                "  | (/) (_)           []|\n" +
                "  |---==--==----------==|\n" +
                "  |||||||||||||||||||||||\n" +
                "  |||||||||||||||||||||||\n" +
                "  |||||||||||||||||||||||\n" +
                "  |||||||||||||||||||||||\n" +
                "  |||||||||||||||||||||||\n" +
                "  |||||||||||||||||||||||\n" +
                "  |||||||||||||||||||||||\n" +
                "  |||||||||||||||||||||||\n" +
                "  |||||||||||||||||||||||\n" +
                "  |||||||||||||||||dxm|||\n" +
                "  |||||||||||||||||||||||\n" +
                "  |=====================|\n" +
                " .'                     `.\n" +
                "\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\"\n");
        }

        private static SoundPlayer Music = new SoundPlayer();
        static void JouerMusic(string NomChanson)
        {
            Music.SoundLocation = "Music/" + NomChanson + ".wav";
            Music.PlayLooping();
        }

        static void StopMusic()
        {
            Music.Stop();
        }

        static void Main(string[] args)
        {
            Intro();
            JouerMusic("Music");
            GenererArgent();

        }
    }
}

