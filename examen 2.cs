using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examen_2
{
    class Program
    {

        static void afficherMenu()
        {
            Console.WriteLine("bonjours joueur, ");
            Console.WriteLine("appuyez sur 1 pour afficher les vaisseaux avec toutes les caractéristiques ");
            Console.WriteLine("appuyez sur 2 pour vérifier si un vaisseau légendaire existe ");
            Console.WriteLine("appuyer sur 3 pour trouver le vaisseaux avec la vie la plus haute ");
            Console.WriteLine("appuyer sur 4 pour voir la moyenne des prix des vaisseaux ");
            Console.WriteLine("appuyez sur 5 pour quitter");
        }
        static void afficherVaisseaux(ref int[] tabVaisseaux,int prix,int vie, int vitesse)
        {
            for (int i=0; i<tabVaisseaux.Length;i++)
            {
                Console.WriteLine("" + tabVaisseaux[i] + prix + vie + vitesse);
            }
        }
        static void vaisseauExiste(ref int[] tabVaisseaux)
        {
            double nombresaisi = 0;

            Convert.ToInt32(Console.ReadLine());
            int cpt = 0;
            bool vaisseauxExiste = false;
            while (vaisseauxExiste == false && cpt < tabVaisseaux.Length)
            {
                if (nombresaisi == tabVaisseaux[cpt])
                {
                    vaisseauxExiste = true;
                    Console.WriteLine("le vaisseau existe ");
                }
                else
                {
                    cpt++;
                }
                Console.WriteLine("le vaisseau n'existe pas");
            }
        }
        static void grandeVie(ref int[] tabVaisseaux)
        {
            int grandVie = tabVaisseaux[0];
            for (int i = 1; i < tabVaisseaux.Length; i++)
            {
                if(grandVie< tabVaisseaux[i])
                {
                    grandVie = tabVaisseaux[i];
                }
            }
        }
        static void moyenne(ref int[] tabVaisseaux, int prix)
        {
            int moyenne = 0;
            int prixTotal = 0;

            for (int i=0;i<tabVaisseaux.Length;i++)
            {
                prixTotal = prix+prixTotal;
            }
            moyenne = prixTotal / 10;
        }
        static void quitter()
        {
            Console.WriteLine("vous quitter le jeu");
        }
        static void Main(string[] args)
        {
            int[] tabVaisseaux = new int[10];

            int commun = 0;
            int rare = 0;
            int épic = 0;
            int légendaire = 0;
            int vitesse = 0;
            int vie = 0;
            int prix = 0;
            for (int i = 0; i < tabVaisseaux.Length; i++)
            {
                Random genererNb = new Random();
                int rareté = genererNb.Next(1, 10);

                if (rareté < 5)
                {
                    rareté = commun;

                    Random genererVitesse = new Random();
                    vitesse = genererVitesse.Next(10, 16);

                    Random genererVie = new Random();
                    vie = genererVie.Next(100, 151);

                    prix = 2000;
                }
                else if (rareté >= 5 && rareté <= 7)
                {
                    rareté = rare;

                    Random genererVitesse = new Random();
                    vitesse = genererVitesse.Next(12, 26);

                    Random genererVie = new Random();
                    vie = genererVie.Next(140, 251);

                    prix = 4500;
                }
                else if (rareté == 8 || rareté == 9)
                {
                    rareté = épic;

                    Random genererVitesse = new Random();
                    vitesse = genererVitesse.Next(23, 46);

                    Random genererVie = new Random();
                    vie = genererVie.Next(200, 601);

                    prix = 8000;

                }
                else
                {
                    rareté = légendaire;

                    Random genererVitesse = new Random();
                    vitesse = genererVitesse.Next(40, 71);

                    Random genererVie = new Random();
                    vie = genererVie.Next(550, 2001);

                    prix = 20000;

                }
            }

            afficherMenu();

            int choix=0;

            choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1: afficherVaisseaux(ref tabVaisseaux); break;
                case 2: vaisseauExiste(ref tabVaisseaux); break;
                case 3: grandeVie(ref tabVaisseaux); break;
                case 4: moyenne(ref prix, tabVaisseaux); break;
                case 5: quitter(); break;
            }

        }
    }
}
