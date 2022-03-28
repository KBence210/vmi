using szinezheto;
using static pontok.SzinesPont;

//Készítsen egy termekek.Toll osztályt, amely a korábbi termekek.Aru osztály leszármazottja
namespace termekek
{
    class Toll : Aru, ISzinezheto
    {
        //- legyen egy adata az alapértelmezett szín, értéke Color.GREEN
        //int alapertelmezettSzin = (int)Szinek.ZOLD; 
        //const pontok.SzinesPont.Szinek alapertelmezettSzin = pontok.SzinesPont.Szinek.ZOLD;
        const Szinek alapertelmezettSzin = Szinek.ZOLD;

        //- legyen még szín és márkanév adattagja
        Szinek szin;
        string markanev;

        //Konstruktor: három adatot kap paraméterként (márka, szín , ár), a termék megnevezése toll, az áfa
        public Toll(string markanev, Szinek szin, int nettoar) : base("toll", nettoar, 27)
        {
            this.markanev = markanev;
            this.szin = szin;
        }

        //- legyen adatait string-be összefűzve visszaadó metódusa,
        //definiálja felül a szülőtől örököltet úgy,
        //hogy fűzze hozzá az új adattagok értékeit.
        public override string ToString()
        {
            return base.ToString() + ", szín: " + szin + ", márkanév: " + markanev;
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
