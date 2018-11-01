using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay3
{
    class Program
    { 
        public static int Tribonacci(int term)
        {
            int a = 1;
            int b = 1;
            int c = 1;
            int result = 0;

            if (term == 0) result = a;
            if (term == 1) result = b;
            if (term == 2) result = c;

            while (term > 2)
            {
                result = a + b + c;
                a = b;
                b = c;
                c = result;
                term--;
            }

            return result;
        }

        public static int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            // In N steps compute Fibonacci sequence iteratively.
            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }
        
        static void Main(string[] args)
        {
            const int n = 15;
            int[] fibo = new int[n];
            for (int i = 0; i < fibo.Length; i++)
            {
                fibo[i] = Tribonacci(i);
                Console.WriteLine(fibo[i]);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        Console.Write(Fibonacci(i)+"\t");
                    }
                    else if (i + j == n - 1)
                    {
                        Console.Write(Fibonacci(i) + "\t");
                    }
                    else if (j > i && i + j <= n - 1)
                    {
                        Console.Write(Tribonacci(i) + "\t");
                    }
                    else if (j < i && i + j >= n - 1)
                    {
                        Console.Write(Tribonacci(n-1-i) + "\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }

                Console.WriteLine("\n");
            }
            Console.ReadLine();
            
        }
    }
}
