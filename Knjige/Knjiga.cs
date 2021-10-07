
namespace Knjige
{
    // Opis k u listi k:
    public class Knjiga   // Obavezno staviti public da bi delegat mogao biti postavljen u namespace!
    {
        public string Naslov;  // Naslov knjige.
        public string Autor;   // Autor knjige.
        public decimal Cena;   // Cena knjige.
        public bool Tvrdpovez; // Da li je tvrd povez?
        //public static int broj=0;

        public Knjiga(string naslov, string autor, decimal cena, bool tvrdPovez)
        {
            Naslov = naslov;
            Autor = autor;
            Cena = cena;
            Tvrdpovez = tvrdPovez;
        }

        public override string ToString()
        {
            return "" + Naslov;
        }
    }
}
