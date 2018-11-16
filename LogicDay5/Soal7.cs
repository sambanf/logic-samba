using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay5
{
    class Soal7
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public Soal7(int val)
        {
            bs.jmlBaris = to.Deret(val);
            bs.jmlKolom = to.Deret(val);
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
                stkol = bs.jmlKolom - 1 - to.Deret(bgn);
                
                endbar = stbar + bgn;
                endkol = stkol - bgn;
                int ganjil = 1;
                for (int i = stbar; i <= endbar; i++)
                {
                    
                    for (int j = stkol; j >= endkol; j--)
                    {
                        bs.Array2d[i, (stkol+endkol)-j] = ganjil++.ToString();
                    }
                }
            }
        }

    }
}


