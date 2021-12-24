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
            double val1 = rand.Next(10, 100), val2 = rand.Next(10, 100); // mémorisation de nombres aléatoires
            double solution; // calcul de la solution
            double reponse; // saisie de la réponse de l'utilisateur
            
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
                Console.WriteLine("soustraction ................... 3");
                Console.WriteLine("division ....................... 4");
                Console.WriteLine("Quitter ........................ 0");
                Console.Write("Choix :                          ");
                maSaouler = Console.ReadLine();
                isNumber = int.TryParse(maSaouler, out n);
                
                if (isNumber == true)
                {

                    Console.WriteLine("");
                    choix = int.Parse(maSaouler);

                }

                //choix = int.Parse(Console.ReadLine());
                // traitement des choix
                // choix de l'addition
                
                if (choix <= 4 && isNumber == true)
                /*(choix == 0 || choix == 1 || choix == 2)*/

                {

                    // choix des valeurs aléatoire
                    val1 = rand.Next(1, 10);
                    val2 = rand.Next(1, 10);

                    switch (choix)
                    {
                        case 1:
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
                            break;

                        case 2:
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

                        case 3:
                            //choix de la soustraction
                            while (val1 < val2 == true)
                            {
                                val1 = rand.Next(10, 100);
                                val2 = rand.Next(10, 100);
                            }
                            //saisie de la réponse
                            Console.WriteLine(val1 + "-" + val2 + " = ");
                            reponse = int.Parse(Console.ReadLine());
                            // comparaison avec la bonne réponse
                            solution = val1 - val2;
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo !");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + "-" + val2 + " = " + solution);
                            }
                            break;

                        case 4:
                            //choix de la division
                            while (val1 < val2 == true)
                            {
                                val1 = rand.Next(10, 100);
                                val2 = rand.Next(10, 100);
                            }
                            //saisie de la réponse
                            Console.WriteLine(val1 + "/" + val2 + " = ");
                            reponse = Convert.ToDouble(Console.ReadLine());
                            reponse = Math.Round(reponse, 3);
                            //comparaison avec la bonne réponse
                            solution = val1 / val2;
                            solution = Math.Round(solution, 3);
                            if (reponse == solution)
                            {
                                Console.WriteLine("Bravo ! ");
                            }
                            else
                            {
                                Console.WriteLine("Faux : " + val1 + " / " + val2 + " = " + solution);
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
                    
                
            
        
  
