using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnA.Algorithms._01___Search_Algos
{
    class _02___Binary_Search
    {
        internal static void Solution()
        {
            List<int> l = new List<int>() {1,5,9,10,15,23,46,78,90 };
            int searchElement = 12;
            Console.WriteLine(BinarySearch(l, searchElement));
        }

        private static int BinarySearch(List<int> lst,int value)
        {
            int l = 0;
            int r = lst.Count-1;

            while(l<=r)
            {
                int mid = (l + r) / 2;

                if(lst[mid] < value)
                {
                    l = mid+1;
                }
                else if(lst[mid] > value)
                {
                    r = mid-1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
