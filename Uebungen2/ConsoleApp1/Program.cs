using System;
using System.Collections.Generic;
using System.ComponentModel;
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
            //Seite 4 Aufgabe 1

            Console.WriteLine("Wie viele Einträge soll das Array haben?");

            int i = Convert.ToInt32(Console.ReadLine());

            double[] numbers = new double[i];

            double sum1 = 0;
            double sum2 = 0;
            double sum3 = 0;

            int counter = 0;

            Console.Clear();

            for (int j = 0; j < i; j++)
            {
                Console.WriteLine($"Bitte gib mir die {j +1}. Zhl");
                numbers[j] = Convert.ToDouble(Console.ReadLine());
            }

            for (int j = 0; j < i; j++)
            {
                sum1 += numbers[j];
            }

            foreach (double j in numbers)
            {
                sum2 += j;
            }

            while (counter < i)
            {
                sum3 += numbers[counter];
                counter++;
            }
            Console.Clear();

            Console.WriteLine($"Die Lösung der for-Schleife ist {sum1}. " + 
                $"Die Lösung der foreach-Schleife ist {sum2}. " + 
                $"Die Lösung der while-Schleife ist {sum3}.");

            Console.ReadKey();

        }
    }
}
