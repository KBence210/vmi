using szinezheto;

namespace pontok
{
    class SzinesPont : Pont, ISzinezheto
    {
        public enum Szinek { PIROS, ZOLD, KEK, SARGA, FEKETE };

        //(amely ha már csinált Pont osztályt akkor származhat abból)
        //- legyen egy adata az alapértelmezett szín, értéke Color.GREEN
        const Szinek alapertelmezettSzin = Szinek.ZOLD;

        //- legyen szín adata
        Szinek szin;

        //- legyen konstruktora mindhárom adat megadására
        public SzinesPont(int x, int y, Szinek szin) : base(x, y)
        {
            Szin = szin;
        }

        //Paraméter nélküli konstruktor. A szín az alapértelmezett szín, a pont koordinátái: 0, 0
        public SzinesPont() : this(0, 0, alapertelmezettSzin)
        { }

        //Csak a szín paraméter megadásával inicializálja az adatokat. A pont koordinátái: 0, 0.
        public SzinesPont(Szinek szin) : this(0, 0, szin)
        { }

        //- legyen adatait string-ben visszaadó metódusa
        //(definiálja felül az Object-től örökölt ToString() metódust!)
        public override string ToString()
        {
            return base.ToString() + ", szín: " + szin;
        }

        //- implementálja az ISzinezheto interface-t
        #region ISzinezheto tagok
        public Szinek Szin
        {
            get
            {
                return szin;
            }
            set
            {
                szin = value;
            }
        }

        public Szinek AlapertelmezettSzin
        {
            get { return alapertelmezettSzin; }
        }
        #endregion
    }
}
