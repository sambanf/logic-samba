using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay3
{
    class Soal10
    {
        Baselogic bs = new Baselogic();
        public Soal10(int val)
        {
            bs.jmlBaris = val;
            bs.jmlKolom = val;
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiarray();
            Tools.printArray(bs.Array2d, true);
        }


        private void isiarray()
        {
            Tools tools = new Tools();
            //baris
            int[] fiboarray = new int[100];
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    //+++
                    if (i==bs.jmlBaris/2 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j/2).ToString();
                    }
                    else if (j == bs.jmlKolom / 2 && i % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i/2).ToString();
                    }
                    //atas
                    else if (j >= i && i + j <= bs.jmlKolom - 1 && i % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i / 2).ToString();
                    }
                    else if (j >= i && i + j <= bs.jmlKolom - 1)
                    {
                        bs.Array2d[i, j] = Convert.ToChar(65 + (i-1) / 2).ToString();
                    }
                    //bawah
                    else if (j <= i && i + j >= bs.jmlKolom - 1 && i % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci((bs.jmlKolom - 1 - i) / 2).ToString();
                    }
                    else if (j <= i && i + j >= bs.jmlKolom - 1)
                    {
                        bs.Array2d[i, j] = Convert.ToChar(65 + (bs.jmlKolom - 1 - i) / 2).ToString();
                    }
                    //kanan
                    else if (j >= i && i + j >= bs.jmlKolom - 1 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci((bs.jmlKolom - 1 - j) / 2).ToString();

                    }
                    else if (j >= i && i + j >= bs.jmlKolom - 1 )
                    {
                        bs.Array2d[i, j] = bs.Array2d[i, j] = Convert.ToChar(65 + ((bs.jmlKolom - 1 - j) / 2)).ToString();

                    }
                    //kiri
                    else if (j <= i && i + j <= bs.jmlKolom - 1 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j / 2).ToString();
                    }
                    else if (j <= i && i + j <= bs.jmlKolom - 1 )
                    {
                        bs.Array2d[i, j] = Convert.ToChar(65 + (j - 1) / 2).ToString();
                    }
                }
            }
        }
    }
}
