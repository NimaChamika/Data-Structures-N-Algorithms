using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnA.Algorithms._02___Sorting_Algos
{
    class _01___Bubble_Sort
    {
        internal static void Solution()
        {
            int[] unsortedArray = new int[] { 5,1,4,2,8,3,9,12,7};
            BubbleSort(unsortedArray);
        }

        private static void BubbleSort(int[] array)
        {
            for(int i=0;i<array.Length;i++)
            {
                for(int j=0;j<array.Length-1;j++)
                {
                    int a = array[j];
                    int b = array[j + 1];

                    if(a > b)
                    {
                        array[j + 1] = a;
                        array[j] = b;
                    }
                }
            }

            Console.WriteLine(string.Join(" ",array));
        }
    }
}
