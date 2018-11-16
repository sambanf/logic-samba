using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay8
{
    class PR1001 : Baselogic
    {
        public PR1001(int n)
        {
            jmlBaris = (n * 4) + 1;
            jmlKolom = (n * 4) + 1;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            int idx = 1;
            for (int b = 0; b < 2; b++)
            {
                int stbaris = b * n;
                int stkolom = b * n;

                int enbaris = stbaris + (n - 1);
                int enkolom = stkolom + (n - 1);


                for (int i = stbaris; i <= enbaris; i++)
                {
                    for (int j = stkolom; j <= enkolom; j++)
                    {
                        Array2d[i, j] = (idx).ToString();
                        Array2d[jmlBaris - 1 - i, j] = idx.ToString();
                        Array2d[i, jmlKolom - 1 - j] = idx.ToString();
                        Array2d[jmlBaris - 1 - i, jmlKolom - 1 - j] = idx.ToString();
                        idx++;
                    }
                }

            }
        }
    }
}
