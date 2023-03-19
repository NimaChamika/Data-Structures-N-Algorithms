using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnA.Algorithms._02___Sorting_Algos
{
    class _04___Merge_Sort
    {
        internal static void Solution()
        {
            List<int> unsortedLst = new List<int>() { 5, 1, 4, 2, 8, 3, 9, 12, 7 };
            MergeSort(unsortedLst);
            Console.WriteLine(string.Join(" ", unsortedLst));
        }

        private static void MergeSort(List<int> lst)
        {
            int n = lst.Count;

            if (n <= 1) return;

            var leftlst = new List<int>();
            var rightLst = new List<int>();

            int mid = n / 2;

            for (int i = 0; i < n; i++)
            {
                if (i < mid) leftlst.Add(lst[i]);
                else rightLst.Add(lst[i]);
            }

            MergeSort(leftlst);
            MergeSort(rightLst);
            Merge(leftlst, rightLst, lst);
        }

        private static void Merge(List<int> leftLst, List<int> rightLst, List<int> originalLst)
        {
            List<int> sortedLst = new List<int>();

            int l = 0;
            int r = 0;
            int i = 0;

            while (l < leftLst.Count && r < rightLst.Count)
            {
                if (leftLst[l] < rightLst[r])
                {
                    originalLst[i] = leftLst[l];
                    l++;
                }
                else
                {
                    originalLst[i] = rightLst[r];
                    r++;
                }
                i++;
            }

            while (l < leftLst.Count)
            {
                originalLst[i] = leftLst[l];
                l++;
                i++;
            }

            while (r < rightLst.Count)
            {
                originalLst[i] = rightLst[r];
                r++;
                i++;
            }
        }
    }
}
