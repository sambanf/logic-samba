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
            jmlKolom = (m*l) + l-1;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(k,l,m);
            Tools.printArray(Array2d, true);
        }

        string gettr(int n)
        {
            string hasil = n.ToString();
            for (int i = 1; i < n; i++)
            {
                hasil = hasil + n.ToString();
            }
            return hasil;
        }
        void isiarray(int k,int l, int m)
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

                for (int j = stkol; j < endkol; j++)
                {
                    if (idxp % k == 1)
                    {
                        Array2d[stbar, j] = idx1.ToString();
                        idx1 += 2 * k;
                        idxp++;
                    }
                    else if (idxp % k == 2)
                    {
                        Array2d[stbar, j] = idx2.ToString();
                        idx2 += k - 1;
                        idxp++;
                    }
                    else if (idxp % k == 0)
                    {
                        Array2d[stbar, j] = gettr(k);
                        idxp++;
                    }
                    
                }
                for (int i = stbar; i < endbar; i++)
                {
                    for (int j = stkol; j < endkol - 1; j++)
                    {
                        if (i + j == endkol - 1)
                        {
                            if (idxp % k == 1)
                            {
                                Array2d[i, j] = idx1.ToString();
                                idx1 += 2 * k;
                                idxp++;
                            }
                            else if (idxp % k == 2)
                            {
                                Array2d[i, j] = idx2.ToString();
                                idx2 += k - 1;
                                idxp++;
                            }
                            else if (idxp % k == 0)
                            {
                                Array2d[i, j] = gettr(k);
                                idxp++;
                            }
                            
                        }
                    }
                }
                for (int i = endbar ; i > stbar; i--)
                {
                    if (idxp % k == 1)
                    {
                        Array2d[i, stkol] = idx1.ToString();
                        idx1 += 2 * k;
                        idxp++;
                    }
                    else if (idxp % k == 2)
                    {
                        Array2d[i, stkol] = idx2.ToString();
                        idx2 += k - 1;
                        idxp++;
                    }
                    else if (idxp % k == 0)
                    {
                        Array2d[i, stkol] = gettr(k);
                        idxp++;
                    }
                    
                }

            }

        }
    }
}
