using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karmaşık_Analizi
{
    public class MaxAltDiziTopla
    {
        
        public int BruteForce(int[] a)
        {
            int maxTop = 0; for (int i = 0; i < a.Length - 1; i++) for (int j = i; j < a.Length - 1; j++)
                {
                    int top = 0; for (int k = i; k <= j; k++) top += a[k]; if (top > maxTop)
                    {
                        maxTop = top; int bas = i;  
                    }
                }
            return maxTop;
        }

        public int BruteForceImproved(int[] a)
        {
            int maxTop = 0; for (int i = 0; i < a.Length - 1; i++)
            {
                int top = 0; for (int j = i; j <= a.Length - 1; j++)
                {
                    top += a[j]; if (top > maxTop)
                    {
                        maxTop = top; int bas = i;
                    }

                }
            }
            return maxTop;
        }

        public int dogrusal(int[] a)
        {
            int maxtop = 0;
            int top = 0;
            for (int i = 0,j=0; j <=a.Length-1 ; j++)
            {
                top += a[j];
                if (top>maxtop)
                {
                    maxtop = top;
                    int bas = i;
                    int son = j;
                }
                else if (top<0)
                {
                    i = j + 1;
                    top = 0;
                }
            }

            return maxtop;
            

        }


    }
}
