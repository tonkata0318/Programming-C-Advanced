using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesMan
{
    public class Car
    {
        public string Model { get; set; }
        Engine Engine { get; set; }
        public int Weight { get; set; }
        public string Colour { get; set; }
        public Car(string model, Engine engine, int weight, string colour)
        {
            Model = model;
            Engine = engine;
            Weight = weight;
            Colour = colour;
        }

        public void ToString()
        {
            Console.WriteLine($"{Model}:");
            Console.WriteLine($"  {Engine.Model}:");
            Console.WriteLine($"    Power: {Engine.Power}");
            if (Engine.Displacement==0)
            {
                Console.WriteLine($"    Displacement: n/a");
            }
            else
            {
                Console.WriteLine($"    Displacement: {Engine.Displacement}");
            }
            if (Engine.Efficiency == null)
            {
                Console.WriteLine($"    Efficiency: n/a");
            }
            else
            {
                Console.WriteLine($"    Efficiency: {Engine.Efficiency}");
            }
            if (Weight == 0)
            {
                Console.WriteLine($"  Weight: n/a");
            }
            else
            {
                Console.WriteLine($"  Weight: {Weight}");
            }
            if (Colour == null)
            {
                Console.WriteLine($"  Color: n/a");
            }
            else
            {
                Console.WriteLine($"  Color: {Colour}");
            }
        }
    }
}
