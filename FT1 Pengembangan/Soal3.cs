using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace FT1
{
    class Soal3 : Baselogic
    {
        public Soal3(int n)
        {
            jmlBaris = 1;
            jmlKolom = n;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n)
        {
            int ang1 = 1;
            int ang2 = 3;
            for (int i = 0; i <= n - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Array2d[0, i] = ang1.ToString();
                    ang1 += 2;
                }
                else
                {
                    Array2d[0, i] = ang2.ToString();
                    ang2 += 3;
                }
            }
        }
    }
}
