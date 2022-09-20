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
        //Seite 1 Aufgabe 5

            Console.WriteLine("Bitte gib mir mal wieder einen Text.");

            string text1 = Console.ReadLine();

            Console.WriteLine(text1.PadLeft(20, 'y'));

            Console.ReadKey();

         //Seite 1 Aufgabe 6

            Console.Clear();

            Console.WriteLine("Bitte gib mir mal wieder einen Text.");

            string text2 = Console.ReadLine();

            Console.WriteLine(text2.PadRight(30, 'y'));

            Console.ReadKey();

         //Seite 1 Aufgabe 7

            Console.Clear();

            Console.WriteLine("Bitte gib mir einen Text bei dem davor und danach leerzeichen sind.");

            string text3 = Console.ReadLine();

            Console.WriteLine(text3.Trim(' '));

        //Seite 1 Aufgabe 8

            Console.Clear();

            Console.WriteLine("Bitte gib mir einen Text mit Semicolons.");

            string text4 = Console.ReadLine();

            string[] strings = text4.Split(';');

            foreach (string s in strings)
            {
                Console.WriteLine(s);
            }











            Console.ReadKey();
        }
    }
}
