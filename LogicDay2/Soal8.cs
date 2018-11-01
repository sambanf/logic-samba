using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    class Soal8
    {
        public Soal8(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(i + j + 1 + "\t");
                    }
                    else if (i + j == n - 1)
                    {
                        Console.Write(j * 2 + "\t");
                    }
                    else if (j < i && i + j <= n - 1)
                    {
                        Console.Write("A\t");
                    }
                    else if (j > i && i + j >= n - 1)
                    {
                        Console.Write("B\t");
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
