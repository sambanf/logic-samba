using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace FT1
{
    class Soal8 :Baselogic
    {
        public Soal8(int y, int z)
        {
            jmlBaris = 1;
            jmlKolom = 2 + 4 *(z-1);
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(y, z);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int y, int z)
        {
            for (int j = (jmlKolom - 1) / 2; j >=0 ; j--)
            {
                if (j%2==0)
                {
                    if (y%2==0)
                    {
                        Array2d[0, j] =( y*(-1)).ToString();
                        Array2d[0, jmlKolom-1-j] = (y * (-1)).ToString();
                    }
                    else
                    {
                        Array2d[0, j] = y.ToString();
                        Array2d[0, jmlKolom - 1 - j] = y.ToString();
                    }
                    y -= 3;
                }
                else
                {
                    Array2d[0, j] = "*";
                    Array2d[0, jmlKolom-1-j] = "*";
                }
                
            }
        }
    }
}
