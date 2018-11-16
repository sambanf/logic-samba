using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay5
{
    class Soal6
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public Soal6(int val)
        {
            bs.jmlBaris = to.Deret(val);
            bs.jmlKolom = to.Deret(val);
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiArray(val);
            Tools.printArray(bs.Array2d, true);
        }
        void isiArray(int val)
        {
            int ganjil = 1;
            int genap = 2;
            bool kiri = false;
            for (int bgn = 0; bgn < val; bgn++)
            {
                int stbar, stkol, endbar, endkol;
                stbar = to.Deret(bgn);
                stkol = to.Deret(bgn);

                endbar = stbar + bgn;
                endkol = stkol + bgn;
                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = stkol; j <= endkol; j++)
                    {
                        int kol1 = kiri ? j : endkol - (j - stkol);
                        if (bgn%2 ==0)
                        {
                            
                            bs.Array2d[i, kol1] = ganjil.ToString();
                            ganjil += 2;
                        }
                        else
                        {
                            bs.Array2d[i, kol1] = genap.ToString();
                            genap += 2;
                        }
                    }
                    kiri = !kiri;
                }
            }
        }

    }
}


