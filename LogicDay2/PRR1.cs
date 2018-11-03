using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDay2
{
    class PRR1
    {

        public PRR1(int n)
        {
            Console.WriteLine("Ini respon PR no 1");
            int nt = (n - 1) / 2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    //hori
                    if ((i == 0 || i==n-1)&&j<=nt)
                    {
                        Console.Write(j*2+1+"\t");
                    }
                    else if ((i == 0 || i == n - 1) && j > nt)
                    {
                        Console.Write((n-1-j) * 2 + 1 + "\t");
                    }
                    //verti
                    else if ((j == 0 || j == n - 1) && i <= nt)
                    {
                        Console.Write(i * 2 + 1 + "\t");
                    }
                    else if ((j == 0 || j == n - 1) && i > nt)
                    {
                        Console.Write((n - 1 - i) * 2 + 1 + "\t");
                    }
                    //atas
                    else if (j > i && i + j < n - 1)
                    {
                        Console.Write("A\t");
                    }
                    //bawah
                    else if (j < i && i + j > n - 1)
                    {
                        Console.Write("D\t");
                    }
                    //kanan
                    else if (j > i && i + j > n - 1)
                    {
                        Console.Write("C\t");

                    }
                    //kiri
                    else if (j < i && i + j < n - 1)
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
        }
    }
}
