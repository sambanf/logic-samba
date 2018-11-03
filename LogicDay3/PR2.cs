using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay3
{
    class PR2
    {
        Baselogic bs = new Baselogic();
        public PR2(int val)
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
                    //Horizontal
                    if (i == bs.jmlBaris / 2 && j<=bs.jmlKolom/2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j).ToString();
                    }
                    else if (i == bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlKolom-1-j).ToString();
                    }
                    //Vertical
                    else if (j == bs.jmlKolom / 2 && i <= bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Tribonacci(i).ToString();
                    }
                    else if (j == bs.jmlKolom / 2)
                    {
                        bs.Array2d[i, j] = tools.Tribonacci(bs.jmlBaris-1-i).ToString();
                    }
                    //diag 1
                    else if (i==j && i <= bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j).ToString();
                    }
                    else if (i == j)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-i).ToString();
                    }
                    //diag 2
                    else if (i+j==bs.jmlKolom-1 && i <= bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Tribonacci(bs.jmlKolom-1-j).ToString();
                    }
                    else if (i + j == bs.jmlKolom - 1)
                    {
                        bs.Array2d[i, j] = tools.Tribonacci(j).ToString();
                    }
                    //atas kiri
                    else if (i<=bs.jmlBaris/2 && j<=bs.jmlKolom/2)
                    {
                        bs.Array2d[i, j] = "A";
                    }
                    //atas kanan
                    else if (i >= bs.jmlBaris / 2 && j <= bs.jmlKolom / 2)
                    {
                        bs.Array2d[i, j] = "B";
                    }
                    //bawah kanan
                    else if (i >= bs.jmlBaris / 2 && j >= bs.jmlKolom / 2)
                    {
                        bs.Array2d[i, j] = "C";
                    }
                    //bawah kiri
                    else if (i <= bs.jmlBaris / 2 && j >= bs.jmlKolom / 2)
                    {
                        bs.Array2d[i, j] = "D";
                    }
                }
            }
        }
    }
}
