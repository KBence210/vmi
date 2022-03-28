namespace testek
{
    class Teglatest : Hasab
    {
        //- adattagok az alap két oldalának tárolására
        private double a;
        private double b;

        public double AOldal
        {
            get { return a; }
        }

        public double BOldal
        {
            get { return b; }
        }

        //- konstruktor, amelyben mind a három adatát paraméterben megkapott értékkel inicializálja
        public Teglatest(double a, double b, double magassag)
            : base(magassag)
        {
            this.a = a;
            this.b = b;
        }

        //- legyen felüldefiniálva az örökölt alapterületet visszaadó metódus
        public override double Alapterulet()
        {
            return a * b;
        }

        //- metódus, amely string-be összefűzve adja vissza a téglatest alapjának oldalait és magasságát
        public override string ToString()
        {
            //return "a oldal: " + a + ", b oldal: " + b + ", magasság: " + Magassag;
            return $"a oldal: {AOldal}, b oldal: {BOldal}, magassag: {Magassag}, terfogat: {Terfogat():n3}";
        }
    }
}
