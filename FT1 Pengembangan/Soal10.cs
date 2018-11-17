using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace FT1
{
    class Soal10 : Baselogic
    {
        Tools to = new Tools();
        public Soal10(int n)
        {
            jmlBaris = to.Deret(n + 1) - 1;
            jmlKolom = (n + 2) * 2;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n)
        {
            int maki = to.Deret(n)-1;
            //Console.WriteLine(maki);
            for (int i = 0; i < jmlKolom; i++)
            {
                for (int j = 0; j < jmlBaris; j++)
                {
                    if (j >= maki)
                    {
                        Array2d[j,i] = "*";
                    }
                }
                maki -= n--;
            }

        }
    }
}
