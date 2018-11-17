using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace FT1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Masukan nomor soal :");
            int soal = int.Parse(Console.ReadLine());
            int m, n, o;
            switch (soal)
            {
                case 1:
                    Console.WriteLine("Soal {0}",soal);
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("m = ");
                    m = int.Parse(Console.ReadLine());
                    Soal1 s1 = new Soal1(n,m);
                    break;
                case 2:
                    Console.WriteLine("Soal {0}", soal);
                    Console.Write("x = ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("y = ");
                    m = int.Parse(Console.ReadLine());
                    Console.Write("z = ");
                    o = int.Parse(Console.ReadLine());
                    Soal2 s2 = new Soal2(n, m, o);
                    break;
                case 3:
                    Console.WriteLine("Soal {0}", soal);
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    Soal3 s3 = new Soal3(n);
                    break;
                case 4:
                    Console.WriteLine("Soal {0}", soal);
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    Soal4 s4 = new Soal4(n);
                    break;
                case 5:
                    Console.WriteLine("Soal {0}", soal);
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("m = ");
                    m = int.Parse(Console.ReadLine());
                    Console.Write("o = ");
                    o = int.Parse(Console.ReadLine());
                    Soal5 s5 = new Soal5(n, m, o);
                    break;
                case 6:
                    Console.WriteLine("Soal {0}", soal);
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    Soal6 s6 = new Soal6(n);
                    break;
                case 7:
                    Console.WriteLine("Soal {0}", soal);
                    Console.Write("k = ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("l = ");
                    m = int.Parse(Console.ReadLine());
                    Console.Write("m = ");
                    o = int.Parse(Console.ReadLine());
                    Soal7 s7 = new Soal7(n,m,o);
                    break;
                case 8:
                    Console.WriteLine("Soal {0}", soal);
                    Console.Write("y = ");
                    n = int.Parse(Console.ReadLine());
                    Console.Write("z = ");
                    m = int.Parse(Console.ReadLine());
                    Soal8 s8 = new Soal8(n, m);
                    break;
                case 9:
                    Console.WriteLine("Soal {0}", soal);
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    Soal9 s9 = new Soal9(n);
                    break;
                case 10:
                    Console.WriteLine("Soal {0}", soal);
                    Console.Write("n = ");
                    n = int.Parse(Console.ReadLine());
                    Soal10 s10 = new Soal10(n);
                    break;
                default:
                    break;
            }
            Console.Read();
        }
    }
}
