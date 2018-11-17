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
            jmlKolom = z*4;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(y, z);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int y, int z)
        {
            for (int j = 0; j <=(jmlKolom - 1) / 2; j++)
            {
                if (j%2==0)
                {
                    Array2d[0, j] = "*";
                    Array2d[0, jmlKolom - 1 - j] = "*";
                }
                else
                {
                    Array2d[0, j] = y.ToString();
                    Array2d[0, jmlKolom - 1 - j] = y.ToString();
                    y -= 3;
                    
                }
                
            }
        }
    }
}
