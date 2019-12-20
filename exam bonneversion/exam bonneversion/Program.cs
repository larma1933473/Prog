using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_bonneversion
{
    class Program
    {
        {
        static Random generateur = new Random();

        //Créer une structure de vaisseau -Done
        //Créer le tableau de  10 vaisseaux - Done
        //Remplir le tableau - Done
        //Afficher le menu
        //Saisir le choix
        //Effucter action
        //1- Afficher les info des vaisseaux

        //Rarete(int) 1-commun , 2-rare, 3-épique, 4 leg
        public struct Vaisseau
        {
            public string nom;
            public int vitesse;
            public int vie;
            public int rarete;
            public int prix;

            public Vaisseau(string _nom, int _vitesse, int _vie, int _rarete, int _prix) : this()
            {
                nom = _nom;
                vitesse = _vitesse;
                vie = _vie;
                rarete = _rarete;
                prix = _prix;
            }
        }
        static void AfficherLegExiste( Vaisseau[] tabVaisseau)
        {
            bool legExiste = false;
            int cpt = 0;
            int valeurAtt = 0;
            Console.WriteLine("Quelle valeur d'attaque voulez-vous trouver?");
            valeurAtt = Convert.ToInt32(Console.ReadLine());
            while (legExiste == false && cpt < tabVaisseau.Length)
            {
                if (tabVaisseau[cpt].rarete == 4)
                    legExiste = true;
                else
                    cpt++;
            }

            if (legExiste)
                Console.WriteLine("Il existe un  vaisseau légendaire");
            else
                Console.WriteLine("vaisseaux légendaire n'existe pas .... ");
        }
        static void Main(string[] args)
        {
            Vaisseau[] tabVaisseau = new Vaisseau[10];
            int choix = 0;

            for (int i = 0; i < tabVaisseau.Length; i++)
            {
                tabVaisseau[i] = CreerVaisseau();
            }

            AfficherMenu();

            choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1: AfficherVaisseaux(tabVaisseau); break;
                case 2: AfficherLegExiste(tabVaisseau); break;
                case 3: VerifierVaisseauLeg(tabVaisseau); break;
                case 4: VerifierVaisseauLeg(tabVaisseau); break;
                case 5: VerifierVaisseauLeg(tabVaisseau); break;
                case 6: quitter(); break;

            }

        }
        static void AfficherMoyenneVie(Vaisseau[] tabVaisseau)
        {
            int moy = 0, tot = 0;
            for (int i = 0; i < tabVaisseau.Length; i++)
            {
                tot += tabVaisseau[i].prix;
            }

            moy = tot / tabVaisseau.Length;
            Console.WriteLine("La moyennede prix  est de " + moy);
        }
        static bool VerifierVaisseauLeg(Vaisseau[] tabVaisseau)
        {
            bool vaisseauExiste = false;
            int cpt = 0;
            while (vaisseauExiste == false && cpt < tabVaisseau.Length)
            {
                if (tabVaisseau[cpt].rarete == 4)
                    vaisseauExiste = true;
                else
                    cpt++;
            }

            return vaisseauExiste;
        }
        static void quitter ()
        {
            Console.WriteLine("vous Quittez le programme");
        }
        static void AfficherVaisseaux(Vaisseau[] tabVaisseau)
        {
            for (int i = 0; i < tabVaisseau.Length; i++)
            {
                Console.WriteLine("Le nom : " + tabVaisseau[i].nom + " \n vitesse : " + tabVaisseau[i].vitesse);
            }
        }

        static void AfficherMenu()
        {
            Console.WriteLine("Veuillez choisir l'une des options suivantes : ");
            Console.WriteLine("1- Afficher la liste des vaisseaux ");
            Console.WriteLine("2- Verifier si legendaire");
            Console.WriteLine("3- Afficher le vaisseau avec la vie la plus haute ");
            Console.WriteLine("4- Afficher la moyenne des prix ");
            Console.WriteLine("5- tenter de négocier avec le vendeur");
            Console.WriteLine("6- Quitter le programme");

        }

        static Vaisseau CreerVaisseau()
        {
            Vaisseau nouveauVaisseau;
            int vitesse = 0, vie = 0, prix = 0, rarete = 0;


            int rareteProb = generateur.Next(1, 101);
            if (rareteProb < 51)
            {
                vitesse = generateur.Next(10, 16);
                vie = generateur.Next(100, 151);
                prix = 2000;
                rarete = 1;

            }
            else if (rareteProb < 76)
            {
                //rare
                vitesse = generateur.Next(12, 26);
                vie = generateur.Next(140, 251);
                prix = 4500;
                rarete = 2;
            }
            else if (rareteProb < 96)
            {
                //epique
                vitesse = generateur.Next(23, 46);
                vie = generateur.Next(200, 601);
                prix = 2000;
                rarete = 1;
            }
            else
            {
                //leg
                vitesse = generateur.Next(10, 16);
                vie = generateur.Next(550, 2001);
                prix = 2000;
                rarete = 1;
            }
            nouveauVaisseau = new Vaisseau("Vaisseau ", vitesse, vie, rarete, prix);


            return nouveauVaisseau;
        }
    }
}
}
