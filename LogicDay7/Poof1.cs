using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Util;

namespace LogicDay7
{
    class Poof1 : Baselogic //Soal Aan
    {
        Tools to = new Tools();
        public Poof1(int n)
        {

            jmlBaris = n * 2 + to.DeretP(n);
            jmlKolom = n * 2 + to.DeretP(n);
            Array2d = new string[jmlBaris, jmlKolom];
            isiarray(n);
            Tools.printArray(Array2d, true);
        }
        void isiarray(int n)
        {
            int maka, maki;
            maka = (jmlKolom) / 2;
            maki = (jmlKolom) / 2;

            
            int idx = 1;
            for (int i = 0; i < jmlBaris; i++)
            {
                for (int j = 0; j < jmlKolom; j++)
                {
                    if (j >= maki && j <= maka)
                    {
                        if (i < n)
                        {
                            Array2d[i, j] = to.DeretP(idx++).ToString();
                        }
                    }
                }

                maki--;
                maka++;
            }

            int maat = (jmlKolom) / 2;
            int maba = (jmlKolom) / 2;
            idx = 1;
            for (int i = 0; i < jmlBaris; i++)
            {
                for (int j = 0; j < jmlKolom; j++)
                {
                    if (j >= maat && j <= maba)
                    {
                        if (i < n)
                        {
                            Array2d[j, i] = to.DeretP(idx++).ToString();
                        }
                    }
                }

                maat--;
                maba++;
            }

            maka = (jmlKolom) / 2;
            maki = (jmlKolom) / 2;
            idx = 1;
            for (int i = jmlBaris-1; i > 0; i--)
            {
                for (int j = 0; j < jmlKolom; j++)
                {
                    if (j >= maki && j <= maka)
                    {
                        if (i > jmlBaris- n-1)
                        {
                            Array2d[i, j] = to.DeretP(idx++).ToString();
                        }
                    }
                }

                maki--;
                maka++;
            }

            maat = (jmlKolom) / 2;
            maba = (jmlKolom) / 2;
            idx = 1;
            for (int i = jmlKolom-1; i >0; i--)
            {
                for (int j = 0; j <jmlBaris-1; j++)
                {
                    if (j >= maat && j <= maba)
                    {
                        if (i > jmlKolom-n-1)
                        {
                            Array2d[j, i] = to.DeretP(idx++).ToString();
                        }
                    }
                }

                maat--;
                maba++;
            }

        }
    }
}
