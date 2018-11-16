using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay7
{
    class Soal0802 : Baselogic
    {
        public Soal0802(int n)
        {
            jmlBaris = n * n;
            jmlKolom = n * n;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int val)
        {
            int ganjil = 1;
            for (int b = 0; b < val; b++)
            {
                int stB = val * b;
                int stK = jmlKolom - (val * (b + 1));

                int endB = stB + val - 1;
                int endK = stK + val - 1;
                bool kiri = true;
                for (int i = stB; i <= endB; i++)
                {
                    for (int j = stK; j <= endK; j++)
                    {
                        Array2d[i, kiri ? j : endK + stK - j] = ganjil.ToString();
                        ganjil += 2;
                    }
                    kiri = !kiri;
                }
            }
        }
    }
}
