using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Network
    {
        private List<Computer> computers;

        public Network()
        {
            computers = new List<Computer>();
        }

        public void AddComputer(Computer computer)
        {
            computers.Add(computer);
        }

        public void SimulateNetwork()
        {
            if (computers.Count < 2)
            {
                Console.WriteLine("Not enough computers in the network for simulation.");
                return;
            }

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Computer source = computers[random.Next(computers.Count)];
                Computer target = computers[random.Next(computers.Count)];

                if (source != target)
                {
                    if (source is IConnectable)
                    {
                        ((IConnectable)source).Connect(target);
                        ((IConnectable)source).TransmitData(target, "Sample Data");
                        ((IConnectable)source).Disconnect(target);
                    }
                }
            }
        }
    }
}
