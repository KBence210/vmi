using System;

namespace Termekek
{
    class Aru
    {
        //- legyen név, nettó ár (egész), áfakulcs (egész, százalék) adata
        string nev;
        int nettoAr;
        int afaKulcs;

        //- legyen egy csak olvasható tulajdonsága, amely visszaadja a bruttóárat (egész, kerekítve)
        public int bruttoAr
        {
            get { return Convert.ToInt32(nettoAr * (1 + afaKulcs / 100.0)); }
        }

        //- legyen konstruktora, amely mindhárom adata megadásával inicializálja az adatokat
        public Aru(string nev, int netto, int afa)
        {
            this.nev = nev;
            nettoAr = netto;
            afaKulcs = afa;
        }

        //- legyen metódusa, amely egy stringbe összefuzve vissza adja a nevet és a bruttó árat
        //(Definiálja felül az Object osztálybeli ToString metódust!)
        public override string ToString()
        {
            return "név: " + nev + ", bruttó ár: " + bruttoAr;
        }

        //- legyen metódusa, amely paraméterben megadott százalék értékkel növeli a nettó árat
        public void NettoAratNovel(int szazalek)
        {
            nettoAr = Convert.ToInt32(nettoAr * (1 + szazalek / 100.0));
        }

        //- legyen metódusa, amely 1-et ad, ha az arú drágább (buttóár), mint egy paraméterben kapott,
        //0-t ad, ha egyforma árúak és -1-et ad, ha a paraméterben kapott a drágább
        public int DragabbE(Aru masikAru)
        {
            if (bruttoAr > masikAru.bruttoAr)
            {
                return 1;
            }
            else if (bruttoAr == masikAru.bruttoAr)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }
}
