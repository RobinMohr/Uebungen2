using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        //Seite 2 Aufgabe: 1

            Console.WriteLine("Bitte gebe ein wie oft du die vorherige summe mit einer immer steigenden zahl addieren möchtest.");

            int i = Convert.ToInt32(Console.ReadLine());

            int sum = 0;

            for (int j = 0; j < i; j++)
            {
                sum = j + sum;
                Console.WriteLine(sum);
            }
            Console.ReadKey();

        //Seite 2 Aufgabe 2

            Console.Clear();

            Console.WriteLine("Bitte gib eine Zahl ein von der du rückwärts bis 0 zählen willst.");

            int num1 = Convert.ToInt32(Console.ReadLine());

            for (int j = 0; j < num1; num1--)
            {
                Console.WriteLine(num1);
            }

            Console.ReadKey();

        //Seite 2 Aufgabe 3

            Console.Clear();

            string[] names = { "Jonas", "Phillip", "Niklas", "Marcello", "Andreas", "Robin", "Robert", "Marie", "Leon", "Erwin", "Jan", "Mona", "Lukas", "Johannes" };
            int l = names.Length;

            Console.WriteLine("Nach welchem Buchstaben willst du in der Liste suchen?");
            string k = Console.ReadLine();

            for (int j = 0; j < l; j++)
            {
                if (names[j].Contains(k))
                {
                    Console.WriteLine(names[j]);
                }
            }

            Console.ReadKey();

        //Seite 2 Aufgabe 4

            Console.Clear ();

            Console.WriteLine("Wie viele plätze soll die Liste haben?");

            int q = Convert.ToInt32(Console.ReadLine());

            int[] array = new int[q];

            for (int w = 0; w < q; w++)
            {
                Console.WriteLine($"Bitte gib die {w + 1}. Zahl ein");
                array[w] = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
            }

            Console.WriteLine("Deine Liste enthält nun diese Zahlen:");
            foreach (int a in array)
            {
                Console.WriteLine(a);
            }

            Console.ReadKey();

        //Seite 2 Aufgabe 4b
            /*
            int min = array.Min();
            int max = array.Max();
            double avg = array.Average();
            */
            Console.WriteLine($"Der kleinste wert in der Liste ist {array.Min()}, der höchste Wert ist {array.Max()} und der Durchschnitt ist {array.Average()}.");

            Console.ReadKey();

            //Seite 2 Aufgabe 5

            int ö = 1;

            do
            {
                if ((ö % 3 == 0) && (ö % 5 == 0))
                {
                    Console.WriteLine("FIZZBUZZ");
                }

                else if (ö % 3 == 0)
                {
                    Console.WriteLine("FIZZ");
                }

                else if (ö % 5 == 0)
                {
                    Console.WriteLine("BUZZ");
                }

                else
                {
                    Console.WriteLine(ö);
                }

                ö++;

            } while (ö < 101);


            Console.ReadKey();
        }
    }
}
