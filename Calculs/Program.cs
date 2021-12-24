/**
 * Application "Calculs" v01 (b5 a218)
 * author : Emds
 * date : 24/05/2020
 */
using System;

namespace Calculs
{
    class Program
    {
        static void Main(string[] args)
        {
            // variables 
            Random rand = new Random(); // outil de génération de nombre aléatoire
            int val1, val2; // mémorisation de nombres aléatoires
            int solution; // calcul de la solution
            int reponse; // saisie de la réponse de l'utilisateur
            int choix; // saisie du choix de l'utilsiateur
            string maSaouler;
            bool isNumber;
            int n;

            // boucle sur le menu
            choix = 1;
            while (choix != 0)
            {

                // affiche le menu et saisi le choix
                Console.WriteLine("Addition ....................... 1");
                Console.WriteLine("Multiplication ................. 2");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                maSaouler = Console.ReadLine();
                isNumber = int.TryParse(maSaouler, out n);
                if (isNumber == true)
                {

                    Console.WriteLine("bravo t'arrive a comprendre que l'on te demande un chiffre");
                    choix = int.Parse(maSaouler);

                }
                
                //choix = int.Parse(Console.ReadLine());
                // traitement des choix

                if (choix <= 2 && isNumber == true)
                /*(choix == 0 || choix == 1 || choix == 2)*/

                {
                    switch (choix)
                    {
                        case 1:
                            // choix de l'addition
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            // saisie de la réponse
                            while
                            {
                                try
                                {
                                    Console.Write(val1 + " + " + val2 + " = ");
                                    reponse = int.Parse(Console.ReadLine());
                                }
                                catch
                                {
                                    Console.WriteLine("saisissez un nombre entier !!");
                                }
                            }
                            // comparaison avec la bonne réponse
                            solution = val1 + val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                            }
                            break;

                        case 2:
                            // choix de la multiplication
                            val1 = rand.Next(1, 10);
                            val2 = rand.Next(1, 10);
                            // saisie de la réponse
                            Console.Write(val1 + " x " + val2 + " = ");
                            reponse = int.Parse(Console.ReadLine());
                            // comparaison avec la bonne réponse
                            solution = val1 * val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                            }
                            break;


                    }
                }
                else
                {
                    Console.WriteLine("choix indisponible apprend a lire sous merde !!!");
                }
            }
        }
    }
}
                /*if (choix != 0 )
                {
                    if (choix == 1)
                    {
                        // choix de l'addition
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " + " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());
                        // comparaison avec la bonne réponse
                        solution = val1 + val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " + " + val2 + " = " + solution);
                        }
                    }
                    else
                    {
                        // choix de la multiplication
                        val1 = rand.Next(1, 10);
                        val2 = rand.Next(1, 10);
                        // saisie de la réponse
                        Console.Write(val1 + " x " + val2 + " = ");
                        reponse = int.Parse(Console.ReadLine());
                        // comparaison avec la bonne réponse
                        solution = val1 * val2;
                        if (reponse == solution)
                        {
                            Console.WriteLine("Bravo !");
                        }
                        else
                        {
                            Console.WriteLine("Faux : " + val1 + " x " + val2 + " = " + solution);
                        }*/
                    
                
            
        
  
