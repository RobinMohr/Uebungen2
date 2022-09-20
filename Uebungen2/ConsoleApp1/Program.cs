using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Seite 1 Aufgabe 1

            Console.WriteLine(2 + 5);

            Console.ReadKey();

         //Seite 1 Aufgabe 2

            Console.Clear();

            Console.WriteLine("Bitte gib mir zwei Zahlen nacheinander aus.");

            int num1 = Int32.Parse(Console.ReadLine());
            int num2 = Int32.Parse(Console.ReadLine());

            int sum1 = num1 + num2;

            Console.WriteLine(num1 + " + " + num2 + " = " + sum1);

            Console.ReadKey();

         //Seite 1 Aufgabe 3

            Console.Clear();

            Console.WriteLine("Bitte gib mir einen ganzen Text aus.");

            string text = Console.ReadLine();

            

            Console.WriteLine(text.Replace("u", "g").Replace("U", "G"));

            Console.ReadKey();

         //Seite 1 Aufgabe 4

            Console.Clear();

            Console.WriteLine("Bitte gib mir einen Text.");

            string text1 = Console.ReadLine();

            string[] entry = text1.Split(' ');

            int length = entry.Length;

            Console.WriteLine("Dein Text Hatte " + length + " Wörter.");

            Console.ReadKey();

            //Seite 1 Aufgabe 2b

            Console.Clear();

            Console.WriteLine("Bitte gib mir zwei Zahlen nacheinander aus.");

            float num3 = float.Parse(Console.ReadLine());
            float num4 = float.Parse(Console.ReadLine());

            float sum2 = num3 + num4;

            Console.WriteLine(num3 + " + " + num4 + " = " + sum2);

            Console.ReadKey();







            Console.ReadKey();
        }
    }
}
