using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay5
{
    class Soal1
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public Soal1()
        {
            int val = int.Parse(Console.ReadLine());
            int jb = to.Deret(val);
            Isiarray(val);
            Tools.printArray(bs.Array2d,true);
            
        }

        void Isiarray(int x)
        {
            for (int bgn = 0; bgn < x; bgn++)
            {
                int stbar, stkol, endbar, endkol;
                stbar = bgn * (bgn + 1) / 2;
                stkol = bgn * (bgn + 1) / 2;
                endbar = stbar + bgn;
                endkol = stkol + bgn;
                for (int i = stbar; i <=endbar; i++)
                {
                    for (int j = stkol; j <=endkol; j++)
                    {
                        bs.Array2d[i, j] = "*";
                    }
                }
            }
        }
        
        
        
    }
}
