using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay3
{
    class PR3
    {
        Baselogic bs = new Baselogic();
        public PR3(int val)
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

            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    //hori border
                    if (i==0 && j <= bs.jmlBaris /2 || i==bs.jmlBaris- 1 && j <= bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j).ToString();
                    }
                    else if (i == 0 && j > bs.jmlBaris / 2 || i == bs.jmlBaris - 1 && j > bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-j).ToString();
                    }
                    //verti border
                    else if (j==0 && i <= bs.jmlBaris / 2 || j==bs.jmlBaris-1  && i <= bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i).ToString();
                    }
                    else if (j == 0 && i > bs.jmlBaris / 2 || j == bs.jmlBaris - 1 && i > bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-i).ToString();
                    }
                    //hori in
                    else if (i==bs.jmlBaris/2 && j <= bs.jmlBaris / 2 &&j%2==0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i).ToString();
                    }
                    else if (i == bs.jmlBaris / 2 && j > bs.jmlBaris / 2 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-i).ToString();
                    }
                    //verti in
                    else if (j == bs.jmlBaris / 2 && i <= bs.jmlBaris / 2 && i % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j).ToString();
                    }
                    else if (j == bs.jmlBaris / 2 && i > bs.jmlBaris / 2 && i % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-j).ToString();
                    }
                    //diagonal kiri ke kanan
                    else if (i==j && i <bs.jmlBaris/2&& j%2==0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i).ToString();
                    }
                    else if (i == j && i > bs.jmlBaris / 2 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-i).ToString();
                    }
                    //diagonal kiri ke kanan
                    else if (i+j==bs.jmlBaris-1 && i < bs.jmlBaris / 2 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i).ToString();
                    }
                    else if (i + j == bs.jmlBaris - 1 && i > bs.jmlBaris / 2 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris - 1 - i).ToString();
                    }
                    //segitiga atas
                    else if (i % 2 == 0 && j >= i && i + j <= bs.jmlKolom - 1)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i).ToString();
                    }
                    //segitiga bawah
                    else if (j <= i && i + j >= bs.jmlKolom - 1 && i % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-i).ToString();
                    }
                    //segitiga kanan
                    else if (j >= i && i + j >= bs.jmlKolom - 1 && j % 2 == 0 && i<bs.jmlBaris/2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i).ToString();

                    }
                    else if (j >= i && i + j >= bs.jmlKolom - 1 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris - 1 - i).ToString();

                    }
                    //segitiga kiri
                    else if (j <= i && i + j <= bs.jmlKolom - 1 && j % 2 == 0 && i<bs.jmlBaris/2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i).ToString();
                    }
                    else if (j <= i && i + j <= bs.jmlKolom - 1 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-i).ToString();
                    }
                }
            }
        }
    }
}
