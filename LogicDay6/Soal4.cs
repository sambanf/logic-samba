using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay6
{
    class Soal4
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public Soal4(int val)
        {
            bs.jmlBaris =  val* val;
            bs.jmlKolom = val * val;
            Console.WriteLine(bs.jmlBaris + " " + bs.jmlKolom);
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiArray(val);
            Tools.printArray(bs.Array2d, true);
            Console.ReadLine();
        }
        void isiArray(int n)
        {
            //Bangun
            int ganjil = 1;
            for (int b = 0; b < n; b++)
            {
                // nilai awal
                int fibo = to.Fibonacci(n * n);
                //Starting point
                int stBrs = n * b;
                int stKol = n * b;

                //ending point
                int endBrs = stBrs + (n - 1);
                int endKol = stKol + (n - 1);

                bool kiri = true;
                for (int brs = stBrs; brs <= endBrs; brs++)
                {
                    for (int kol = stKol; kol <= endKol; kol++)
                    {
                        if (kiri)
                        {
                            bs.Array2d[brs, kiri ? kol : endKol - (kol - stKol)] = ganjil.ToString();
                            ganjil += 2;
                        }
                        kiri = !kiri;
                    }
                    //pindah bangun
                }

            }
        }
    }
}


