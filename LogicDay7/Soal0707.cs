using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay7
{
    class Soal0707 : Baselogic
    {
        public Soal0707(int n)
        {
            jmlBaris = n;
            jmlKolom = (n * n) + (n - 1);
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

                endbar = n - 1;
                endkol = stkol + (n - 1);
                Console.WriteLine(stbar + " " + stkol + " " + endbar + " " + endkol);
                int idx = 1;
                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = stkol; j <= endkol; j++)
                    {
                        if (i==stbar)
                        {
                            Array2d[i, j] = idx++.ToString();
                        }
                        else if (j==endkol)
                        {
                            Array2d[i, j] = idx++.ToString();
                        }
                        
                    }
                    
                }
                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = stkol; j <= endkol; j++)
                    {
                        if (i == endbar && j<endkol)
                        {
                            Array2d[i, endkol - 1-(j-stkol)] = idx++.ToString();
                        }
                    }

                }
                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = stkol; j <= endkol; j++)
                    {
                        if (j == stkol && i>stbar && i<endbar)
                        {
                            Array2d[endbar - i, j] = idx++.ToString();
                        }
                    }

                }


                
            }
        }
    }
}
