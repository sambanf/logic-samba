using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public class Tools
    {
        public int Tribonacci(int term)
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

        public int Fibonacci(int n)
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

    }
}
