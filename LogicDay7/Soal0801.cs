using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay7
{
    public class Soal0801 : Baselogic
    {
        public Soal0801(int n)
        {
            jmlBaris = n * n;
            jmlKolom = n * n;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }

        void isiarray(int n)
        {
            for (int bb = 0; bb < n; bb++)
            {
                for (int bk = 0; bk < n; bk++)
                {
                    if (bb == bk || bb + bk == n - 1)
                    {

                        // start
                        int stB = n * bb;
                        int stK = n * bk;

                        //end
                        int endB = stB + n - 1;
                        int endK = stK + n - 1;
                        int a = 1;
                        int b = n;

                        //garis atas
                        for (int j = stK; j < endK; j++)
                        {

                            for (int i = stB; i <= endB; i++)
                            {
                                if (j == stK)
                                {
                                    Array2d[j, i] = getvalue(a++).ToString();
                                }
                                else if (i + j == stB + endK)
                                {
                                    Array2d[j, i] = getvalue(a++).ToString();
                                }
                            }
                        }

                        //garis kiri
                        for (int i = endB; i > stB; i--)
                        {
                            Array2d[i, stK] = getvalue(a++).ToString();
                        }


                    }
                }
            }
        }
        int getvalue(int val)
        {
            if (val % 4 == 0)
            {
                return 999;

            }
            return val;
        }
    }
}