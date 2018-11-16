using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay4
{
    class Soal5
    {
        Baselogic bs = new Baselogic();
        public Soal5(int val)
        {
            bs.jmlBaris = val;
            bs.jmlKolom = val * 2 - 1;
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiarray();
            Tools.printArray(bs.Array2d, true);
        }


        private void isiarray()
        {
            // Baris
            for (int brs = 0; brs < bs.jmlBaris; brs++)
            {
                // Setiap pindah baris maka kembali ke 1
                int urut = 1;
                for (int kol = 0; kol < bs.jmlKolom; kol++)
                {
                    if (brs <= kol && brs + kol <= (bs.jmlBaris - 1) + (bs.jmlKolom - 1) / 2)
                    {
                        bs.Array2d[brs, kol] = Convert.ToChar(64+urut++).ToString();
                    }
                }
                // Pindah baris
            }
        }
    }
}
