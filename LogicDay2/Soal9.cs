using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    class Soal9
    {
        public Soal9(int n)
        {
            Console.WriteLine("Ini respon soal 9");

            int nt = (n - 1) / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j<=nt)
                    {
                        Console.Write(j*2+1+"\t");
                    }
                    else
                    {
                        Console.Write((n-1-j)*2+1+"\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
