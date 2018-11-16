using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay7
{
    class Poof3 : Baselogic //PR1
    {
        public Poof3(int val)
        {
            jmlBaris = val;
            jmlKolom = val * 2 - 1;
            Array2d = new string[jmlBaris, jmlKolom];
            Console.WriteLine(jmlBaris);
            Console.WriteLine(jmlKolom);
            isiarray(val);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            int idx = 0;
            int limit = 2;
            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Array2d[i, j] = Convert.ToChar((65) + idx).ToString();
                        Array2d[i, jmlKolom - 1 - j] = Convert.ToChar((65) + idx).ToString();
                        idx++;
                    }
                    else if (i >= limit + j)
                    {
                        Array2d[i, j] = "*";
                        Array2d[i, jmlKolom - 1 - j] = "*";
                    }
                    else if (j >= limit + i)
                    {
                        Array2d[i, j] = "*";
                        Array2d[i, jmlKolom - 1 - j] = "*";
                    }
                }
            }
        }
    }
}
