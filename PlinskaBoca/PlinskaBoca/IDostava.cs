
/*
 * Klasa Traka implementira intefejs IDostava, sa metodama:
Utovari (Boca b), Boca Istovari () i propertijem int SlobMesta, koji treba koristiti kao
indikator pri pokušaju utovara sledeće plinske boce iz kolekcije Boca (utovar boca je moguć
jedino ako ima slobodnih mesta).
Ukoliko pri pokušaju utovara nema više slobodnih mesta na traci, ispisati na konzoli
odgovarajuću poruku, kao i u slučaju da pri pokušaju istovara nema više boca na transportnoj
traci.
Pretpostaviti da je kapacitet transportne trake fiksan i poznat, a u cilju testiranja programa
pretpostaviti da iznosi 5.
*/
namespace PlinskaBoca
{
    interface IDostava
    {
        int SlobMesta { get; set; }

        void utovari(PlinskaBoca b);
        void istovari();
    }
}
