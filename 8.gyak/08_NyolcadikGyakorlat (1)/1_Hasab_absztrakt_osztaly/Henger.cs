using System;

namespace testek
{
    class Henger : Hasab
    {
        //- sugar adattag
        private double sugar;

        public double Sugar
        {
            get { return sugar; }
        }

        //- konstruktor, amely paraméterben kapott sugár és magasság
        //értékekkel inicializálja az objektumot
        public Henger(double sugar, double magassag)
            : base(magassag)
        {
            this.sugar = sugar;
        }

        //- legyen felüldefiniálva az örökölt alapterületet visszaadó metódus
        public override double Alapterulet()
        {
            return sugar * sugar * Math.PI;
        }

        //- metódus, amely string-be összefűzve adja vissza a henger sugarát és magasságát
        public override string ToString()
        {
            //return "sugar: " + sugar + ", magassag: " + Magassag;
            //return "sugar: " + Sugar + ", magassag: " + Magassag + ", terfogat: " + String.Format("{0:n3}", Terfogat());
            return $"sugar: {Sugar}, magassag: {Magassag}, terfogat: {Terfogat():n3}";
        }
    }
}
