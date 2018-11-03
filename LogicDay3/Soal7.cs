using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay3
{
    class Soal7
    {
        Baselogic bs = new Baselogic();
        public Soal7(int val)
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
                    //atas
                    if (j >= i && i + j <= bs.jmlKolom - 1)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i).ToString();
                    }
                    //bawah
                    else if (j <= i && i + j >= bs.jmlKolom - 1)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlBaris-1-i).ToString();
                    }
                    //kanan
                    else if (j >= i && i + j >= bs.jmlKolom - 1)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlKolom-1-j).ToString();

                    }
                    //kiri
                    else if (j <= i && i + j <= bs.jmlKolom - 1)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j).ToString();
                    }
                }
            }
        }
    }
}
