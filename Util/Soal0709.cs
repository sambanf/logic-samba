using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay7
{
    public class Soal0709 : Baselogic
    {
        public Soal0709(int n)
        {
            jmlBaris = n * n;
            jmlKolom = n * n;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            int angka = 1;
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    

                    //strating
                    int stbaris = bb * n;
                    int stkolom = bk * n;

                    //ending
                    int enbaris = stbaris + (n - 1);
                    int enkolom = stkolom + (n - 1);

                    if (bb == 0 || bk == 0 || bk ==n-1 ||bb ==n-1)
                    {
                        Tools to = new Tools();
                        for (int baris = stbaris; baris <= enbaris; baris++)
                        {
                            for (int kolom = stkolom; kolom <= enkolom; kolom++)
                            {
                                if (baris == enbaris || kolom == enkolom || baris + kolom >= stkolom + enbaris)
                                    Array2d[baris, kolom] = angka.ToString();
                            }

                        }
                        //pindah baris
                        angka++;
                    }
                }

            }

        }
    }
}
