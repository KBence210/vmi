using System;
using System.Collections.Generic;
using System.Text;

namespace OtodikGyakTeglalap
{
    class Teglalap
    {
        private int aOldal;
        private int bOldal;

        public Teglalap(int aOldal, int bOldal)
        {
            //this.aOldal = aOldal;
            //this.bOldal = bOldal;
            SetTeglalap(aOldal, bOldal);
        }

        public Teglalap(int oldalhossz)
        {
            //this.aOldal = oldalhossz;
            //this.bOldal = oldalhossz;
            SetTeglalap(oldalhossz);
        }

        public int BOldal
        {
            get { return bOldal; }
            set { bOldal = value; }
        }

        public int AOldal
        {
            get { return aOldal; }
            set { aOldal = value; }
        }

        public int Terulet()
        {
            return aOldal * bOldal;
        }

        public override string ToString()
        {
            //return aOldal + ", " + bOldal + ": " + Terulet();
            //return AOldal + ", " + BOldal + ": " + Terulet();
            return $"{AOldal, 2}, {BOldal, 2}: {Terulet()}";
        }

        //SetSides, SetRectangle, BeallitTeglalap
        public void SetTeglalap(int aOldal, int bOldal)
        {
            this.aOldal = aOldal;
            this.bOldal = bOldal;
        }

        public void SetTeglalap(int oldalhossz)
        {
            //this.aOldal = oldalhossz;
            //this.bOldal = oldalhossz;
            SetTeglalap(oldalhossz, oldalhossz);
        }

        public bool NagyobbTeruletuMint(Teglalap masikTeglalap)
        {
            //if (Terulet() > masikTeglalap.Terulet())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            
            return Terulet() > masikTeglalap.Terulet();
        }

        //IsEqual
        public bool TeglalapOldalaiMegegyeznek(Teglalap masikTeglalap)
        {
            //return aOldal == masikTeglalap.aOldal
            //    && bOldal == masikTeglalap.bOldal;
            return (aOldal == masikTeglalap.aOldal && bOldal == masikTeglalap.bOldal) 
                    || (aOldal == masikTeglalap.bOldal && bOldal == masikTeglalap.aOldal);
        }
    }
}
