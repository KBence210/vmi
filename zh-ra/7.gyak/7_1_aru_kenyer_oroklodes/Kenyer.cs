using System;
using System.Collections.Generic;
using System.Text;

namespace Termekeink
{
    class Kenyer:Aru
    {
        private double mennyiseg;

        public Kenyer(string nev, int nettoAr, 
            int afaKulcs, double mennyiseg) 
            : base(nev, nettoAr, afaKulcs)
        {
            this.mennyiseg = mennyiseg;
        }

        public double Mennyiseg
        {
            get { return mennyiseg; }
            set { mennyiseg = value; }
        }


        public double Egysegar
        {
            get { return BruttoAr / Mennyiseg; }
        }


        /*
Definiálja felül a ToString metódust. 
Az ősosztályban definiált metódushoz képest fűzze
hozzá az egységárat (bruttóár/mennyiség).
         */
        public override string ToString()
        {
            return base.ToString() + ", egysegar: " + Egysegar;
        }

        public static bool KenyereketOsszhasonlit(Kenyer egyik,
                    Kenyer masik)
        {
            return egyik.Egysegar > masik.Egysegar;
        }
    }
}
