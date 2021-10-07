using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlinskaBoca
{
    class exPraznaTraka : Exception
    {
        public exPraznaTraka()
        {
            Console.WriteLine("\nIZUZETAK: Nema više boca!");
        }
    }
}
