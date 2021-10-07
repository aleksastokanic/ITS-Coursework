using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IKupovina
    {
        void dodajRacunar(Racunar r);

        double nadjiNajskuplji();

        void stampajRacun();
    }
}
