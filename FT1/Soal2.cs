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
                if (to.Fibonacci(i)%2==0)
                {
                    hasil = hasil + " + (" + -1*to.Fibonacci(i) + " )";
                }
                else
                {
                    hasil = hasil + " + " + to.Fibonacci(i);
                }
            }
            if (to.Fibonacci(y) % 2 == 0)
            {
                hasil = hasil + " + (" + -1 * to.Fibonacci(y) + " )";
            }
            else
            {
                hasil = hasil + " + " + to.Fibonacci(y);
            }
            if (to.Fibonacci(z) % 2 == 0)
            {
                hasil = hasil + " + (" + -1 * to.Fibonacci(z) + " )";
            }
            else
            {
                hasil = hasil + " + " + to.Fibonacci(z);
            }
            hasil = hasil + " = " + y;
            Console.WriteLine(hasil);
        }
    }
}
