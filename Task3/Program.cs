using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Прохоренко Олександр";
            Road cityRoad = new Road(10, 20, 2);
            List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle("Car", 60, 2),
            new Vehicle("Bus", 40, 5),
            new Vehicle("Truck", 30, 8)
        };

            TrafficSimulation simulation = new TrafficSimulation();
            simulation.SimulateTraffic(cityRoad, vehicles);

            Console.ReadLine();
        }
    }
}
