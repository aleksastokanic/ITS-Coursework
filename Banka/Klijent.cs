
namespace Banka
{
    class Klijent
    {
        private string ime; private int godine;
        private int broj; // redni broj dobijen na redomatu
        public Klijent(string i, int g, int b)
        {
            ime = i; godine = g; broj = b;
        }

        public override string ToString()
        {
            return "Redni broj: " + broj + " = " + ime + " " + godine;
        }
    }
}
