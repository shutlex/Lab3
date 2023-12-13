using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Ecosystem
    {
        private List<LivingOrganism> organisms;

        public Ecosystem()
        {
            organisms = new List<LivingOrganism>();
        }

        public void AddOrganism(LivingOrganism organism)
        {
            organisms.Add(organism);
        }

        public void SimulateEcosystem()
        {
            foreach (var organism in organisms)
            {
                if (organism is IReproducible)
                {
                    ((IReproducible)organism).Reproduce();
                }

                if (organism is IPredator)
                {
                    var potentialPrey = organisms
                        .Where(o => o != organism && o.Size < organism.Size)
                        .OrderByDescending(o => o.Energy)
                        .FirstOrDefault();

                    if (potentialPrey != null)
                    {
                        ((IPredator)organism).Hunt(potentialPrey);
                    }
                }
            }
        }
    }
}
