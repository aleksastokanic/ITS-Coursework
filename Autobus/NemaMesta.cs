using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1._2
{
    class NemaMesta:Exception
    {
        public NemaMesta() : base("Nema slobodnih mesta") { }
    }
}
