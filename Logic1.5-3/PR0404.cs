using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace Logic1._5_3
{
    class PR0404
    {
        Baselogic bs = new Baselogic();
        public PR0404(int val)
        {
            Tools to = new Tools();
            bs.jmlBaris = 2;
            bs.jmlKolom = val;
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            IsiArray(val);
            Tools.printArray(bs.Array2d, true);
        }

        private void IsiArray(int val)
        {
            Tools to = new Tools();
            int prima = to.Prima(val);
            int fibo = to.Fibonacci(val);
            int tribo = to.Tribonacci(val);
            for (int kol = 0; kol < bs.jmlKolom; kol++)
            {
                bs.Array2d[0, kol] = to.Fibonacci(kol).ToString();
                bs.Array2d[1, kol] = getNine(to.Fibonacci(kol)).ToString();
            }
        }

        private int getNine(int kol)
        {
            if (kol.ToString().Contains('3'))
                return (int)999;
            return 0;
        }
    }
}
