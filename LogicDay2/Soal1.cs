using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    public class Soal1
    {
        public Soal1(int n)
        {
            Console.WriteLine("Ini respon soal 1");
            cetak(n);
        }

        static void cetak(int n)
        {
            //Baris
            for (int baris = 0; baris < n; baris++)
            {

                //Kolom
                for (int kolom = 0; kolom < n; kolom++)
                {
                    //Pindah Kolom
                    if (baris == kolom)
                    {
                        Console.Write(kolom * 2 + 1 + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                //Pindah Baris
                Console.WriteLine();
            }
        }
    }
}
