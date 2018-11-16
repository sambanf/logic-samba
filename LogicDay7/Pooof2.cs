using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay7
{
    class Pooof2 : Baselogic
    {
        Tools to = new Tools();
        public Pooof2(int n1, int n2)
        {
            jmlBaris = n1;
            jmlKolom = n1;
            Array2d = new string[jmlBaris, jmlKolom];
            //Console.WriteLine(jmlBaris + "" + jmlKolom);
            isiarray(n1, n2);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n1, int n2)
        {
            //Starting Point
            int stbar = 0;
            int stkol = 0;

            //End Point
            int endbar = n1 - 1;
            int endkol = n1 - 1;

            int idx = 1;
            //Spec
            for (int j = stkol; j < endkol; j++)
            {
                Array2d[stbar, j] = idx++.ToString();
            }
            while (stbar <endbar && stkol<endkol)
            {
                //Atas ke bawah
                for (int i = stbar; i <= endbar; i++)
                {
                    if (endbar-stbar>n2-1)
                    {
                        Array2d[i, endkol] = idx++.ToString();
                    }
                    
                }
                stbar += n2;
                //<-
                for (int j = endkol-1; j >= stkol; j--)
                {
                    if (endkol - stkol >= n2 - 1)
                    {
                        Array2d[endbar, j] = idx++.ToString();
                    }
                }
                endkol -= n2;
                //^
                for (int i = endbar-1; i >= stbar; i--)
                {
                    if (endbar - stbar > n2 - 1)
                    {
                        Array2d[i, stkol] = idx++.ToString();
                    }
                }
                endbar -= n2;
                //>>
                for (int j = stkol ; j <= endkol; j++)
                {
                    if (endkol - stkol > n2 - 1)
                    {
                        Array2d[stbar, j] = idx++.ToString();
                    }
                }
                stkol += n2;
            }

        }
    }
}
