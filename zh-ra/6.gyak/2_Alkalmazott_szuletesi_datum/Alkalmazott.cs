using System;
using System.Collections.Generic;
using System.Text;

namespace Alkalmazott
{
    class Alkalmazott
    {
        private string nev;
        //private int kor;
        private DateTime szuletesNapja;
        private long fizetes;

        private static readonly int nyugdijkorhatar = 65;
        //private const int nyugdijkorhatar = 65;

        private static string[] honapokNevei;
        static Alkalmazott()
        {
            honapokNevei = new string[]
                { "januar", "februar", "marcius", "aprilis", "majus", "junius", "julius", "augusztus",
                  "szeptember", "oktober", "november", "december"};
        }

        public Alkalmazott(string nev, DateTime szuletesNapja, long fizetes)
        {
            this.nev = nev;
            //this.kor = kor;
            this.szuletesNapja = szuletesNapja;
            this.fizetes = fizetes;
        }

        public Alkalmazott(string nev, DateTime szuletesNapja) : this(nev, szuletesNapja, 10000 * (DateTime.Now.Year - szuletesNapja.Year))
        {

        }

        public Alkalmazott(string nev, int ev, int honap, int nap) 
            : this(nev, new DateTime(ev, honap, nap), 10000 * (DateTime.Now.Year - ev))
        {

        }

        public Alkalmazott(string nev, int ev, string honap, int nap)
        {
            this.nev = nev;

            int honapSzammal = HonapnevbolHonapszam(honap);

            if (honapSzammal == -1)
            {
                honapSzammal = 1;
            }

            this.szuletesNapja = new DateTime(ev, honapSzammal, nap);
            this.fizetes = 10000 * (DateTime.Now.Year - ev);
        }

        public int HonapnevbolHonapszam(string honapneve)
        {
            for (int i = 0; i < honapokNevei.Length; i++)
            {
                //if (honapokNevei[i].Equals(honapneve))
                //if (honapokNevei[i].Equals(honapneve, StringComparison.OrdinalIgnoreCase))
                //if (honapokNevei[i].ToLower().Equals(honapneve.ToLower()))
                if (String.Equals(honapokNevei[i], honapneve, StringComparison.OrdinalIgnoreCase))
                    return i + 1;
            }

            return -1;
        }

        public string HonapszambolHonapnev(int honaperteke)
        {
            if (honaperteke > 12 || honaperteke < 1)
            {
                return "hibas honapertek";
            }
            else
            {
                return honapokNevei[honaperteke - 1];
            }
        }

        public int EvekszamaNyugdijig()
        {
            return nyugdijkorhatar - this.GetKor();
        }

        public override string ToString()
        {
            return GetNev() + ", " + GetKor() + ", fizetese: " 
                + GetFizetes() + " Ft/ho, nyugdijig hatralevo evek szama: " 
                + EvekszamaNyugdijig();
        }

        public string ToString(string korVagySzuletesNappja)
        {
            string alkalmazottAdatai;

            switch (korVagySzuletesNappja)
            {
                case "kor":
                    alkalmazottAdatai = GetNev() + ", kora: " + GetKor() + " ev";
                    break;

                case "szuletesnapja":
                    alkalmazottAdatai = GetNev() + ", szuletett: " + GetMagyarSzuletesnap();
                    break;
                
                default:
                    alkalmazottAdatai = "hibas parameter";
                    break;
            }
            
            return alkalmazottAdatai;
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
            return DateTime.Now.Year - szuletesNapja.Year;
        }

        public DateTime GetSzuletesnap()
        {
            return szuletesNapja;
        }

        public string GetMagyarSzuletesnap()
        {
            int ev = szuletesNapja.Year;
            int honapszam = szuletesNapja.Month;
            string honapnev = HonapszambolHonapnev(honapszam);
            int nap = szuletesNapja.Day;
            //return ev + ". " + honapnev + " " + nap + ".";
            return $"{ev}. {honapnev} {nap}.";
        }

        public void SetSzuletesnap(DateTime szuletesnap)
        {
            this.szuletesNapja = szuletesnap;
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

    }
}
