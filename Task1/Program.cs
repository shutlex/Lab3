using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Прохоренко Олександр";
            Ecosystem ecosystem = new Ecosystem();

            Animal lion = new Animal(100, 5, 2, "Lion");
            Animal rabbit = new Animal(30, 1, 0.5, "Rabbit");
            Plant oakTree = new Plant(50, 10, 5, "Oak Tree");
            Microorganism bacteria = new Microorganism(10, 1, 0.01, "Bacteria");

            ecosystem.AddOrganism(lion);
            ecosystem.AddOrganism(rabbit);
            ecosystem.AddOrganism(oakTree);
            ecosystem.AddOrganism(bacteria);

            ecosystem.SimulateEcosystem();

            Console.ReadLine();
        }
    }
}
