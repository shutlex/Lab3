using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Title = "Прохоренко Олександр";
            Network network = new Network();

            Server server = new Server("192.168.1.1", 1000, "Windows Server");
            Workstation workstation = new Workstation("192.168.1.2", 500, "Windows 10");
            Router router = new Router("192.168.1.3", 200, "RouterOS");

            network.AddComputer(server);
            network.AddComputer(workstation);
            network.AddComputer(router);

            network.SimulateNetwork();

            Console.ReadLine();
        }
    }
}
