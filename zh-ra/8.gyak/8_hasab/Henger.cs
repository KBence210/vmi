using System;
using System.Collections.Generic;
using System.Text;

namespace Testek
{
    class Henger : Hasab
    {
        private double sugar;

        public Henger(double sugar, int magassag) : base(magassag)
        {
            this.sugar = sugar;
        }

        public double Sugar
        {
            get { return sugar; }
            set { sugar = value; }
        }


        public override double Alapterulet()
        {
            return sugar * sugar * Math.PI;
        }

        public override string ToString()
        {
            return "sugar: " + Sugar + ", magassag: "
                    + Magassag + ", terfogat: " + Terfogat(); 
        }
    }
}
