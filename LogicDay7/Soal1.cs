using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay7
{
    class Soal1 : Baselogic
    {
        public Soal1(int n)
        {
            jmlBaris = n * n;
            jmlKolom = n * n;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d,true);
        }

        private void isiarray(int n)
        {
            Tools to = new Tools();
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    int angka = 0;

                    //strating
                    int stbaris = bb * n;
                    int stkolom = bk * n;

                    //ending
                    int enbaris = stbaris + (n - 1);
                    int enkolom = stkolom + (n - 1);

                    if (bb == 0 || bk == 0 || bb + bk == n - 1)
                    {

                        for (int baris = stbaris; baris <= enbaris; baris++)
                        {
                            for (int kolom = stkolom; kolom <= enkolom; kolom++)
                            {
                                if (baris == stbaris || kolom == stkolom || baris + kolom <= stkolom + enbaris)
                                    Array2d[baris, kolom] = to.Fibonacci(angka++).ToString();
                            }
                        }
                        //pindah baris
                        angka++;
                    }
                }
            }
            //pindah bangun
        }
    }
}