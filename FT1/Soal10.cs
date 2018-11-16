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
            jmlBaris = (n+1)*2;
            jmlKolom = to.Deret(n+1)-1;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n)
        {
            int maki = to.Deret(n)-1;
            Console.WriteLine(maki);
            for (int i = 0; i < jmlBaris; i++)
            {
                for (int j = 0; j < jmlKolom; j++)
                {
                    if (j >= maki)
                    {
                        Array2d[i, j] = "*";
                    }
                }
                maki -= n--;
            }

        }
    }
}
