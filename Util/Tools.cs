using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Tools
    {
        public int Prima(int n)
        {
            bool prima = true;
            int[] hasil = new int[n+1];
            int bilangan = 1000;
            int idx = 0;
            if (bilangan >= 2)
            {
                for (int i = 2; i <= bilangan; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if ((i % j) == 0)
                        {
                            prima = false;
                            break;
                        }
                    }

                    if (prima && idx <= n)
                    {
                        hasil[idx++] = i;
                    }
                    prima = true;
                }
            }
            return hasil[n];
        }


        public int Tribonacci(int term)
        {
            int a = 1;
            int b = 1;
            int c = 1;
            int result = 0;

            if (term == 1) result = a;
            if (term == 2) result = b;
            if (term == 3) result = c;

            while (term > 3)
            {
                result = a + b + c;
                a = b;
                b = c;
                c = result;
                term--;
            }

            return result;
        }

        public int Fibonacci(int n)
        {
            int a = 1;
            int b = 1;
            for (int i = 1; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
            }
            return a;
        }

        public static void printArray(string[,] array, bool role)
        {
            if (role)
            {
                Console.Write("\nB/K\t");
                for (int i = 0; i < array.GetLength(1); i++)
                {
                    Console.Write(i+"\t");
                }
            }
            Console.WriteLine("\n----------------------------------------------------------------------------------------------------------\n");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.Write(i+"\t");
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j]+"\t");
                }
                Console.WriteLine("\n");
            }
        }

        public int Deret(int n)
        {
            int result = 0;
            for (int i = 1; i <=n; i++)
            {
                result += i;
            }
            return result;
        }

        public int DeretP(int n)
        {
            int result = 0;
            int ganjil = 1;
            for (int i = 0; i < n; i++)
            {
                result = ganjil;
                ganjil += 2;
            }
            return result;
        }
    }
}
