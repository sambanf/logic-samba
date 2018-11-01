using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay1
{
    class PR
    {
        public PR(int n)
        {
            Console.WriteLine("Ini respon PR no 2");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i >= j && i + j <= n - 1)
                    {
                        Console.Write("*\t");
                    }
                    else if (i <= j && i + j >= n - 1)
                    {
                        Console.Write("*\t");
                    }
                    else if (i == 0 || i == n - 1)
                    {
                        Console.Write("*\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
