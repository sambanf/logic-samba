using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay1
{
    class Post_Test
    {
        public Post_Test(int n)
        {
            Console.WriteLine("Ini respon post test");

            int nt = (n - 1) / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == nt)
                    {
                        Console.Write("*\t");
                    }
                    else if (i == j && i > nt)
                    {
                        Console.Write("*\t");
                    }
                    else if (i + j == n - 1 && i > nt)
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
