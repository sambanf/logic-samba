using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tools = Util.Tools;
using Util;
namespace Logic1._5
{
    class Program
    {
        static Baselogic bs = new Baselogic();

        static void Main(string[] args)
        {
            Console.WriteLine("Soal 1");

            bs.jmlBaris = 1;
            bs.jmlKolom = 9;
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiarray();
            Tools.printArray(bs.Array2d, true);

            Console.WriteLine("Soal 2");
            isiarray2();
            Tools.printArray(bs.Array2d, true);

            Console.WriteLine("Soal 3");
            isiarray3();
            Tools.printArray(bs.Array2d, true);
            Console.WriteLine("Soal 4");
            isiarray4();
            Tools.printArray(bs.Array2d, true);
            Console.WriteLine("Soal 5");
            isiarray5();
            Tools.printArray(bs.Array2d, true);
            Console.WriteLine("Soal 6");
            isiarray6();
            Tools.printArray(bs.Array2d, true);
            Console.WriteLine("Soal 7");
            isiarray7();
            Tools.printArray(bs.Array2d, true);
            Console.WriteLine("Soal 8");
            isiarray8();
            Tools.printArray(bs.Array2d, true);
            Console.WriteLine("Soal 9");
            isiarray9();
            Tools.printArray(bs.Array2d, true);
            Console.WriteLine("Soal 10");
            isiarray10();
            Tools.printArray(bs.Array2d, true);
            Console.Read();
        }

        static void isiarray()
        {
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    bs.Array2d[i, j] = (j + 1).ToString();
                }
            }
        }
        static void isiarray2()
        {
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    bs.Array2d[i, j] = (j * 2 + 1).ToString();
                }
            }
        }
        static void isiarray3()
        {
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    bs.Array2d[i, j] = (j * 2).ToString();
                }
            }
        }
        static void isiarray4()
        {
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    bs.Array2d[i, j] = to.Fibonacci(j).ToString();
                }
            }
        }
        static void isiarray5()
        {
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    bs.Array2d[i, j] = to.Tribonacci(j).ToString();
                }
            }
        }
        static void isiarray6()
        {
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    bs.Array2d[i, j] = to.Prima(j).ToString();
                }
            }
        }
        static void isiarray7()
        {
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    bs.Array2d[i, j] = Convert.ToChar(65 + j).ToString();
                }
            }
        }
        static void isiarray8()
        {
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    if (j % 2 == 0)
                    {
                        bs.Array2d[i, j] = Convert.ToChar(65 + j).ToString();
                    }
                    else
                    {
                        bs.Array2d[i, j] = (j + 1).ToString();
                    }

                }
            }
        }
        static void isiarray9()
        {
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    if (j == 0)
                    {
                        bs.Array2d[i, j] = 1.ToString();
                    }
                    else
                    {
                        bs.Array2d[i, j] = (int.Parse(bs.Array2d[i, j - 1]) * 3).ToString();
                    }
                }
            }
        }
        static void isiarray10()
        {
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    bs.Array2d[i, j] = (Math.Pow(j, 3)).ToString();
                }
            }
        }


    }
}
