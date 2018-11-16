using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay7
{
    class Soal0701 :Baselogic
    {
        Tools to = new Tools();
        public Soal0701(int n)
        {
            
            jmlBaris = n * 2 + to.DeretP(n);
            jmlKolom = n * 2 + to.DeretP(n);
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            int maka, maki;
            maka = (jmlKolom) / 2;
            maki = (jmlKolom) / 2;


            for (int i = 0; i < jmlBaris; i++)
            {
                for (int j = 0; j < jmlKolom; j++)
                {
                    if (j >= maki && j <= maka && i < n || j >= maki && j <= maka && i >(jmlBaris-1) - n)
                    {
                        Array2d[i, j] = "*";
                    }
                    else if (j >= maki && j <= maka && j <n || j >= maki && j <= maka && j > (jmlKolom - 1) - n)
                    {
                        Array2d[i, j] = "*";
                    }
                }
                if (i < (jmlBaris - 1) / 2)
                {
                    maki--;
                    maka++;
                }
                else
                {
                    maki++;
                    maka--;
                }
            }
        }
    }
}
