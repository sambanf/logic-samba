using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay6
{
    class PR01
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public PR01(int val)
        {
            bs.jmlBaris = val;
            bs.jmlKolom = val;
            Console.WriteLine(bs.jmlBaris + " " + bs.jmlKolom);
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiArray(val);
            Tools.printArray(bs.Array2d, true);
            Console.ReadLine();
        }
        void isiArray(int n)
        {
            //Bangun Atas Bawah
            int stBrs = 0;
            int stKol = (n / 2) - 2;
            int endBrs = n - 1;
            int endKol = (n / 2) + 2;
            int mka, mki;
            mka = n / 2;
            mki = n / 2;
            int idx = 1;
            for (int brs = stBrs; brs <= endBrs; brs++)
            {
                for (int kol = stKol; kol <= endKol; kol++)
                {
                    if (kol >= mki && kol <= mka && brs <= 2)
                    {
                        bs.Array2d[brs, kol] = idx++.ToString();
                    }
                    else if (kol >= mki && kol <= mka && brs >= n - 1 - 2)
                    {
                        bs.Array2d[brs, kol] = idx++.ToString();
                    }
                }
                if (brs <= 2)
                {
                    mki--;
                    mka++;
                }
                else if(brs>=n-2-2)
                {
                    mka--;
                    mki++;
                }
            }
            //Bangun Kiri
            stKol = 0;
            stBrs = (n / 2) - 2;
            endKol = 2;
            endBrs = (n / 2) + 2;
            mka = 2;
            mki = 2;
            idx = 0;
            for (int brs = stBrs; brs <= endBrs; brs++)
            {
                for (int kol = stKol; kol <= endKol; kol++)
                {
                    if (kol >= mki && kol <= mka && kol <= 2)
                    {
                        bs.Array2d[brs, kol] = to.Fibonacci(idx++).ToString();
                    }
                }
                if (brs<n/2)
                {
                    mki--;
                }
                else
                {
                    mki++;
                }
                
            }
            //Bangun Kanan
            stKol = n-1-2;
            stBrs = (n / 2) - 2;
            endKol = n-1;
            endBrs = (n / 2) + 2;
            mka = stKol;
            mki = stKol;
            idx = 0;
            for (int brs = stBrs; brs <= endBrs; brs++)
            {
                for (int kol = stKol; kol <= endKol; kol++)
                {
                    if (kol >= mki && kol <= mka && kol >= stKol)
                    {
                        bs.Array2d[brs, kol] = to.Tribonacci(idx++).ToString();
                    }
                }
                if (brs < n / 2)
                {
                    mka++;
                }
                else
                {
                    mka--;
                }

            }
        }
    }
}


