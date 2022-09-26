using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Car
    {
        public bool MotorAn { get; set; }
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }

        public Car(bool motorAn, int typeId, string make,string model, string typeName, string color, int speed)
        {
            MotorAn = motorAn;
            TypeId = typeId;
            Make = make;
            Model = model;
            TypeName = typeName;
            Color = color;
            Speed = speed;
        }
        public Car()
        {

        }

        public Car Motor_Starten(Car car)
        {           
            if (car.MotorAn)
            {
                Console.WriteLine("Motor ist bereits an");
            }
            else if (!car.MotorAn)
            {
                Console.WriteLine("Motor wird angemacht! VRUUUUUUUMMMM");
                car.MotorAn = true;
            }
            return car;
        }

    }

}
