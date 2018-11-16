using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay04
{
    class Soal9
    {
        Baselogic bs = new Baselogic();
        public Soal9(int val1, int val2)
        {
            bs.jmlBaris = val1;
            bs.jmlBaris = (val1 * val2) - (val2 - 1);
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            IsiArray(val2);
            Tools.printArray(bs.Array2d, true);
        }

        private void IsiArray(int jmlBgn)
        {
            // Bangun
            for (int bgn = 0; bgn < jmlBgn; bgn++)
            {
                //Starting point
                int stBrs = 0;
                int stKol = bgn * (JmlBaris - 1);

                //Ending Point
                int endBrs = JmlBaris - 1;
                int endKol = stKol + (JmlBaris - 1);

                //Margin
                int marKiri = (stKol + endKol) / 2;
                int marKanan = (stKol + endKol) / 2;

                //Baris
                for (int brs = stBrs; brs <= endBrs; brs++)
                {
                    int ganjil = 1;
                    for (int kol = stKol; kol <= endKol; kol++)
                    {
                        if (kol >= marKiri && kol <= marKanan)
                        {
                            Array2D[brs, kol] = ganjil.ToString();
                            if (kol < (stKol + endKol) / 2)
                                ganjil += 2;
                            else
                                ganjil -= 2;
                        }
                    }
                    // Pindah Baris
                    if (brs < JmlBaris / 2)
                    {
                        marKiri--;
                        marKanan++;
                    }
                    else
                    {
                        marKiri++;
                        marKanan--;
                    }
                }
                // Pindah Bangun
            }
        }
    }
}