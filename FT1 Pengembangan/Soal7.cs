using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace FT1
{
    class Soal7 : Baselogic
    {
        public Soal7(int k, int l, int m)
        {
            jmlBaris = m;
            jmlKolom = (m * l) + l - 1;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(k, l, m);
            Tools.printArray(Array2d, true);
        }

        int gettr()
        {
            return 999;
        }
        void isiarray(int k, int l, int m)
        {
            for (int b = 0; b < l; b++)
            {
                int stbar, stkol, endbar, endkol;
                stbar = 0;
                stkol = b * (m + 1);
                endbar = jmlBaris - 1;
                endkol = stkol + m;
                int idxp = 1;
                int idx1, idx2;
                idx1 = 1;
                idx2 = 1;

                bool stat = true;

                for (int i = endbar; i > stbar; i--)
                {
                    for (int j = stkol; j < endkol - 1; j++)
                    {
                        if (i + j == endkol-1)
                        {
                            if (idx1%k==0)
                            {
                                gettr();
                            }
                            else
                            {
                            Array2d[i, j] = idx1.ToString();
                            idx1 += 2;

                            }

                        }
                    }
                }
                for (int i = stbar; i < endbar; i++)
                {
                    if (idx1 % k == 0)
                    {
                        gettr();
                    }
                    else
                    {
                        Array2d[i, endkol-1] = idx1.ToString();
                        idx1 += 2;

                    }
                }
                for (int j = endkol-1; j > stkol; j--)
                {
                    if (idx1%k==0)
                    {
                        gettr();
                    }
                    else
                    {
                    Array2d[endbar, j] = idx1.ToString();
                    idx1 += 2;

                    }
                }

            }

        }
    }
}
