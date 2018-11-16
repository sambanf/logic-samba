﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace Logic1._5_3
{
    class PR0405
    {
        Baselogic bs = new Baselogic();
        public PR0405(int val)
        {
            bs.jmlBaris = 2;
            bs.jmlKolom = val;
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            IsiArray(val);
            Tools.printArray(bs.Array2d,true);
        }

        private void IsiArray(int val)
        {
            Tools to = new Tools();
            int prima = to.Prima(val);
            int tribo = to.Tribonacci(val);
            for (int kol = 0; kol < bs.jmlKolom; kol++)
            {
                bs.Array2d[0, kol] = to.Tribonacci(kol).ToString();
                bs.Array2d[1, kol] = GetValue(to.Tribonacci(kol)).ToString();
            }
        }

        private int GetValue(int kol)
        {
            if (kol % 3 == 0)
                return (int)999;
            return 3;
        }
    }
}

