using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay3
{
    class Soal5
    {
        Baselogic bs = new Baselogic();
        public Soal5(int val)
        {
            bs.jmlBaris = val;
            bs.jmlKolom = val;
            bs.Array2d = new string[bs.jmlBaris,bs.jmlKolom];
            isiarray();
            Tools.printArray(bs.Array2d, true);
        }
        

        private void isiarray()
        {
            Tools tools = new Tools();
            //baris
            for (int i = 0; i <bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    //kiri
                    if (j < i && i + j < bs.jmlKolom - 1)
                    {
                        Console.Write("\t");

                    }
                    else if (j>bs.jmlKolom/2)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(bs.jmlKolom-1-j).ToString();
                    }
                    else
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j).ToString();
                    }
                        
                }
            }
        }
    }
}
