using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    class Soal10
    {
        public Soal10(int n)
        {
            Console.WriteLine("Ini respon soal 10");

            int nt = (n - 1) / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i <= nt)
                    {
                        Console.Write(i * 2  + "\t");
                    }
                    else
                    {
                        Console.Write((n - 1 - i) * 2  + "\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
