using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    class PR2
    {
        public PR2(int n)
        {
            Console.WriteLine("Ini respon PR no 3");
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
                    else if (j > i && i + j <= n - 1)
                    {
                        Console.Write("{0}\t", Convert.ToChar(65+i));
                    }
                    else if (j < i && i + j >= n - 1)
                    {
                        Console.Write("{0}\t", Convert.ToChar(65 + n-1-i));
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
