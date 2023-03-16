using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnA.Algorithms._02___Sorting_Algos
{
    class _02___Selection_Sort
    {
        internal static void Solution()
        {
            int[] unsortedArray = new int[] { 5, 1, 4, 2, 8, 3, 9, 12, 7 };
            SelectionSort(unsortedArray);
        }

        private static void SelectionSort(int[] array)
        {
            for(int i=0;i<array.Length-1;i++)
            {
                int minIndex = i;

                for(int j=i+1;j<array.Length;j++)
                {
                    if (array[j] < array[minIndex]) minIndex = j;
                }

                if(i!=minIndex)
                {
                    int a = array[i];
                    int b = array[minIndex];

                    array[i] = b;
                    array[minIndex] = a;
                }
            }

            Console.WriteLine(string.Join(" ",array));
        }
    }
}
