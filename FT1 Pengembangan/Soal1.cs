using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace FT1
{
    class Soal1 : Baselogic
    {
        public Soal1(int n, int m)
        {
            jmlBaris = n;
            jmlKolom = n;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n, m);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n, int m)
        {
            Tools to = new Tools();
            int idx = 0;
            for (int i = n - 1; i >=0; i--)
            {

                if (idx % 2 == 0)
                {
                    Array2d[i, n - 1] = m.ToString();
                    m += n;
                }
                else
                {
                    Array2d[i, n - 1] = "*";
                }

                idx++;

            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i + j == n - 1 && i > 0 && j < n - 1)
                    {
                        if (idx % 2 == 0)
                        {
                            Array2d[i, j] = m.ToString();
                            m += n;
                        }
                        else
                        {
                            Array2d[i, j] = "*";
                        }
                        idx++;
                    }
                }
            }
            for (int j = 0; j < n-1; j++)
            {

                    if (idx % 2 == 0)
                    {
                        Array2d[n-1, j] = m.ToString();
                        m += n;
                    }
                    else
                    {
                        Array2d[n-1, j] = "*";
                    }
                idx++;

            }

            
        }
    }
}
