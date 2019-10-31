using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace le_31
{
    enum Sorte { Coeur = 1, Pique = 2, Carreau = 3, Trefle = 4 };
    class Program
    {
        static Random generateurNb = new Random();
        static int GenererNB(int min, int max)
        {
            return (int)generateurNb.Next(min, max);
        }
        static void GenererCarte(out int valeur, out Sorte sorte)
        {
            sorte = (Sorte)GenererNB(1, 5);
            valeur = GenererNB(1, 14);
        }
        static string GetValeurCarte(int valeur, Sorte sorte)
        {
            String message = "";
            switch (valeur)
            {
                case 1: message += "As"; break;
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                    message += valeur.ToString(); break;
                case 11: message += "Valet"; break;
                case 12: message += "Dame"; break;
                case 13: message += "Roi"; break;
            }

            message += " - " + sorte.ToString();
            return message;
        }
        static void AfficherMenu()
        {
            Console.WriteLine("bienvenu sur le jeu 31! si vous voulez jouer contre 1 joueur appuyer sur 1, si vous voulez jouer contre 2 joueur appuyer sur 2 pour jouer contre 3 joueur appuyer sur 3");
        }
        

        
        public struct Carte
        {
            public Sorte sorte;
            public int valeur;
            public Carte (Sorte _sorte, int _valeur) : this()
            {
                sorte = _sorte;
                valeur = _valeur;
            }
        }
        public struct Joueur
        {
            public Carte[]tabCarte;
            public int nbVie;
            public int id; 
            public Joueur(int _nbVie, int _id) : this()
            {
                id = _id;
                tabCarte = new Carte[3];
                tabCarte[0] = new Carte((Sorte)GenererNB(1, 5), GenererNB(1, 14));
                tabCarte[1] = new Carte((Sorte)GenererNB(1, 5), GenererNB(1, 14));
                tabCarte[2] = new Carte((Sorte)GenererNB(1, 5), GenererNB(1, 14));
                nbVie = _nbVie;
            }
        }
        static void UnJoueur()
        {

            Joueur joueur1 = new Joueur(3,0);
            Joueur joueur2 = new Joueur(3,1);
            Carte carteCentre = new Carte((Sorte)GenererNB(1, 5), GenererNB(1, 14));
            bool partiTerminer = false;
            Joueur joueurActif = joueur1;
            bool cogne = false;
            int tourAvantFin = 1;
            bool nombredevie=false;

            int nombreVie1=0;
            int nombreVie2=0;

            nombreVie1=3;
            nombreVie2=3;

            Console.WriteLine("vous jouer contre 1 adversaire ");

            while(nombredevie==false)
                {
                
                while (partiTerminer == false && tourAvantFin > 0)
                {
                    if (cogne == true)
                        tourAvantFin--;

                    Console.WriteLine("le nombre de vie du joueur 1 est de " + nombreVie1 + "vie et le nombre de vie du joueur 2 est de " + nombreVie2 +"vie");
                    Console.WriteLine("vos carte sont " + joueurActif.tabCarte[0].valeur + "de" + joueurActif.tabCarte[0].sorte + joueurActif.tabCarte[1].valeur + "de" + joueurActif.tabCarte[1].sorte + joueurActif.tabCarte[2].valeur + "de" + joueurActif.tabCarte[2].sorte);
                    Console.WriteLine("la carte retourner " + carteCentre.valeur + "de" + carteCentre.sorte);
                    Console.WriteLine("si vous voulez prendre la carte retourner appuyer sur 1 .si vous voulez piochez une carte appuyez sur 2 .appuyez sur 3 pour cogner.");
                    int choixJeux = 0;

                    choixJeux = Convert.ToInt32(Console.ReadLine());

                    if (choixJeux == 1)
                    {
                        Console.WriteLine("quel carte voulez vous jetez ?");
                        int carteJeter = 0;

                        carteJeter = Convert.ToInt32(Console.ReadLine());

                        if (carteJeter == 1)
                        {
                            Carte temp;
                            temp = joueurActif.tabCarte[0];
                            joueurActif.tabCarte[0] = carteCentre;
                            carteCentre = temp;

                        }
                        if (carteJeter == 2)
                        {
                            Carte temp;
                            temp = joueurActif.tabCarte[1];
                            joueurActif.tabCarte[1] = carteCentre;
                            carteCentre = temp;
                        }
                        if (carteJeter == 3)
                        {
                            Carte temp;
                            temp = joueur1.tabCarte[0];
                            joueurActif.tabCarte[0] = carteCentre;
                            carteCentre = temp;
                        }

                    }
                    if (choixJeux == 2)
                    {
                        Carte cartePige = new Carte((Sorte)GenererNB(1, 5), GenererNB(1, 14));
                        Console.WriteLine("la carte piger est " + cartePige.valeur + "de" + cartePige.sorte);
                        Console.WriteLine("quel carte voulez vous jetez ?");

                        int carteJeter = 0;

                        carteJeter = Convert.ToInt32(Console.ReadLine());

                        if (carteJeter == 1)
                        {
                            Carte temp;
                            temp = joueurActif.tabCarte[0];
                            joueurActif.tabCarte[0] = cartePige;
                            cartePige = temp;

                        }
                        if (carteJeter == 2)
                        {
                            Carte temp;
                            temp = joueurActif.tabCarte[1];
                            joueurActif.tabCarte[1] = cartePige;
                            cartePige = temp;
                        }
                        if (carteJeter == 3)
                        {
                            Carte temp;
                            temp = joueurActif.tabCarte[0];
                            joueurActif.tabCarte[0] = cartePige;
                            cartePige = temp;
                        }

                    }
                    if (choixJeux == 3)
                    {
                        int totalCarte = 0;

                        totalCarte = joueurActif.tabCarte[0].valeur + joueurActif.tabCarte[1].valeur + joueurActif.tabCarte[2].valeur;

                        if (totalCarte > 31)
                        {
                            totalCarte = 31;
                        }

                        if (totalCarte < 21)
                        {
                            Console.WriteLine("vous n'avez pas 21 vous ne pouvez pas cogner. vous passez votre tours parce que vous ne savez pas compter");
                        }
                        if(totalCarte > 21)
                        {
                            Console.WriteLine("la valeur de vos carte est de" + totalCarte);
                            Console.WriteLine("vous cognez, veuillez patienter un tours...");
                            cogne = true;

                            if (joueurActif.id == 0)
                                joueurActif = joueur2;
                            else
                                joueurActif = joueur1;

                        }
                    
                    }


                    if (joueurActif.id == 0)
                        joueurActif = joueur2;
                    else
                        joueurActif = joueur1;
                }

                //fin partie ici
                int totalCarte = 0;
                int totalCarte2 = 0;

                totalCarte = joueur1.tabCarte[0].valeur + joueur1.tabCarte[1].valeur + joueur1.tabCarte[2].valeur;
                totalCarte2 = joueur2.tabCarte[0].valeur + joueur2.tabCarte[1].valeur + joueur2.tabCarte[2].valeur;

                if(totalCarte<totalCarte2)
                {
                    Console.WriteLine("le joueur 1 a gagné la parti");
                    nombreVie2=nombreVie2-1;

                    if(nombreVie2==0)
                        {
                            Console.WriteLine("le joueur 1 a gagné le tournois");
                            nombredevie=true;
                        }
                }
                else
                {
                    Console.WriteLine("le joueur 2 a gagné la parti");
                    nombreVie1=nombreVie1-1;

                    if(nombreVie2==0)
                        {
                            Console.WriteLine("le joueur 2 a gagné le tournois");
                            nombredevie=true;
                        }
                }
                }

        }
        static void DeuxJoueur()
        {
            Joueur joueur1 = new Joueur(3,0);
            Joueur joueur2 = new Joueur(3,1);
            Joueur joueur3 = new Joueur(3,2);
            Carte carteCentre = new Carte((Sorte)GenererNB(1, 5), GenererNB(1, 14));
            bool partiTerminer = false;
            Joueur joueurActif = joueur1;
            bool cogne = false;
            int tourAvantFin = 1;

            double[]table=new double [3];

            Console.WriteLine("vous jouer contre 1 adversaire ");

            while (partiTerminer == false && tourAvantFin > 0)
            {
                if (cogne == true)
                    tourAvantFin--;

                Console.WriteLine("vos carte sont " + joueurActif.tabCarte[0].valeur + "de" + joueurActif.tabCarte[0].sorte + joueurActif.tabCarte[1].valeur + "de" + joueurActif.tabCarte[1].sorte + joueurActif.tabCarte[2].valeur + "de" + joueurActif.tabCarte[2].sorte);
                Console.WriteLine("la carte retourner " + carteCentre.valeur + "de" + carteCentre.sorte);
                Console.WriteLine("si vous voulez prendre la carte retourner appuyer sur 1 .si vous voulez piochez une carte appuyez sur 2 .appuyez sur 3 pour cogner.");
                int choixJeux = 0;

                choixJeux = Convert.ToInt32(Console.ReadLine());

                if (choixJeux == 1)
                {
                    Console.WriteLine("quel carte voulez vous jetez ?");
                    int carteJeter = 0;

                    carteJeter = Convert.ToInt32(Console.ReadLine());

                    if (carteJeter == 1)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[0];
                        joueurActif.tabCarte[0] = carteCentre;
                        carteCentre = temp;

                    }
                    if (carteJeter == 2)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[1];
                        joueurActif.tabCarte[1] = carteCentre;
                        carteCentre = temp;
                    }
                    if (carteJeter == 3)
                    {
                        Carte temp;
                        temp = joueur1.tabCarte[0];
                        joueurActif.tabCarte[0] = carteCentre;
                        carteCentre = temp;
                    }

                }
                if (choixJeux == 2)
                {
                    Carte cartePige = new Carte((Sorte)GenererNB(1, 5), GenererNB(1, 14));
                    Console.WriteLine("la carte piger est " + cartePige.valeur + "de" + cartePige.sorte);
                    Console.WriteLine("quel carte voulez vous jetez ?");

                    int carteJeter = 0;

                    carteJeter = Convert.ToInt32(Console.ReadLine());

                    if (carteJeter == 1)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[0];
                        joueurActif.tabCarte[0] = cartePige;
                        cartePige = temp;

                    }
                    if (carteJeter == 2)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[1];
                        joueurActif.tabCarte[1] = cartePige;
                        cartePige = temp;
                    }
                    if (carteJeter == 3)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[0];
                        joueurActif.tabCarte[0] = cartePige;
                        cartePige = temp;
                    }

                }
                if (choixJeux == 3)
                {
                    int totalCarte = 0;

                    totalCarte = joueurActif.tabCarte[0].valeur + joueurActif.tabCarte[1].valeur + joueurActif.tabCarte[2].valeur;

                    if (totalCarte > 31)
                    {
                        totalCarte = 31;
                    }

                    if (totalCarte < 21)
                    {
                        Console.WriteLine("vous n'avez pas 21 vous ne pouvez pas cogner");
                    }
                    else
                    {
                        Console.WriteLine("la valeur de vos carte est de" + totalCarte);
                        Console.WriteLine("vous cognez, veuillez patienter un tours...");
                        cogne = true;
                       
                        table[nombrejoueur];

                        nombrejoueur++;
                        if(nombrejoueur>=3)
                            {
                                nombrejoueur=0;
                            }

                    }
                    
                }


                if (joueurActif.id == 0)
                    joueurActif = joueur2;
                else
                    joueurActif = joueur1;
            }

            //fin partie ici
            int totalCarte = 0;
            int totalCarte2 = 0;

            totalCarte = joueur1.tabCarte[0].valeur + joueur1.tabCarte[1].valeur + joueur1.tabCarte[2].valeur;
            totalCarte2 = joueur2.tabCarte[0].valeur + joueur2.tabCarte[1].valeur + joueur2.tabCarte[2].valeur;

            if(totalCarte<totalCarte2)
            {
                Console.WriteLine("le joueur 1 a gagné la parti");
            }
            else
            {
                Console.WriteLine("le joueur 2 a gagné la parti");
            }



        }
        static void TroisJoueur()
        {
            Joueur joueur1 = new Joueur(3,0);
            Joueur joueur2 = new Joueur(3,1);
            Carte carteCentre = new Carte((Sorte)GenererNB(1, 5), GenererNB(1, 14));
            bool partiTerminer = false;
            Joueur joueurActif = joueur1;
            bool cogne = false;
            int tourAvantFin = 1;

            int nombrejoueur=0;
            nombrejoueur==3;

            Console.WriteLine("vous jouer contre 1 adversaire ");

            while (partiTerminer == false && tourAvantFin > 0)
            {
                if (cogne == true)
                    tourAvantFin--;


                Console.WriteLine("vos carte sont " + joueurActif.tabCarte[0].valeur + "de" + joueurActif.tabCarte[0].sorte + joueurActif.tabCarte[1].valeur + "de" + joueurActif.tabCarte[1].sorte + joueurActif.tabCarte[2].valeur + "de" + joueurActif.tabCarte[2].sorte);
                Console.WriteLine("la carte retourner " + carteCentre.valeur + "de" + carteCentre.sorte);
                Console.WriteLine("si vous voulez prendre la carte retourner appuyer sur 1 .si vous voulez piochez une carte appuyez sur 2 .appuyez sur 3 pour cogner.");
                int choixJeux = 0;

                choixJeux = Convert.ToInt32(Console.ReadLine());

                if (choixJeux == 1)
                {
                    Console.WriteLine("quel carte voulez vous jetez ?");
                    int carteJeter = 0;

                    carteJeter = Convert.ToInt32(Console.ReadLine());

                    if (carteJeter == 1)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[0];
                        joueurActif.tabCarte[0] = carteCentre;
                        carteCentre = temp;

                    }
                    if (carteJeter == 2)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[1];
                        joueurActif.tabCarte[1] = carteCentre;
                        carteCentre = temp;
                    }
                    if (carteJeter == 3)
                    {
                        Carte temp;
                        temp = joueur1.tabCarte[0];
                        joueurActif.tabCarte[0] = carteCentre;
                        carteCentre = temp;
                    }

                }
                if (choixJeux == 2)
                {
                    Carte cartePige = new Carte((Sorte)GenererNB(1, 5), GenererNB(1, 14));
                    Console.WriteLine("la carte piger est " + cartePige.valeur + "de" + cartePige.sorte);
                    Console.WriteLine("quel carte voulez vous jetez ?");

                    int carteJeter = 0;

                    carteJeter = Convert.ToInt32(Console.ReadLine());

                    if (carteJeter == 1)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[0];
                        joueurActif.tabCarte[0] = cartePige;
                        cartePige = temp;

                    }
                    if (carteJeter == 2)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[1];
                        joueurActif.tabCarte[1] = cartePige;
                        cartePige = temp;
                    }
                    if (carteJeter == 3)
                    {
                        Carte temp;
                        temp = joueurActif.tabCarte[0];
                        joueurActif.tabCarte[0] = cartePige;
                        cartePige = temp;
                    }

                }
                if (choixJeux == 3)
                {
                    int totalCarte = 0;

                    totalCarte = joueurActif.tabCarte[0].valeur + joueurActif.tabCarte[1].valeur + joueurActif.tabCarte[2].valeur;

                    if (totalCarte > 31)
                    {
                        totalCarte = 31;
                    }

                    if (totalCarte < 21)
                    {
                        Console.WriteLine("vous n'avez pas 21 vous ne pouvez pas cogner");
                    }
                    else
                    {
                        Console.WriteLine("la valeur de vos carte est de" + totalCarte);
                        Console.WriteLine("vous cognez, veuillez patienter un tours...");
                        cogne = true;

                        i++;

                        if(i>=nombrejoueur)
                                {
                                   i==0;
                                }

                    }
                    
                }

              for(double i=0;i<table.Lenght;i++)
                    {
                        cpt++;
                    }
            }

            //fin partie ici
            int totalCarte = 0;
            int totalCarte2 = 0;

            totalCarte = joueur1.tabCarte[0].valeur + joueur1.tabCarte[1].valeur + joueur1.tabCarte[2].valeur;
            totalCarte2 = joueur2.tabCarte[0].valeur + joueur2.tabCarte[1].valeur + joueur2.tabCarte[2].valeur;

            if(totalCarte<totalCarte2)
            {
                Console.WriteLine("le joueur 1 a gagné la parti");
            }
            else
            {
                Console.WriteLine("le joueur 2 a gagné la parti");
            }


        }

        static void MainJoueur(Joueur joueur)
        {
            for (int i = 0; i < joueur.tabCarte.Length; i++)
            {
                AfficherCarte( joueur.tabCarte[i] );
            }
        }

        static void AfficherCarte(Carte carte)
        {
            Console.WriteLine("La valeur de la carte est" + carte.valeur + " et la sorte est " + carte.sorte);
        }
        static void Main(string[] args)
        {

            GenererCarte(out int valeurCarte8, out Sorte sorteCarte8); 
            GenererCarte(out int valeurCarte9, out Sorte sorteCarte9);
            GenererCarte(out int valeurCarte11, out Sorte sorteCarte10);

            GenererCarte(out int valeurCarte12, out Sorte sorteCarte11);
            GenererCarte(out int valeurCarte13, out Sorte sorteCarte12);
            GenererCarte(out int valeurCarte14, out Sorte sorteCarte14);

            Console.ReadKey();
            
            AfficherMenu();

            int choix = 0;

            choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1: UnJoueur(); break;
                case 2: DeuxJoueur(); break;
                case 3: TroisJoueur(); break;
            }   
        }
    }
}
