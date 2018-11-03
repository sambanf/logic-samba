using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay3
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
                    case 5:
                        Soal5 s5 = new Soal5(n);
                        break;
                    case 7:
                        Soal7 s7 = new Soal7(n);
                        break;
                    case 8:
                        Soal8 s8 = new Soal8(n);
                        break;
                    case 10:
                        Soal10 s10 = new Soal10(n);
                        break;
                    case 11:
                        PR1 pr1 = new PR1(n);
                        break;
                    case 12:
                        PR2 pr2 = new PR2(n);
                        break;
                    case 13:
                        PR3 pr3 = new PR3(n);
                        break;
                    default:
                        Console.WriteLine("Soal belum tersedia");
                        break;
                }
                Console.WriteLine("Ingin melanjutkan Logic Day3?? (y/t)");
                jawab = Console.ReadLine();
                Console.Clear();
            }
        }
        
        static void Main(string[] args)
        {
            
        }
    }
}
