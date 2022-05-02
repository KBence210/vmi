using System;
using System.Collections.Generic;
using System.Text;

namespace Testek
{
    class Teglatest : Hasab
    {
        private double aOldal;
        private double bOldal;

        public double BOldal
        {
            get { return bOldal; }
            set { bOldal = value; }
        }

        public double AOldal
        {
            get { return aOldal; }
            set { aOldal = value; }
        }

        public Teglatest(double aOldal, double bOldal, int magassag)
            : base(magassag)
        {
            this.aOldal = aOldal;
            this.bOldal = bOldal;
        }

        public override double Alapterulet()
        {
            return AOldal * BOldal;
        }

        public override string ToString()
        {
            return "a: " + AOldal + ", b: " + BOldal + ", magassag: "
                    + Magassag + ", terfogat: " + Terfogat();
        }

    }
}
