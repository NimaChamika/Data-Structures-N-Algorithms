using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnA.Algorithms._02___Sorting_Algos
{
    class _03___Insertion_Sort
    {
        internal static void Solution()
        {
            int[] unsortedArray = new int[] { 5, 4, 2, 8, 3, 9, 12, 7,1 };
            InsertionSort(unsortedArray);
        }

        private static void InsertionSort(int[] array)
        {
            int n = array.Length;

            for(int i=1;i<n;i++)
            {
                int j = i;
                while(j > 0 && array[j-1] > array[j])
                {
                    int a = array[j - 1];
                    int b = array[j];

                    array[j - 1] = b;
                    array[j] = a;

                    j -= 1;
                }
            }

            Console.WriteLine(string.Join(" ",array));
        }
    }
}
