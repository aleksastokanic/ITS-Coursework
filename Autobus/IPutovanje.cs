
using System.Collections;

namespace _1._2
{
    // Ako implementiramo IEnumerable ovde u interfejsu umesto u klasi koja ga implementira
    // (za to nam ovde treba: using System.Collections) možemo proći kroz kolekciju koja se nalazi 
    // u klasi koja implementira ovaj interfejs a koju instanciramo preko interfejsa

    interface IPutovanje : IEnumerable
    {
        void usaoTurista(Turista t);
        int slobodnoSediste { get; }
    }
}
