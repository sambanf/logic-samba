using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace FT1
{
    class Soal5 : Baselogic
    {
        public Soal5(int n, int m, int o)
        {
            jmlBaris = o * 3;
            jmlKolom = o * 3;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n, m, o);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n, int m, int o)
        {
            
            for (int b = 0; b < 3; b++)
            {
                
                for (int bk = 0; bk < 3; bk++)
                {
                    int stbar, stkol, endbar, endkol;
                    stbar = b * o;
                    stkol = bk * o;
                    endbar = stbar + o - 1;
                    endkol = stkol + o - 1;
                    //Console.WriteLine(stbar);
                    //Console.WriteLine(stkol);
                    //Console.WriteLine(endbar);
                    //Console.WriteLine(endkol);
                    
                    if (b == (o-1)/ 2 && b != bk || bk ==(o-1)/2 && b!=bk)
                    {
                        

                    }
                    else
                    {
                        int idx = n;
                        //atas
                        for (int j = stkol; j <= endkol; j++)
                        {
                            Array2d[stbar, j] = idx.ToString();
                            idx += m;
                        }
                        //kanan
                        for (int i = stbar + 1; i <= endbar; i++)
                        {
                            Array2d[i, endkol] = idx.ToString();
                            idx += m;
                        }
                        //bawah
                        for (int j = endkol - 1; j >= stkol; j--)
                        {
                            Array2d[endbar, j] = idx.ToString();
                            idx += m;
                        }
                        //kiri
                        for (int i = endbar - 1; i > stbar; i--)
                        {
                            Array2d[i, stkol] = idx.ToString();
                            idx += m;
                        }
                    }
                }
            }
        }
    }
}