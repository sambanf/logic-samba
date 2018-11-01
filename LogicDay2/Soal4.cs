using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LogicDay2
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
                    if (i == j || j ==nt)
                    {
                        Console.Write(i*2+ 1 + "\t");
                    }
                    else if (i + j == n - 1 || i==nt)
                    {
                        Console.Write(j * 2 + "\t");
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
