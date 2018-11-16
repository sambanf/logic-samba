using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace FT1
{
    class Soal6 : Baselogic
    {
        public Soal6(int n)
        {
            jmlBaris = n * n;
            jmlKolom = n * 2;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n)
        {
            for (int b = 0; b < n; b++)
            {
                int stbar, stkol, endbar, endkol;
                stbar = n * b;
                if (b%2==0)
                {
                    stkol = n;
                    endkol = jmlKolom - 1;
                }
                else
                {
                    stkol = 0;
                    endkol = (jmlKolom-1) / 2;
                }
                endbar = stbar + n - 1;

                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = stkol; j <= endkol; j++)
                    {
                        Array2d[i, j] = "*";
                    }
                }
            }
        }
    }
}
