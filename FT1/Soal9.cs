using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace FT1
{
    class Soal9 : Baselogic
    {
        Tools to = new Tools();
        public Soal9(int n)
        {
            jmlBaris = n * 2;
            jmlKolom = to.DeretP(n);
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n)
        {
            int marka = jmlKolom-2;
            for (int i = 0; i < jmlBaris; i++)
            {
                for (int j = 0; j < jmlKolom; j++)
                {
                    if (j <= marka)
                    {
                        Array2d[i, j] = (i+1).ToString();
                        Array2d[jmlBaris-1-i, j] = (i + 1).ToString();
                    }
                }
                marka -= 2;
            }

        }
    }
}
