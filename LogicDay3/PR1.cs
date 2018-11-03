using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay3
{
    class PR1
    {
        Baselogic bs = new Baselogic();
        public PR1(int val)
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
                    if (i%2==0 && j<=bs.jmlBaris/2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j).ToString();
                    }
                    else if (i % 2 == 0 && j > bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-j).ToString();
                    }
                    else if (j <= bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Tribonacci(j).ToString();
                    }
                    else if (j > bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = tools.Tribonacci(bs.jmlBaris - 1 - j).ToString();
                    }

                }
            }
        }
    }
}
