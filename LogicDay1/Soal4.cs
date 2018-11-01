using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LogicDay1
{
    class Soal4
    {
        public Soal4(int n)
        {
            Console.WriteLine("Ini respon soal 4");
            int nt = (n - 1) / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==nt || j==nt)
                    {
                        Console.Write(i +","+j+"\t");
                    }
                    else if (i==j)
                    {
                        Console.Write("*\t");
                    }
                    else if (i+j==n-1)
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
