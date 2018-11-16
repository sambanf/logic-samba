using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay7
{
    class Soal0706 : Baselogic
    {
        public Soal0706(int n)
        {
            jmlBaris = n;
            jmlKolom = (n*n)+(n-1);
            //Console.WriteLine(jmlBaris+ " "+ jmlKolom);
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            for (int b = 0; b < n; b++)
            {
                int stbar, stkol, endbar, endkol;
                stbar = 0;
                stkol = n * b + b;

                endbar = n-1;
                endkol = stkol + (n - 1);
                Console.WriteLine(stbar + " " + stkol + " " + endbar + " " + endkol);
                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = stkol; j <= endkol; j++)
                    {
                        if (i == stbar || i == endbar || j == stkol || j==endkol)
                        {
                            Array2d[i, j] = "*";
                        }
                    }
                }
            }
        }
    }
}
