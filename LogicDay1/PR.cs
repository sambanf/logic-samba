using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay1
{
    class PR2
    {
        public PR2(int n)
        {
            Console.WriteLine("Ini respon PR no 1");

            int nt = (n - 1) / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i<=nt && j<=nt)
                    {
                        Console.Write("*\t");
                    }
                    else if (i>=nt && j>=nt)
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
