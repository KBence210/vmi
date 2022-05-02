using System;
using System.Collections.Generic;
using System.Text;

namespace Termekeink
{
    class Aru
    {
        private string nev;
        private int nettoAr;
        private int afaKulcs;

        public Aru(string nev, int nettoAr, int afaKulcs)
        {
            this.nev = nev;
            this.nettoAr = nettoAr;
            this.afaKulcs = afaKulcs;
        }

        public int AfaKulcs
        {
            get { return afaKulcs; }
            set { afaKulcs = value; }
        }


        public int NettoAr
        {
            get { return nettoAr; }
            set { nettoAr = value; }
        }

        public int BruttoAr
        {
            get { return (int)(nettoAr * (1 + AfaKulcs / 100.0)); }
        }

        public string Nev
        {
            get { return nev; }
            set { nev = value; }
        }

        public override string ToString()
        {
            return $"Nev: {Nev}, brutto: {BruttoAr} Ft";
        }

        public void NettoAratNovel(int szazalek)
        {
            nettoAr *= (int)(1 + szazalek / 100.0);
        }

        public int BruttoAratOsszhasonlit(Aru masikAru)
        {
            if (BruttoAr > masikAru.BruttoAr)
            {
                return 1;
            }
            else if (BruttoAr < masikAru.BruttoAr)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
