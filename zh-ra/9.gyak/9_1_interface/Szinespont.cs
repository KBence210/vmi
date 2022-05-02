using System;
using System.Collections.Generic;
using System.Text;
using Szinezheto;

namespace Pontok
{
    //class Szinespont : Pont, Szinezheto.ISzinezheto
    class Szinespont : Pont, ISzinezheto
    {
        public enum Szinek { PIROS, ZOLD, KEK = 5, FEKETE}

        Szinek szin;
        const Szinek alapertelmezettSzin = Szinek.PIROS;

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

        public Szinespont():base(0, 0)
        {
            szin = alapertelmezettSzin;
        }

        public Szinespont(Szinek szin):base(0, 0)
        {
            this.szin = szin;
        }

        public Szinespont(int x, int y, Szinek szin) : base(x, y)
        {
            this.szin = szin;
        }

        public override string ToString()
        {
            return base.ToString() + ", szin: " + szin;
        }

        public Szinek GetSzin()
        {
            return Szin;
        }
    }
}
