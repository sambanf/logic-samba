using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay6
{
    class Soal8
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public Soal8(int val)
        {
            bs.jmlBaris = val * val;
            bs.jmlKolom = val * val;
            Console.WriteLine(bs.jmlBaris + " " + bs.jmlKolom);
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiArray(val);
            Tools.printArray(bs.Array2d, true);
            Console.ReadLine();
        }
        void isiArray(int n)
        {
            for (int b = 0; b < n; b++)
            {
                
                // Starting
                int stBrs = n * b;
                int stKol = n * b;

                // Ending
                int endBrs = stBrs + (n - 1);
                int endKol = stKol + (n - 1);

                // Margin
                int mKi = (stKol + endKol) / 2;
                int mKa = (stKol + endKol) / 2;


                for (int brs = stBrs; brs <= endBrs; brs++)
                {
                    //nilai awal
                    int angka = ((n + 1) / 2 * (b + 1));

                    for (int kol = stKol; kol <= endKol; kol++)
                    {
                        if (mKi <= kol && mKa >= kol)
                        {
                            if (kol < (stKol + endKol) / 2)

                                bs.Array2d[brs, kol] = (angka--).ToString();
                            else
                                bs.Array2d[brs, kol] = (angka++).ToString();

                        }
                    }
                    //Pindah baris
                    if (brs < (stBrs + endBrs) / 2)
                    {
                        mKi--; mKa++;
                    }
                    else
                    {
                        mKi++; mKa--;
                    }
                }


            }
        }
        
    }
}


