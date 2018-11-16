using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay7
{
    class Soal0702 : Baselogic
    {
        Tools to = new Tools();
        public Soal0702(int n)
        {

            jmlBaris = n * 2 + to.DeretP(n);
            jmlKolom = n * 2 + to.DeretP(n);
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            int maka, maki;
            maka = (jmlKolom) / 2;
            maki = (jmlKolom) / 2;

            int ganjil = 1;
            int idxf = 1;
            int idxt = 1;
            for (int i = 0; i < jmlBaris; i++)
            {
                for (int j = 0; j < jmlKolom; j++)
                {
                    if (j >= maki && j <= maka)
                    {
                        if (i < n)
                        {
                            Array2d[i, j] = ganjil.ToString();
                            ganjil += 2;
                        }
                        else if (i > (jmlBaris - 1) - n)
                        {
                            Array2d[i, j] = ganjil.ToString();
                            ganjil += 2;
                        }
                        else if (j < n)
                        {
                            Array2d[i, j] = to.Fibonacci(idxf).ToString();
                            idxf++;
                        }
                        else if (j > (jmlBaris - 1) - n)
                        {
                            Array2d[i, j] = to.Tribonacci(idxt).ToString();
                            idxt++;
                        }
                    }
                }
                if (i < (jmlBaris - 1) / 2)
                {
                    maki--;
                    maka++;
                }
                else
                {
                    maki++;
                    maka--;
                }
            }
        }
    }
}
