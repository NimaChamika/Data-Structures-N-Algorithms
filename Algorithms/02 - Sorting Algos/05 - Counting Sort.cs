using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnA.Algorithms._02___Sorting_Algos
{
    class _05___Counting_Sort
    {
        internal static void Solution()
        {
            //ASSUMPTION - DATA IS BETWEEN 0-9
            int[] unsortedArray = new int[] {1,0,3,1,3,1 };
            CountingSort(unsortedArray);
        }

        private static void CountingSort(int[] inputArray)
        {
            int n = inputArray.Length;


            int[] countArray = new int[10];

            for(int i=0;i<=9;i++)
            {
                countArray[i] = inputArray.Count(x => x == i);
            }

            for(int i=1;i<=9;i++)
            {
                countArray[i] += countArray[i -1];
            }

            for (int i = 9; i >= 0; i--)
            {
                countArray[i] = i == 0 ? 0 : countArray[i - 1];
            }

            int[] outputArray = new int[n];

            foreach(int x in inputArray)
            {
                int index = countArray[x];
                outputArray[index] = x;
                countArray[x] += 1;
            }


            Console.WriteLine(string.Join(" ", outputArray));
        }
    }
}
