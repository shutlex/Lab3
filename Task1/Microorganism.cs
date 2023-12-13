using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Microorganism : LivingOrganism, IReproducible
    {
        public string Strain { get; set; }

        public Microorganism(double energy, int age, double size, string strain)
            : base(energy, age, size)
        {
            Strain = strain;
        }

        public void Reproduce()
        {
            Console.WriteLine($"[{Strain}] Reproducing...");
        }
    }
}
