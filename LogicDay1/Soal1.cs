using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay1
{
    public class Soal1
    {
        public Soal1(int n)
        {
            Console.WriteLine("Ini respon soal 1");
            for (int baris = 0; baris < n; baris++)
            {
                for (int kolom = 0; kolom < n; kolom++)
                {
                    if (baris == kolom)
                    {
                        Console.Write(" *");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
