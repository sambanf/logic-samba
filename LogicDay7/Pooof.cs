using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay7
{
    class Pooof : Baselogic
    {
        Tools to = new Tools();
        public Pooof(int n)
        {
            jmlBaris = n;
            jmlKolom = to.Tribonacci(n);
            Array2d = new string[jmlBaris, jmlKolom];
            //Console.WriteLine(jmlBaris + "" + jmlKolom);
            isiarray(n);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n)
        {
            for (int b = 1; b <= n; b++)
            {
                //111359
                int stkol,endkol, stbar, endbar;
                endkol = jmlKolom;
                stkol = endkol - to.Tribonacci(b);
                stbar = 0;
                endbar = jmlBaris - b;
                Console.WriteLine(stkol);
                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = endkol - 1; j >= stkol; j--)
                    {
                        Array2d[i, j] = to.Tribonacci(i + 1).ToString();
                    }
                }
            }
            
        }
    }
}
