using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log = LogicDay1.Program;

namespace Base
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pilih Hari : ");
                int hari = int.Parse(Console.ReadLine());
                switch (hari)
                {
                    case 1:
                        log log1 = new log();
                        break;
                    case 2:
                        LogicDay2.Program log2 = new LogicDay2.Program();
                        break;
                    case 3:
                        LogicDay3.Program log3 = new LogicDay3.Program();
                        break;
                    default:
                        Console.WriteLine("Belum belum belum");
                        break;
                }
                //Keluar??
                Console.WriteLine("Lanjut??");
                string jawab = Console.ReadLine().ToLower();
                if (jawab == "t")
                {
                    break;
                }
                

            }
        }
    }
}
