using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pacijenti
{
    interface IAnaliza
    {
        int DodeliBroj();
        void analizaUzorka(int labJedinica, Pacijent p);
    }
}
