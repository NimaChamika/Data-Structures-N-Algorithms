using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnA.Algorithms._01___Search_Algos
{
    class _03___Jump_Search
    {
        internal static void Solution()
        {
            List<int> lst = new List<int>() { 1,5,8,12,15,23,28,54,67,89,90,95,98,101};
            int x = 12;

            Console.WriteLine(JumpSearch(lst,x));
        }

        private static int JumpSearch(List<int> l,int x)
        {
            int n = l.Count;
            int initBlockSize = (int)Math.Sqrt(n);
            int m = initBlockSize;
            int i = 0;

            while(m < n)
            {
                if(l[m] <= x)
                {
                    i = m;
                    m += initBlockSize;
                }
                else
                {
                    break;
                }
            }


            if (m < n)
            {
                for (int j = i; j < i + initBlockSize; j++)
                {
                    if (l[j] == x)
                    {
                        return j;
                    }
                }
            }
            
            

            return -1;
            

        }
    }
}
