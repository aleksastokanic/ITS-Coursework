using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlinskaBoca
{
    class exNemaMesta : Exception
    {
        public exNemaMesta()
        {
            Console.WriteLine("\nIZUZETAK: Nema više mesta za boce!");
        }
    }
}
