using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Workstation : Computer, IConnectable
    {
        public Workstation(string ipAddress, int power, string os)
            : base(ipAddress, power, os)
        {
        }

        public void Connect(Computer target)
        {
            Console.WriteLine($"Workstation {IPAddress} connected to {target.IPAddress}");
        }

        public void Disconnect(Computer target)
        {
            Console.WriteLine($"Workstation {IPAddress} disconnected from {target.IPAddress}");
        }

        public void TransmitData(Computer target, string data)
        {
            Console.WriteLine($"Workstation {IPAddress} transmitted data to {target.IPAddress}: {data}");
        }
    }
}
