using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Seite 4 Aufgabe 1

            //Console.WriteLine("Wie viele Einträge soll das Array haben?");

            //int i = Convert.ToInt32(Console.ReadLine());

            //double[] numbers = new double[i];

            //double sum1 = 0;
            //double sum2 = 0;
            //double sum3 = 0;

            //int counter = 0;

            //Console.Clear();

            //for (int j = 0; j < i; j++)
            //{
            //    Console.WriteLine($"Bitte gib mir die {j +1}. Zhl");
            //    numbers[j] = Convert.ToDouble(Console.ReadLine());
            //}

            //for (int j = 0; j < i; j++)
            //{
            //    sum1 += numbers[j];
            //}

            //foreach (double j in numbers)
            //{
            //    sum2 += j;
            //}

            //while (counter < i)
            //{
            //    sum3 += numbers[counter];
            //    counter++;
            //}
            //Console.Clear();

            //Console.WriteLine($"Die Lösung der for-Schleife ist {sum1}. " + 
            //    $"Die Lösung der foreach-Schleife ist {sum2}. " + 
            //    $"Die Lösung der while-Schleife ist {sum3}.");

            //Console.ReadKey();
            bool taschenrechner = true;


            do
            {
                string summe = Summe();

                if (summe.StartsWith("n"))
                {
                    taschenrechner = false;
                }

                string endsumme = summe.TrimStart('n');

                Console.WriteLine(endsumme);


            } while (taschenrechner);
            Console.ReadKey();
            


            
            



        }
        static string Summe()
        {
            bool error = false;
            double sum = 0;
            string summ = "";
            

            
                Console.WriteLine("Gebe mir eine Zahl");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Gebe mir eine zweite Zahl");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Was möchtest du mit den beiden Zahlen machen?( + , - , * , / , % , avg ");
                string input = Console.ReadLine();


                switch (input)
                {
                    case "+":
                        Console.Clear();
                        sum = num1 + num2;                        
                        break;

                    case "-":
                        Console.Clear();
                        sum = num1 - num2;
                        break;

                    case "*":
                        Console.Clear();
                        sum = num1 * num2;
                        break;

                    case "/":
                        Console.Clear();
                        sum = num1 / num2;
                        break;

                    case "%":
                        Console.Clear();
                        sum = num1 % num2;
                        break;

                    case "avg":
                        Console.Clear();
                        sum = (num1 + num2) / 2;

                        break;

                    default:
                        Console.WriteLine("Bitte gib einen validen operator ein.");
                        error = true;

                        break;
                }
                if (!error)
                {
                    if (input != "avg")
                    {
                        summ = $"{num1} {input} {num2} = {sum}";

                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Möchtest du noch etwas berechnen? (y/n)");
                        string another = Console.ReadLine();

                        if (another == "n")
                        { 
                            summ = $"n{summ}";
                        }
                    }
                    else
                    {
                        summ = $" Der Durchschnitt von {num1} und {num2} ist {sum}";

                        Console.ReadKey();
                        Console.Clear();

                        Console.WriteLine("Möchtest du noch etwas berechnen? (y/n)");
                        string another = Console.ReadLine();

                        if (another == "n")
                        {
                            summ = $"n{summ}";
                        }
                    }
                }
            return summ;
        }
    }
}
