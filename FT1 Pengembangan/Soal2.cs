using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace FT1
{
    class Soal2
    {
        public Soal2(int x, int y, int z)
        {
            Tools to = new Tools();
            string hasil = to.Fibonacci(1).ToString();
            for (int i = 2; i <= x; i++)
            {
                    hasil = hasil + " + " + to.Fibonacci(i);

            }
            hasil = hasil + " + " + to.Fibonacci(y);
            hasil = hasil + " + " + to.Fibonacci(z);
            int haha = to.Fibonacci(1);
            for (int i = 2; i <= x; i++)
            {
                haha = haha + to.Fibonacci(i);

            }
            haha = haha + to.Fibonacci(y) + to.Fibonacci(z);
            hasil = hasil + " = " + haha;
            Console.WriteLine(hasil);
        }
    }
}
