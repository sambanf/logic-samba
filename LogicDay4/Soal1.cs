using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay4
{
    class Soal1
    {
        Baselogic bs = new Baselogic();
        public Soal1(int val)
        {
            bs.jmlBaris = val;
            bs.jmlKolom = val;
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiarray();
            Tools.printArray(bs.Array2d, true);
        }


        private void isiarray()
        {
            Tools tools = new Tools();
            //baris
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                int urut = 1;
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    //kiri
                    if (i+j>= (bs.jmlKolom-1)/2 && i+((bs.jmlKolom-1)/2)>=j&& i<=j +((bs.jmlKolom-1)/2) && i+j <=bs.jmlBaris-1+(bs.jmlKolom-1)/2) 
                    {
                        bs.Array2d[i, j] = (urut++).ToString();
                    }

                }
            }
        }
    }
}
