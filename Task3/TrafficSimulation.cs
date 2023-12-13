using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class TrafficSimulation
    {
        public void SimulateTraffic(Road road, List<Vehicle> vehicles)
        {
            Console.WriteLine($"Road Information - Length: {road.Length} km, Width: {road.Width} m, Lanes: {road.Lanes}");

            foreach (var vehicle in vehicles)
            {
                double optimalSpeed = CalculateOptimalSpeed(road, vehicle.Size);
                Console.WriteLine($"{vehicle.Type} - Optimal Speed: {optimalSpeed} km/h");

                if (vehicle.Speed > optimalSpeed)
                {
                    Console.WriteLine($"Reducing speed of {vehicle.Type} due to traffic...");
                    vehicle.Speed = optimalSpeed;
                }

                vehicle.Move();
            }
        }

        private double CalculateOptimalSpeed(Road road, double vehicleSize)
        {
            // Простий алгоритм для розрахунку оптимальної швидкості в залежності від рівня трафіку та розміру транспортного засобу
            double optimalSpeed = road.Length / (road.TrafficLevel + 1) / (1 + vehicleSize / 10);
            return optimalSpeed;
        }
    }
}
