using System;
using System.Collections.Generic;
using System.Text;

namespace Testek
{
    abstract class Hasab
    {
        private int magassag;

        public int Magassag
        {
            get { return magassag; }
            set { magassag = value; }
        }

        public Hasab(int magassag)
        {
            this.magassag = magassag;
        }

        abstract public double Alapterulet();

        public double Terfogat()
        {
            return Alapterulet() * Magassag;
        }

        public bool NagyobbTerfogatuMint(Hasab masikHasab)
        {
            return Terfogat() > masikHasab.Terfogat();
        }
    }
}
