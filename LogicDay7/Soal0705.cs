using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay7
{
    class Soal0705 : Baselogic
    {
        Tools to = new Tools();
        public Soal0705(int n)
        {
            jmlBaris = n * 2 + 1;
            jmlKolom = to.DeretP(n * 2);
            //Console.WriteLine(jmlBaris+ " "+ jmlKolom);
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            for (int b = 1; b <= n; b++)
            {
                int ntk = (jmlKolom - 1) / 2;
                int ntb = (jmlBaris - 1) / 2;

                int stbar, stkol, endbar, endkol;
                stbar = (jmlBaris - 1) - (to.DeretP(b) + 1);
                stkol = ntk - (b * 2 - 1);
                
                endbar = (jmlBaris - 1);
                endkol = ntk + (b * 2 - 1);
                int idx = 1;
                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = stkol; j <= endkol; j++)
                    {
                        if (j == stkol || j == endkol)
                        {
                            Array2d[i, j] = (jmlBaris-i).ToString();
                        }
                        else if (i == stbar && j>stkol &&j<ntk)
                        {
                            Array2d[i, j] = idx++.ToString();
                        }
                        else if (i == stbar && j > stkol && j >= ntk)
                        {
                            Array2d[i, j] = idx--.ToString();
                        }
                    }
                }
            }
        }
    }
}
