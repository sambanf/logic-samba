using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    class Soal6
    {
        public Soal6(int n)
        {
            Console.WriteLine("Ini respon soal 6");
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j+i>=n-1)
                    {
                        Console.Write((n-i-1)*2+"\t");
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
