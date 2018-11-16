using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay5
{
    class Soal4
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public Soal4(int val)
        {
            bs.jmlBaris = to.Deret(val);
            bs.jmlKolom = val * val;
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiArray(val);
            Tools.printArray(bs.Array2d, true);
        }
        void isiArray(int val)
        {
            for (int bgn = 0; bgn < val; bgn++)
            {
                int stbar, stkol, endbar, endkol;
                stbar = to.Deret(bgn);
                endkol = bs.jmlKolom -(bgn*bgn)-1;

                endbar = to.Deret(bgn + 1) - 1;
                stkol = endkol-(2*bgn);
                Console.WriteLine("stbar" + stbar + "stkol"+stkol +"endbar" +endbar+"endkol"+endkol);
                int mka = (stkol + endkol) / 2;
                int mki = (stkol + endkol) / 2;
                for (int i = stbar; i <= endbar; i++)
                {
                    for (int j = stkol; j <= endkol; j++)
                    {
                        if (j >= mki && j <= mka)
                        {
                            bs.Array2d[i, j] = "*";
                        }
                    }
                    mka++;
                    mki--;

                }
            }
        }

    }
}


