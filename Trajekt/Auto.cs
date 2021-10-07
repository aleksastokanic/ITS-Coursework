
namespace Trajekt
{
    class Auto
    {
        string marka;
        string registracija;

        public Auto(string reg, string marka)
        {
            this.marka = marka;
            registracija = reg;
        }

        public override string ToString()
        {
            return "Reg: " + registracija + ", Marka: " + marka;
        }

    }
}
