using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay6
{
    class Soal9
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public Soal9(int val)
        {
            bs.jmlBaris = val + 2;
            bs.jmlKolom = to.Deret(val) + (val * 2);
            Console.WriteLine(bs.jmlBaris + " " + bs.jmlKolom);
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiArray(val);
            Tools.printArray(bs.Array2d, true);
            Console.ReadLine();
        }
        void isiArray(int n)
        {
            //Bangun
            for (int b = 0; b < n; b++)
            {
                //Starting point
                int stBrs = n - 1 - b;
                int endKol = bs.jmlKolom - 1 - (to.Deret(b) + (b * 2));
                //ending point
                int endBrs = n + 1;
                int stKol = endKol - (b + 2);

                for (int brs = stBrs; brs <= endBrs; brs++)
                {
                    for (int kol = stKol; kol <= endKol; kol++)
                    {
                        if (brs == stBrs)
                        {
                            bs.Array2d[brs, kol] = (bs.jmlKolom-(kol+1)).ToString();
                        }
                        else if (kol == stKol)
                        {
                            bs.Array2d[brs, kol] = (bs.jmlKolom - (kol + 1)).ToString();
                        }
                        if ((brs-stBrs+kol-stKol)==endBrs-stBrs)
                        {
                            bs.Array2d[brs, kol] = (bs.jmlKolom - (kol + 1)).ToString();
                        }
                    }
                    //pindah bangun
                }

            }
        }
    }
}


