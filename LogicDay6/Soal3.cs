using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay6
{
    class Soal3
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public Soal3(int val)
        {
            bs.jmlBaris = val * val;
            bs.jmlKolom = val * 4 - 2;
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
                // nilai awal
                int fibo = to.Fibonacci(n * n);
                int idx = 0;
                int ganjil = 1;
                //Starting point
                int stBrs = n * b;
                int stKol = ((n * 2 - 1) * (b % 2));

                //ending point
                int endBrs = stBrs + (n - 1);
                int endKol = stKol + ((n * 2) - 2);

                //margin
                int markiri = (stKol + endKol) / 2;
                int markanan = (stKol + endKol) / 2;
                for (int brs = stBrs; brs <= endBrs; brs++)
                {
                    for (int kol = stKol; kol <= endKol; kol++)
                    {
                        if (markiri <= kol && markanan >= kol)
                        {
                            if (b % 2 == 0)
                            {
                                bs.Array2d[brs, kol] = to.Fibonacci(idx++).ToString();
                            }
                            else
                            {
                                bs.Array2d[brs, kol] = ganjil.ToString();
                                ganjil += 2;
                            }
                        }
                    }
                    //pindah baris
                    markiri--;
                    markanan++;
                }
                //pindah bangun
            }

        }
    }
}


