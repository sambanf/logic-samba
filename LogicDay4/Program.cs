using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay4
{
    public class Program
    {
        public Program()
        {
            
        }

        static void Main(string[] args)
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
                    case 4:
                        Soal4 s4 = new Soal4(n);
                        break;
                    case 2:
                        Soal2 s2 = new Soal2(n);
                        break;
                    case 5:
                        Soal5 s5 = new Soal5(n);
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
    }
}
