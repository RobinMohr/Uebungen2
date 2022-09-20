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
            //Seite 3 Aufgabe 1
            do
            {
                Console.Clear();

                Console.WriteLine("Wie ist dein Name?");
                string name = Console.ReadLine();

                if (name == " ")
                {
                    Console.WriteLine("Hast du keinen Namen?");
                    return;
                }
                else if (name != " ")
                {
                    Console.WriteLine("Willst du das als deinen Namen festlegen?(y/n)");
                    string auswahl = Console.ReadLine();

                    if (auswahl == "y")
                    {
                        string[] splitted = name.Split('a');

                        Console.WriteLine($"Dein Name hat {splitted.Length - 1} a's.");

                        Console.WriteLine("Gib mir bitte 2 Zahlen nacheinander");
                        int num1 = Convert.ToInt32(Console.ReadLine());
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        if (num1 < num2)
                        {
                            Console.WriteLine($"Von deinen Ausgewählten Zahlen ist die {num2} Größer.");
                            break;
                        }
                        else if (num1 == num2)
                        {
                            Console.WriteLine("Deine Ausgewählten Zahlen sind gleich groß");
                            break;
                        }
                        else
                        {
                            Console.WriteLine($"Von deinen Ausgewählten Zahlen ist die {num1} Größer.");
                            break;
                        }
                    }
                }

                Console.ReadKey();

            } while (true);
            
            Console.ReadKey();

            //Seite 3 Aufgabe 2

            Console.WriteLine("Bitte gib eine Anzahl von sekunde an, ich werde diese dann in (d,h,m,s) umwandeln.");

            int seconds = Convert.ToInt32(Console.ReadLine());

            int minutes = seconds / 60;
            int a_seconds = seconds % 60;

            int hours = minutes / 60;
            int a_minutes = minutes % 60;

            int days = hours / 60;
            int a_hours = hours % 60;
                        
            int a_days = days % 60;

            Console.WriteLine($"Umgewandelt sind es {a_days} Tage, {a_hours} Stunden, {a_minutes} Minuten und {a_seconds} Sekunden.");

            Console.ReadKey();

            //Seite 3 Aufgabe 3

            string text1 = "MissiSsiPpi";

            int m = 0;
            int i = 0;
            int s = 0;
            int p = 0;
            
            foreach (char c in text1.ToLower())
            {
                if (c == 'm')
                {
                    m++;
                }

                else if (c == 'i')
                {
                    i++;
                }

                else if (c == 's')
                {
                    s++;
                }

                else if (c == 'p')
                {
                    p++;
                }
            }

            Console.WriteLine($"Das Wort Mississippi hat {m} m's, {i} i's, {s} s's und {p} p's.");

            Console.ReadKey();

            

        }
    }
}
