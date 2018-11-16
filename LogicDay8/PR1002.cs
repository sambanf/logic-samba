using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay8
{
    class PR1002 : Baselogic
    {
        public PR1002(int n1,int n2, int n3)
        {
            jmlBaris = n1+(n2-1)+(n3-1);
            jmlKolom = n2*n3;
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n1,n2,n3);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n1, int n2, int n3)
        {
            Tools to = new Tools();
            for (int b = 0; b < n3; b++)
            {
                int idx = 1;
                int stbaris = b;
                int stkolom = b*n2;

                int enbaris = stbaris + n1 + n2-1;
                int enkolom = stkolom + n2;

                int maat, maba;
                maat = stbaris;
                maba = maat+n1-1;

                for (int i = stkolom; i < enkolom; i++)
                {
                    for (int j = stbaris; j < enbaris; j++)
                    {
                        if (j>=maat && j<=maba)
                        {
                            Array2d[j, i] = to.DeretP(idx++).ToString();
                        }
                    }
                    maat++;
                    maba++;
                }

            }
       
        }
    }
}
