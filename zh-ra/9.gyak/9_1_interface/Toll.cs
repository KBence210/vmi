using Szinezheto;
using static Pontok.Szinespont;

namespace Termekek
{
    class Toll: Aru, ISzinezheto
    {
        string markanev;
        Szinek szin;
        const Szinek alapertelmezettSzin = Szinek.KEK;

        public Toll(string markanev, Szinek szin, int ar)
            :base("toll", ar, 27)
        {
            this.szin = szin;
            this.markanev = markanev;
        }

        public override string ToString()
        {
            return base.ToString() + ", szin: " + szin;
        }

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
            get
            {
                return alapertelmezettSzin;
            }
        }

        public Szinek GetSzin()
        {
            return Szin;
        }
    }
}
