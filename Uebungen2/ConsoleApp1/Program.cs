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
            Car car = new Car(false, 456778, "rtdfg", "fghjk", "rrfztghj", "gebl", 0);


            do
            {
                Console.WriteLine("Was möchtest du tun?");
                int op = Convert.ToInt32(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        car = Car.Motor_Starten(car)
                            ; break;

                    case 1:

                        break;

                }

            } while (true);

        }
    }
}
