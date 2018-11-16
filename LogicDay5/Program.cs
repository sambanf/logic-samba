using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soal1 s1 = new Soal1();
            int i = int.Parse(Console.ReadLine());
            //Soal6 s6 = new Soal6(i);
            //Soal7 s7 = new Soal7(i);
            //Soal3 s3 = new Soal3(i);
            //Soal4 s4 = new Soal4(i);
            //Soal5 s5 = new Soal5(i);
            //Soal9 s9 = new Soal9(i);
            //Soal10 s10 = new Soal10(i);
            //PR01 p1 = new PR01(i);
            PR02 p2 = new PR02(i);
            Console.ReadKey();
        }
    }
}
