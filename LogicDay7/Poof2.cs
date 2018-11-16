using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay7
{
    class Poof2 : Baselogic //Soal Destar
    {
        public Poof2(int m, int n, int o)
        {
            jmlBaris = (m * n) + (n - 1);
            jmlKolom = m * 2 + 1;
            Array2d = new string[jmlBaris, jmlKolom];
            Console.WriteLine(jmlBaris);
            Console.WriteLine(jmlKolom);
            isiarray(m, n, o);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int m, int n, int o)
        {
            for (int b = 0; b < n; b++)
            {
                int stbar, stkol, endbar, endkol;
                stbar = b * (m + 1);
                endbar = stbar + m - 1;
                if (b % 2 == 0)
                {
                    stkol = 0;
                }
                else
                {
                    stkol = m + 1;
                }
                endkol = stkol + m - 1;
                Console.WriteLine(stbar);
                Console.WriteLine(stkol);
                Console.WriteLine(endbar);
                Console.WriteLine(endkol);
                int idx = 1;
                for (int i = endbar; i >= stbar; i--)
                {
                    for (int j = stkol; j <= endkol; j++)
                    {
                        if (j==endkol)
                        {
                            
                            if (idx%o == 0)
                            {
                                Array2d[i, j] = getmod(idx++).ToString();
                            }
                            else
                            {
                                Array2d[i, j] = idx++.ToString();
                            }
                        }
                    }
                }
                for (int i = endbar; i >= stbar; i--)
                {
                    for (int j = endkol-1; j > stkol; j--)
                    {
                        if (i == stbar)
                        {
                            if (idx % o == 0)
                            {
                                Array2d[i, j] = getmod(idx++).ToString();
                            }
                            else
                            {
                                Array2d[i, j] = idx++.ToString();
                            }
                        }
                    }
                }
                for (int i = stbar; i<= endbar; i++)
                {
                    for (int j = stkol; j <=endkol; j++)
                    {
                        if (j == stkol)
                        {
                            if (idx % o == 0)
                            {
                                Array2d[i, j] = getmod(idx++).ToString();
                            }
                            else
                            {
                                Array2d[i, j] = idx++.ToString();
                            }
                        }
                    }
                }
                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = stkol +1; j < endkol; j++)
                    {
                        if (i == endbar)
                        {
                            if (idx % o == 0)
                            {
                                Array2d[i, j] = getmod(idx++).ToString();
                            }
                            else
                            {
                                Array2d[i, j] = idx++.ToString();
                            }
                        }
                    }
                }
            }

        }
        int haha;
        int getmod(int idx)
        {
            haha = -1 * idx * idx;
            return haha;
        }
    }
}
