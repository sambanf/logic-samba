using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamDay6
{
    class Program
    {
        static void Main(string[] args)
        {
            //NUMBER 1
            //int n = 9;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j==0)
            //        {
            //            Console.Write(i+1 + "\t");
            //        }
            //        else if (i==n-1)
            //        {
            //            Console.Write(n-j + "\t");
            //        }
            //        else if (i==j)
            //        {
            //            Console.Write(j + 1 + "\t");
            //        }
            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine("\n");
            //}
            //NUMBER2
            //int n = 9;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j==0)
            //        {
            //            Console.Write(n-i + "\t");
            //        }
            //        else if (i == j)
            //        {
            //            Console.Write(j+1 + "\t");
            //        }
            //        else if (i == n - 1)
            //        {
            //            Console.Write(j+1 + "\t");
            //        }

            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            ////NUMBER 3
            //int n = 9;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == 0)
            //        {
            //            Console.Write(i+1 + "\t");
            //        }
            //        else if (i == j)
            //        {
            //            Console.Write(n-j + "\t");
            //        }
            //        else if (i == n - 1)
            //        {
            //            Console.Write(j+1 + "\t");
            //        }

            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            ////NUMBER 4
            //int n = 9;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == 0)
            //        {
            //            Console.Write(n - i + "\t");
            //        }
            //        else if (i == j)
            //        {
            //            Console.Write(n-j + "\t");
            //        }
            //        else if (i == n - 1)
            //        {
            //            Console.Write(n-j + "\t");
            //        }

            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //NUMBER 5
            //int n = 9;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == 0)
            //        {
            //            Console.Write(j+1 + "\t");
            //        }
            //        else if (i == j && j<n-1)
            //        {
            //            Console.Write(j + 1 + "\t");
            //        }
            //        else if (j == n - 1)
            //        {
            //            Console.Write(n-i + "\t");
            //        }

            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //NUMBER 6
            //int n = 9;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == 0)
            //        {
            //            Console.Write(n - j + "\t");
            //        }
            //        else if (i == j && j<n-1)
            //        {
            //            Console.Write(j + 1 + "\t");
            //        }
            //        else if (j == n - 1)
            //        {
            //            Console.Write(n-i + "\t");
            //        }

            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //NUMBER 7
            //int n = 9;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == 0)
            //        {
            //            Console.Write(j+1 + "\t");
            //        }
            //        else if (i + j ==n-1)
            //        {
            //            Console.Write(j + 1 + "\t");
            //        }
            //        else if (j == n - 1)
            //        {
            //            Console.Write(n - i + "\t");
            //        }

            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //NUMBER 8
            //int n = 9;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == n - 1)
            //        {
            //            Console.Write(n - i + "\t");
            //        }
            //        else if (i == 0 || i ==n-1 || j==0)
            //        {
            //            Console.Write(j+1 + "\t");
            //        }
            //        else if (i+j==n-1)
            //        {
            //            Console.Write(j + 1 + "\t");
            //        }
            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //NUMBER 9
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == n - 1)
            //        {
            //            Console.Write(n - i + "\t");
            //        }
            //        else if (i == 0)
            //        {
            //            Console.Write(j + 1 + "\t");
            //        }
            //        else if (i+j==n-1)
            //        {
            //            Console.Write(j + 1 + "\t");
            //        }
            //        else if (i<=j)
            //        {
            //            Console.Write("A\t");
            //        }
            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Number 10
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (j == n - 1)
            //        {
            //            Console.Write(n - i + "\t");
            //        }
            //        else if (i == 0)
            //        {
            //            Console.Write(j + 1 + "\t");
            //        }
            //        else if (i + j == n - 1)
            //        {
            //            Console.Write(j + 1 + "\t");
            //        }
            //        else if (i >= j)
            //        {
            //            Console.Write("A\t");
            //        }
            //        else
            //        {
            //            Console.Write("\t");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //NUMBER 12
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i==0 || i+j==n-1)
                    {
                        Console.Write(j+1 + "\t");
                    }
                    else if (j==n-1)
                    {
                        Console.Write(n-i + "\t");
                    }
                    else if (i<j && i+j<n-1)
                    {
                        Console.Write("A\t" );
                    }
                    else if (i > j && i + j > n - 1)
                    {
                        Console.Write("B\t");
                    }
                    else
                    {
                        Console.Write("\t");
                    }
                }
                Console.WriteLine("\n");
            }

            Console.Read();

        }
    }
}
