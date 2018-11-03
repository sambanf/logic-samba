using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    class PR
    {
        public PR(int n)
        {
            Console.WriteLine("Ini respon PR no 4");
            int nt = (n - 1) / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //segitiga atas
                    if (j > i && i + j <= n - 1)
                    {
                        Console.Write("{0}\t", Convert.ToChar(65 + i));
                    }
                    //segitiga bawah
                    else if (j < i && i + j >= n - 1)
                    {
                        Console.Write("{0}\t", Convert.ToChar(65 + n - 1 - i));
                    }
                    else if (j<nt)
                    {
                        Console.Write("{0}\t", Convert.ToChar(65 + j));
                    }
                    else
                    {
                        Console.Write("{0}\t", Convert.ToChar(65 + n - 1 - j));
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
