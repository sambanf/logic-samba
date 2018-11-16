using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay5
{
    class PR02
    {
        Baselogic bs = new Baselogic();
        Tools to = new Tools();
        public PR02(int val)
        {
            bs.jmlBaris = val;
            bs.jmlKolom = val;
            bs.Array2d = new string[bs.jmlBaris, bs.jmlKolom];
            isiArray(val);
            Tools.printArray(bs.Array2d, true);
        }
        void isiArray(int val)
        {
            int idx = 1;
            for (int i = 0; i < val; i++)
            {
                for (int j = 0; j < val; j++)
                {
                    if (j==0)
                    {
                        bs.Array2d[i,j] = idx++.ToString();
                    }
                    else if (i==bs.jmlBaris-1)
                    {
                        bs.Array2d[i, j] = idx++.ToString();
                        if (j<bs.jmlBaris-1)
                        {
                            bs.Array2d[j, j] = (Convert.ToInt16(bs.Array2d[i, j]) + 2*(bs.jmlBaris-1-j)).ToString();
                        }
                        
                    }
                    
                }
            }
        }

    }
}


