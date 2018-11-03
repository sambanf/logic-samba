using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    public class Program
    {
        public Program()
        {
            string jawab = "y";
            while (jawab != "t")
            {
                Console.WriteLine("Pilih soal : ");
                int soal = int.Parse(Console.ReadLine());
                Console.WriteLine("Masukan nilai n : ");
                int n = int.Parse(Console.ReadLine());
                switch (soal)
                {
                    case 1:
                        Soal1 s1 = new Soal1(n);
                        break;
                    case 2:
                        Soal2 s2 = new Soal2(n);
                        break;
                    case 3:
                        Soal3 s3 = new Soal3(n);
                        break;
                    case 4:
                        Soal4 s4 = new Soal4(n);
                        break;
                    case 5:
                        Soal5 s5 = new Soal5(n);
                        break;
                    case 6:
                        Soal6 s6 = new Soal6(n);
                        break;
                    case 7:
                        Soal7 s7 = new Soal7(n);
                        break;
                    case 8:
                        Soal8 s8 = new Soal8(n);
                        break;
                    case 9:
                        Soal9 s9 = new Soal9(n);
                        break;
                    case 10:
                        Soal10 s10 = new Soal10(n);
                        break;
                    case 11:
                        PRR1 prr = new PRR1(n);
                        break;
                    case 12:
                        PR pr = new PR(n);
                        break;
                    case 13:
                        PR2 pr2 = new PR2(n);
                        break;
                    case 14:
                        PRR2 prr2 = new PRR2(n);
                        break;
                    default:
                        Console.WriteLine("Soal belum tersedia");
                        break;
                }
                Console.WriteLine("Ingin melanjutkan Logic Day2?? (y/t)");
                jawab = Console.ReadLine();
                Console.Clear();
            }
        }
        static void Main(string[] args)
        {
           
        }
    }
}
