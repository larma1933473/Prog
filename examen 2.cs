using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aléatoire_exercise_2
{
    class Program
    {
        static void AfficherMenu()
        {
              Console.WriteLine("pour trouver le plus grand nombre appuyer sur 1 \n pour le plus petit appuyer sur  2 \n pour verifier si la saisis existe appuyer sur 3\n pour faire la moyenne appuyer sur 4\n pour quitter appuyer sur 5\n pour  voir si un nombre est supérireur a 9995 appuyer sur 6 \n appuyer sur 7 pour savoir si un nombre revien 3 fois \n ");       
        }
        static void AfficherGrandNombre(ref int[] table)
        {
            double grandNb = table[0];

            for (int i = 1; i < table.Length; i++)
            {
                if(grandNb<table[i])
                {
                    grandNb=table[i];
                }
            }
            Console.WriteLine("le plus grand nombre est " + grandNb);
        }
        
        static void AfficherPetitNombre(ref int[] table)
        { 
            double petitnb = table[0];

            for (int i = 1; i > table.Length; i++)
            {
                if(petitnb>table[i])
                {
                    petitnb=table[i];
                }
            }
            Console.WriteLine("le plus petit nombre est " + petitnb);
        }
        
        static void VérifierNombreExiste(ref int[] table)
        {
             double nombresaisi=0;
         
            Convert.ToInt32(Console.ReadLine());
            int cpt= 0;
            bool nombreexiste=false;
            while(nombreexiste== false && cpt<table.Length)
            {
                if(nombresaisi==table[cpt])
                {
                    nombreexiste=true;
                    Console.WriteLine("le nombre existe et est a la position "+ i);
                }
                else
                {
                    cpt++;
                }
                Console.WriteLine("le nombre n'existe pas");
            }
         
        }
        static void nombreSupérieur(ref int[] table)
        {
            double nombresupérieur = 0;

            Convert.ToInt32(Console.ReadLine());
            int cpt = 0;
            bool nombregrand = false;
            while (nombregrand == false && cpt < table.Length)
            {
                if (nombresupérieur >= 9995)
                {
                    nombregrand = true;
                    Console.WriteLine("il y a des nombres supérieur a 9995");
                }
                else
                {
                    cpt++;
                }
            }
        }
        static void AfficherMoyenne(ref int[] table)
        {
          
            int total=0;
            int moyenne=0;
                
            for(int i=0; i<table.Length;i++)
            {
                total=total + table[i];
            }
            moyenne=total/table.Length;

            Console.WriteLine("la moyenne des nombre est de"+moyenne);
            
        }
        static void QuitterMenu()
        {
                Console.WriteLine("vous quitter le menu");
        }
        static void nombreRevien(ref int[] table)
        {
            int nombresaisie=0;
            int revenue = 0;
            Convert.ToInt32(Console.ReadLine());
            int cpt= 0;
            bool nombrerevenu=false;
            while(nombrerevenu== false && cpt<table.Length)
            {
                if(nombresaisie==table[cpt])
                {
                    revenue = revenue + 1;
                    if(revenue==3)
                    {
                        nombrerevenu = true;

                        Console.WriteLine("le nombre revient 3 fois ou plus ");
                    }
                   
                }
                else
                {
                    cpt++;
                }
                Console.WriteLine("le nombre ne revien pas 3 fois");
            }
        }
        static void Main(string[] args)
        {
            int choix=0;
            Random generer = new Random();
            int[] table = new int[300];

            for (int i = 0; i < table.Length; i++)
            {
                table[i] = generer.Next(1, 10001);
            }

            AfficherMenu();
            choix= Convert.ToInt32(Console.ReadLine());
            switch(choix)
            {
                case 1:AfficherGrandNombre(ref table);break;
                case 2:AfficherPetitNombre(ref table);break;
                case 3:VérifierNombreExiste(ref table);break;
                case 4:AfficherMoyenne(ref table);break;
                case 5:QuitterMenu();break;
                case 6:nombreSupérieur(ref table);break;
                case 7:nombreRevien(ref table);break;
            }
        
      
        }
    }
}
