using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Plant : LivingOrganism, IReproducible
    {
        public string Type { get; set; }

        public Plant(double energy, int age, double size, string type)
            : base(energy, age, size)
        {
            Type = type;
        }

        public void Reproduce()
        {
            Console.WriteLine($"[{Type}] Reproducing...");
        }
    }
}
