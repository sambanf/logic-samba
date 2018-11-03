using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LogicDay2
{
    class PRR2
    {
        public PRR2(int n)
        {
            Util.Tools ut = new Util.Tools();
            Console.WriteLine("Ini respon PR no 2");
            int nt = (n - 1) / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //atas
                    if (j >= i && i + j <= n - 1 && j>=nt)
                    {
                        Console.Write(ut.Fibonacci(i)+"\t");
                    }
                    //bawah
                    else if (j < i && i + j >= n - 1 && j<=nt)
                    {
                        Console.Write(ut.Fibonacci(n-1-i) + "\t");
                    }
                    //kanan
                    else if (j > i && i + j > n - 1 && i>=nt)
                    {
                        Console.Write(ut.Fibonacci(n-1-j) + "\t");

                    }
                    //kiri
                    else if (j < i && i + j < n - 1 && i<=nt)
                    {
                        Console.Write(ut.Fibonacci(j) + "\t");

                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }
        }
    }
}
