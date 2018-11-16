using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util;

namespace LogicDay7
{
    class Soal2 : Baselogic
    {
        public Soal2(int n1, int n2, int n3)
        {

            jmlBaris = n1;
            jmlKolom = (n2 * n3) + (n3 - 1);
            Array2d = new string[jmlBaris, jmlKolom];
            IsiArray(n1, n2, n3);
            Tools.printArray(Array2d, true);

        }

        private void IsiArray(int n1, int n2, int n3)
        {
            Console.WriteLine(jmlBaris +" " +jmlKolom);
            for (int b = 0; b < n3; b++)
            {
                
                Tools to = new Tools();
                int idx = 0;
                //start
                int stbar = 0;
                int stkol = (n2 + 1) * b;

                //end
                int endbar = n1;
                int endkol = stkol + n2;

                //atas
                for (int i = stbar; i < endbar; i++)
                {
                    for (int j = stkol; j < endkol; j++)
                    {
                        if (b % 2 == 0 && i ==stbar)
                        {
                            Array2d[i, j] = to.Tribonacci(idx).ToString();
                            idx++;
                        }
                        else if (i == stbar)
                        {
                            Array2d[i, j] = to.Fibonacci(idx).ToString();
                            
                            idx++;
                        }
                        
                    }
                }
                //kanan
                for (int i = stbar; i < endbar; i++)
                {
                    for (int j = stkol; j < endkol; j++)
                    {
                        if (b % 2 == 0 && j == endkol-1 && i>0)
                        {
                            Array2d[i, j] = to.Tribonacci(idx).ToString();
                            idx++;
                        }
                        else if (j == endkol - 1 && i > 0)
                        {
                            Array2d[i, j] = to.Fibonacci(idx).ToString();
                            
                            idx++;
                        }
                        
                    }
                }
                //bawah
                for (int i = stbar; i < endbar; i++)
                {
                    for (int j = stkol; j < endkol; j++)
                    {
                        if (b % 2 == 0 && i == endbar - 1 &&j>stkol)
                        {
                            Array2d[i, endkol - 1 - (j - stkol)] = to.Tribonacci(idx).ToString();
                            idx++;
                        }
                        else if (i == endbar - 1 && j >stkol)
                        {
                            Array2d[i, endkol - 1 - (j - stkol)] = to.Fibonacci(idx).ToString();
                            
                            idx++;
                        }

                    }
                }
                //kiri
                for (int i = stbar; i < endbar; i++)
                {
                    for (int j = stkol; j < endkol; j++)
                    {
                        if (b % 2 == 0 && j == stkol &&i<endbar-1 && i > stbar)
                        {
                            Array2d[endbar - 1 - (i - stbar), j] = to.Tribonacci(idx).ToString();
                            idx++;
                        }
                        else if (j == stkol && i < endbar - 1 && i > stbar)
                        {
                            Array2d[endbar - 1 - (i - stbar), j] = to.Fibonacci(idx).ToString();
                            
                            idx++;
                        }

                    }
                }

            }
        }
    }
}