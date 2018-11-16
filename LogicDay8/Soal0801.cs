using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay8
{
    public class Soal0801 : Baselogic
    {
        public Soal0801(int n, int m)
        {
            jmlBaris = 4;
            jmlKolom = n;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);

            Console.WriteLine("\n Output : {0}", Array2d[m-1,jmlKolom-1]);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            Tools to = new Tools();
            for (int j = 0; j <= n-1; j++)
            {
                Array2d[0, j] = to.Tribonacci(j).ToString();
            }
            for (int j = 0; j <= n-1; j++)
            {
                if (j*2%4==0)
                {
                    Array2d[1, j] = "999";
                }
                else
                {
                    Array2d[1, j] = (j * 2).ToString();         
                }
            }
            for (int j = 0; j <= n-1; j++)
            {
                int[] arraybantu = { 4, 8, 12 };
                Array2d[2, j] = arraybantu[j % 3].ToString();
            }
            for (int j = 0; j <= n - 1; j++)
            {
                Array2d[3, j] = (j % 2==0?"999":"1").ToString();
            }
        }
    }
}
