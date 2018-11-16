using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Util;

namespace LogicDay7
{
    public class Poof4 : Baselogic
    {
        public Poof4(int n)
        {
            jmlBaris = (n * 4) + 1;
            jmlKolom = (n * 4) + 1;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d,true);
        }

        private void isiarray(int n)
        {
            int idx = 1;
            for (int bb = 0; bb < 2; bb++)
            {
                for (int bk = 0; bk < 2; bk++)
                {
                    //strating
                    int stbaris = bb * n;
                    int stkolom = bk * n;

                    //ending
                    int enbaris = stbaris + (n - 1);
                    int enkolom = stkolom + (n - 1);

                    if (bb == bk)
                    {

                        for (int baris = stbaris; baris <= enbaris; baris++)
                        {
                            for (int kolom = stkolom; kolom <= enkolom; kolom++)
                            {
                                //kiri atas
                                Array2d[baris, kolom] = (idx).ToString();
                                //kanan bawah
                                Array2d[jmlBaris - 1 - baris, kolom] = idx.ToString();
                                //kanan atas
                                Array2d[baris, jmlKolom - 1 - kolom] = idx.ToString();
                                //kanan bawah
                                Array2d[jmlBaris - 1 - baris, jmlKolom - 1 - kolom] = idx.ToString();
                                idx++;
                            }
                        }
                    }
                }
                //pindah bangun
            }
        }

    }
}