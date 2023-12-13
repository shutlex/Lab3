using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Animal : LivingOrganism, IReproducible, IPredator
    {
        public string Species { get; set; }

        public Animal(double energy, int age, double size, string species)
            : base(energy, age, size)
        {
            Species = species;
        }

        public void Reproduce()
        {
            Console.WriteLine($"[{Species}] Reproducing...");
        }

        public void Hunt(LivingOrganism target)
        {
            Console.WriteLine($"[{Species}] Hunting...");
            
        }
    }
}
