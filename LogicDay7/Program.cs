using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay7
{
    class Program
    {
        static void Main(string[] args)
        {

            //int n = int.Parse(Console.ReadLine());
            //Poo po = new Poo(n);
            //Soal1 s1 = new Soal1(n);
            int o = int.Parse(Console.ReadLine());
            //int p = int.Parse(Console.ReadLine());
            //int q = int.Parse(Console.ReadLine());
            //Soal2 s2 = new Soal2(o, p, q);
            //Soal0709 s72 = new Soal0709(n);
            Poof4 po = new Poof4(o);
            
            Console.Read();
        }
    }
}
