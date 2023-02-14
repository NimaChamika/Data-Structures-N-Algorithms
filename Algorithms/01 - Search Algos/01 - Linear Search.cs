using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnA.Algorithms._01___Search_Algos
{
    class _01___Linear_Search
    {
        internal static void Solution()
        {
            List<int> l = new List<int>() { 1, 5, 9, 10, 15, 23, 46, 78, 90 };
            int searchElement = 78;
            Console.WriteLine(LinearSearch(l, searchElement));
        }

        private static int LinearSearch(List<int> lst,int x)
        {
            for(int i=0;i<lst.Count;i++)
            {
                if (lst[i] == x) return i;
            }
            return -1;
        }

    }
}
