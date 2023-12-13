using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Server : Computer, IConnectable
    {
        public Server(string ipAddress, int power, string os)
            : base(ipAddress, power, os)
        {
        }

        public void Connect(Computer target)
        {
            Console.WriteLine($"Server {IPAddress} connected to {target.IPAddress}");
        }

        public void Disconnect(Computer target)
        {
            Console.WriteLine($"Server {IPAddress} disconnected from {target.IPAddress}");
        }

        public void TransmitData(Computer target, string data)
        {
            Console.WriteLine($"Server {IPAddress} transmitted data to {target.IPAddress}: {data}");
        }
    }
}
