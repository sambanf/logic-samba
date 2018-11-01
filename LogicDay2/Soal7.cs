using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    class Soal7
    {
        public Soal7(int n)
        {
            Console.WriteLine("Ini respon soal 7");
            
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //diagonal kiri ke kanan
                    if (i == j)
                    {
                        Console.Write("{0}\t", Convert.ToChar(65 + i));
                    }
                    //diagonal kanan ke kiri
                    else if (i + j == n - 1)
                    {
                        Console.Write("{0}\t", Convert.ToChar(65 + n - 1 - j));
                    }
                    //segitiga atas var A
                    else if (j>i && i+j<=n-1)
                    {
                        Console.Write(i+1+"\t");
                    }
                    //segitiga bawah var B
                    else if (j<i && i+j>=n-1)
                    {
                        Console.Write(n-i+"\t");
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
