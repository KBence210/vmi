using System;
using System.Collections.Generic;
using System.Text;

namespace Alkalmazott
{
    class Alkalmazott
    {
        private string nev;
        private int kor;
        private long fizetes;

        private static int nyugdijkorhatar = 65;

        public Alkalmazott(string nev, int kor, long fizetes)
        {
            this.nev = nev;
            this.kor = kor;
            this.fizetes = fizetes;
        }

        public Alkalmazott(string nev, int kor) : this(nev, kor, 10000 * kor)
        {

        }

        public int EvekszamaNyugdijig()
        {
            return nyugdijkorhatar - this.GetKor();
        }

        public override string ToString()
        {
            return GetNev() + ", " + GetKor() + ", fizetese: " + GetFizetes() + " Ft/ho, nyugdijig hatralevo evek szama: " + EvekszamaNyugdijig();
        }

        public static Alkalmazott FiatalabbAlkalmazott(Alkalmazott elsoAlkalmazott, Alkalmazott masodikAlkalmazott)
        {
            if (elsoAlkalmazott.EvekszamaNyugdijig() > masodikAlkalmazott.EvekszamaNyugdijig())
            {
                return elsoAlkalmazott;
            }
            else 
                return masodikAlkalmazott;
        }

        public string GetNev()
        {
            return nev;
        }

        public void SetNev(string nev)
        {
            this.nev = nev;
        }

        public int GetKor()
        {
            return kor;
        }

        public void SetKor(int age)
        {
            this.kor = age;
        }

        public long GetFizetes()
        {
            return fizetes;
        }

        public void SetFizetes(long salary)
        {
            this.fizetes = salary;
        }

        public static int GetNyugdijkorhatar()
        {
            return nyugdijkorhatar;
        }

        public static void SetNyugdijkorhatar(int age)
        {
            nyugdijkorhatar = age;
        }
    }
}
