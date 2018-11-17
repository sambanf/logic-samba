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
            for (int b = 0; b < n; b++)
            {
                int stkol, endkol;
                stkol = b * 2;
                endkol = stkol + 2;
                
                if (b%2==0)
                {
                    for (int i = 0; i < jmlBaris; i++)
                    {
                        for (int j = stkol; j < endkol; j++)
                        {
                            if (j % 2 == 0 && i == 1)
                            {
                                Array2d[i, j] = "";
                            }
                            else
                            {
                                Array2d[i, j] = "*";
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < jmlBaris; i++)
                    {
                        for (int j = stkol; j < endkol; j++)
                        {
                            if (j % 2 == 1 && i == 1)
                            {
                                Array2d[i, j] = "";
                            }
                            else
                            {
                                Array2d[i, j] = "*";
                            }
                        }
                    }
                }
                    
                
            }
        }
    }
}
