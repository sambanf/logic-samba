using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace FT1
{
    class Soal4 : Baselogic
    {
        public Soal4(int n)
        {
            jmlBaris = 3;
            jmlKolom = n * 2;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            for (int b = 0; b < n-1; b++)
            {
                for (int i = 0; i < jmlBaris; i++)
                {
                    for (int j = 0; j < jmlKolom/2; j++)
                    {
                        if (j%2==0 && i ==1)
                        {
                            Array2d[i, j] = "";
                            Array2d[i, jmlKolom -1- j] = "";
                        }
                        else
                        {
                            Array2d[i, j] = "*";
                            Array2d[i, jmlKolom - 1- j] = "*";
                        }
                    }
                }
            }
        }
    }
}
