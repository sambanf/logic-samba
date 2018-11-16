using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay8
{
    class Program
    {
        static void Main(string[] args)
        {
            int o = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            //Soal2 s2 = new Soal2(o, p, q);
            //Soal0709 s72 = new Soal0709(n);
            //Soal0801 s1 = new Soal0801(o,p);
            PR1002 p10 = new PR1002(o,p,q);

            Console.Read();
        }
    }
}
