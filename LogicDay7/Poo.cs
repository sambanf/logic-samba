using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay7
{
    class Poo : Baselogic
    {
        public Poo(int val)
        {
            jmlBaris = val;
            jmlKolom = val;
            Array2d = new string[jmlBaris, jmlKolom];
            isiArray(val);
            Tools.printArray(Array2d,true);
            Console.ReadLine();
        }
        void isiArray(int n)
        {
            Tools to = new Tools();
            //bangun atas bawah
            //int stBrs = 0;
            //int stKol = (n / 2) - 2;
            //int endBrs = n - 1;
            //int endKol = (n / 2) + 2;
            int mka, mki;
            mka = n / 2;
            mki = n / 2;
            int idx = 1;

            //Boolean Agar Switch
            bool kiri = true;

            for (int brs = 0; brs < n; brs++)
            {
                for (int kol = 0; kol < n; kol++)
                {
                    if (kol >= mki && kol <= mka)
                    {
                        //segitiga atas
                        if (brs <= 2)
                        {
                            Array2d[brs, kiri ? kol : n - kol - 1] = idx++.ToString();
                        }
                        //segitiga bawah
                        else if (brs >= n - 3)
                        {
                            Array2d[brs, kiri ? kol : n - kol - 1] = idx++.ToString();
                        }
                        //segitiga kiri
                        else if (kol <= 2)
                        {
                            Array2d[brs, kol] = to.Fibonacci(kol).ToString();
                        }
                        //segitiga kanan
                        else if (kol >= n - 3)
                        {
                            Array2d[brs, kol] = "D";
                        }
                    }
                    //else if (kol >= mki && kol <= mka && brs >= (n - 1) / 2)
                    //    Array2D[brs, kol] = ("*\t");
                }
                //pindah baris
                kiri = !kiri;
                if (brs < n / 2)
                {
                    mka++;
                    mki--;
                }
                else
                {
                    mka--;
                    mki++;
                }
            }

        }
    }
}