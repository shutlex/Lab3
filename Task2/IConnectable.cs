using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    internal interface IConnectable
    {
        void Connect(Computer target);
        void Disconnect(Computer target);
        void TransmitData(Computer target, string data);
    }
}
