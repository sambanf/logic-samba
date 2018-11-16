using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace Logic1._5_2
{
    class Program
    {
        static Baselogic bs = new Baselogic();

        static void Main(string[] args)
        {
            Console.WriteLine("Soal 1");
            int n = 9;
            bs.jmlBaris = n;
            bs.jmlKolom = n;
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

            Console.Read();
        }

        static void isiarray()
        {
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    if (i==j)
                    {
                        bs.Array2d[i, j] = (j + 1).ToString();
                    }
                    else if (i+j==bs.jmlBaris-1)
                    {
                        bs.Array2d[i, j] = (j + 1).ToString();
                    }
                    
                }
            }
        }
        static void isiarray2()
        {
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    if (i==0 ||j ==0|| i==bs.jmlBaris-1 || j==bs.jmlBaris-1)
                    {
                        bs.Array2d[i, j] = (j*2+1).ToString();
                    }
                }
            }
        }
        static void isiarray3()
        {
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            Tools to = new Tools();
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    if (i == j)
                    {
                        bs.Array2d[i, j] = (j*2).ToString();
                    }
                    else if (i + j == bs.jmlBaris - 1)
                    {
                        bs.Array2d[i, j] = (j*2).ToString();
                    }
                    else if (i == 0 || j == 0 || i == bs.jmlBaris - 1 || j == bs.jmlBaris - 1)
                    {
                        bs.Array2d[i, j] = (j * 2).ToString();
                    }
                }
            }
        }
        static void isiarray4()
        {
            Tools to = new Tools();
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    if (i == 0 || j == 0 || i == bs.jmlBaris - 1 || j == bs.jmlBaris - 1 || i==bs.jmlBaris/2 ||j==bs.jmlBaris/2)
                    {
                        bs.Array2d[i, j] = to.Fibonacci(j).ToString();
                    }
                }
            }
        }
        static void isiarray5()
        {
            Tools to = new Tools();
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    if (i>=j&&i+j<=bs.jmlBaris-1)
                    {
                        bs.Array2d[i, j] = to.Tribonacci(j).ToString();
                    }
                    else if (i<=j&&i+j>=bs.jmlBaris-1)
                    {
                        bs.Array2d[i, j] = to.Tribonacci(j).ToString();
                    }
                }
            }
        }
        static void isiarray6()
        {
            Tools to = new Tools();
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    if (i <= j && i + j <= bs.jmlBaris - 1)
                    {
                        bs.Array2d[i, j] = to.Fibonacci(i).ToString();
                    }
                    else if (i >= j && i + j >= bs.jmlBaris - 1)
                    {
                        bs.Array2d[i, j] = to.Fibonacci(i).ToString();
                    }
                }
            }
        }
        static void isiarray7()
        {
            Tools to = new Tools();
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    if (i <= j && i + j <= bs.jmlBaris - 1 &&j>=bs.jmlBaris/2)
                    {
                        bs.Array2d[i, j] = to.Fibonacci(i).ToString();
                    }
                    else if (i >= j && i + j >= bs.jmlBaris - 1&& j <= bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = to.Fibonacci(bs.jmlKolom-1-i).ToString();
                    }
                    else if (i >= j && i + j <= bs.jmlBaris - 1 && i <= bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = to.Tribonacci(j).ToString();
                    }
                    else if (i <= j && i + j >= bs.jmlBaris - 1 && i >= bs.jmlBaris / 2)
                    {
                        bs.Array2d[i, j] = to.Tribonacci(bs.jmlKolom-1-j).ToString();
                    }
                }
            }
        }
    }
}
