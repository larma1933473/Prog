using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        public struct Metal
        {
            public string nom;
            public int Resistance;
            public int PointFusion;
            public int Poid;
            public int Conductivité;
            public Metal(string _nom, int _Resistance, int _PointFusion, int _Poid, int _Conductivité) : this()
            {
                nom = _nom;
                Resistance = _Resistance;
                PointFusion = _PointFusion;
                Poid = _Poid;
                Conductivité = _Conductivité;
            }
        }

        static Metal[] CreerTableauMetal()
        {
            Metal[] tabMetal = new Metal[5];

            tabMetal[0] = new Metal("Fer", 7, 9, 4, 3);
            tabMetal[1] = new Metal("Cuivre", 4, 8, 8, 2);
            tabMetal[2] = new Metal("Plomb", 1, 3, 7, 2);
            tabMetal[3] = new Metal("Zinc", 2, 5, 3, 6);
          

            return tabMetal;
        }
       
        static void PireResistance(Metal[] tabMetal)
        {
            int MauvaiseRes = tabMetal[0].Resistance;

            for (int i = 1; i < tabMetal.Length; i++)
            {
                if (Math.Abs(MauvaiseRes-5) > tabMetal[i].Resistance && tabMetal[i].Resistance >=5|| Math.Abs(MauvaiseRes-5) < tabMetal[i].Resistance && tabMetal[i].Resistance <= 5)
                {
                    MauvaiseRes = tabMetal[i].Resistance;
                }
              

            }
            
            Console.WriteLine("la pire resistance est " + MauvaiseRes);
        }
        static void TrouverPointFusionSuperieur(Metal[] tabMetal)
        {
            bool FusionSuperieur = false;
            int cpt = 0;

            while (FusionSuperieur == false && cpt < tabMetal.Length)
            {
                if (tabMetal[cpt].PointFusion >= 8)
                {
                    FusionSuperieur = true;
                  
                }
                else
                {
                    cpt++;
                }
            }
            if (FusionSuperieur)
                Console.WriteLine("Il existe un metal ayant un point de fusion de 8 ou plus ");
            else
                Console.WriteLine("Il n'existe pas un metal ayant un point de fusion de 8 ou plus ");

        }
        static void TrouverMeilleurMoyenne(Metal[] tabMetal)
        {
            double MeilleurMoyenne = (tabMetal[0].Resistance + tabMetal[0].PointFusion + tabMetal[0].Poid + tabMetal[0].Conductivité)/4 ;
            double MoyenneTableau = 0;

            for (int i = 0; i < tabMetal.Length; i++)
            {
                MoyenneTableau = (tabMetal[i].Resistance + tabMetal[i].PointFusion + tabMetal[i].Poid + tabMetal[i].Conductivité)/ 4;

                if (MeilleurMoyenne > MoyenneTableau && MoyenneTableau <= 5 || MeilleurMoyenne < MoyenneTableau && MoyenneTableau >= 5)
                {
                     MeilleurMoyenne= tabMetal[i].Resistance;
                }
            }
            Console.WriteLine("la meilleur moyenne est" + MeilleurMoyenne);
        }
        static void CreerNouvelleAlliage(Metal[] tabMetal)
        {
            int ChoixMetal1 = 0;
            int ChoixMetal2 = 0;
            string NomMetal1 = "";
            string NomMetal2 = "";
            int pourcentageMetal1 = 0;
            int pourcentageMetal2 = 0;
            Console.WriteLine("veuillez choisir 2 metaux pour créer un alliage: 1-Fer 2-Cuivre 3-Plomb 4-Zinc");

            ChoixMetal1 = Convert.ToInt32(Console.ReadLine());
            

            Console.WriteLine("a quel pourcentage voulez vous le metaux choisis (les deux metaux doivent donner 100%) ");

            pourcentageMetal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("veuillez choisir le 2ème metal pour créer un alliage: 1-Fer 2-Cuivre 3-Plomb 4-Zinc");

            ChoixMetal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a quel pourcentage voulez vous le metaux choisis (les deux metaux doivent donner 100%) ");

            pourcentageMetal2 = Convert.ToInt32(Console.ReadLine());

            int pourcentageTotal = pourcentageMetal2 + pourcentageMetal1;
            if(pourcentageTotal==100)
            {
                NomMetal1 = tabMetal[ChoixMetal1].nom;
                NomMetal2 = tabMetal[ChoixMetal2].nom;
                if (pourcentageMetal1<= pourcentageMetal2)
                {
                    Console.WriteLine(NomMetal1 + " " + pourcentageMetal1 + " % et " + NomMetal2 + " " + pourcentageMetal2 + " % --> " + NomMetal1 + NomMetal2);
                    
                }
                else
                {
                    Console.WriteLine(NomMetal2 + " " + pourcentageMetal2 + " % et " + NomMetal1 + " " + pourcentageMetal1 + " % --> " + NomMetal2 + NomMetal1);

                }
            }
            else
            {
                Console.WriteLine("le pourcentage est incorect");
            }
        }
        static void Quitter()
        {

            Console.WriteLine("vous quitter la console");


        }
        static void Main(string[] args)
        {
            int choix = 0;
            Metal[] tabMetal = CreerTableauMetal();

            Console.WriteLine("1-Connaître le métal avec la pirerésistance");
            Console.WriteLine("2-Connaître  le  métal  avec  le  meilleur  score  (moyenne  de tous les cotes, doit être le plus près de 5)");
            Console.WriteLine("3-Savoir si un métal avec un point de fusion supérieur de plus de 8existe");
            Console.WriteLine("4-Créer un nouvel alliage");
            Console.WriteLine("5-Quitter");

            choix = Convert.ToInt32(Console.ReadLine());

            switch (choix)
            {
                case 1: PireResistance(tabMetal); break;
                case 2: TrouverMeilleurMoyenne(tabMetal); break;
                case 3: TrouverPointFusionSuperieur(tabMetal); break;
                case 4: CreerNouvelleAlliage(tabMetal); break;
                case 5: Quitter(); break;

            }
        }
    }
}
