using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;
namespace LogicDay3
{
    class Soal8
    {
        //Jawaban soal 9 walau namanya soal8
        Baselogic bs = new Baselogic();
        public Soal8(int val)
        {
            bs.jmlBaris = val;
            bs.jmlKolom = val;
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiarray();
            Tools.printArray(bs.Array2d, true);
        }


        private void isiarray()
        {
            Tools tools = new Tools();
            //baris
            
            for (int i = 0; i < bs.jmlBaris; i++)
            {
                for (int j = 0; j < bs.jmlKolom; j++)
                {
                    //atas
                    if (j >= i && i + j <= bs.jmlKolom - 1 && i % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(i/2).ToString();
                    }
                    //bawah
                    else if (j <= i && i + j >= bs.jmlKolom - 1 && i % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci((bs.jmlKolom - 1 - i)/2).ToString();
                    }
                    //kanan
                    else if (j >= i && i + j >= bs.jmlKolom - 1 && j % 2 == 0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci((bs.jmlKolom - 1 - j)/2).ToString();

                    }
                    //kiri
                    else if (j <= i && i + j <= bs.jmlKolom - 1 && j%2==0)
                    {
                        bs.Array2d[i, j] = tools.Fibonacci(j / 2).ToString();
                    }
                }
            }
        }
    }
}
