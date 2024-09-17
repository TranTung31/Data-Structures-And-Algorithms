using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection_Sort
{
    internal class Program
    {
        public static void selectionSort(int[] arr, int n)
        {
            Console.WriteLine("Current Array: [{0}]", string.Join(", ", arr));

            for (int i = 0; i < n; i++)
            {
                int min_index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[min_index])
                    {
                        min_index = j;
                    }
                }

                int temp = arr[i];
                arr[i] = arr[min_index];
                arr[min_index] = temp;
            }
            
            Console.WriteLine("Result Array: [{0}]", string.Join(", ", arr));
        }

        static void Main(string[] args)
        {
            int[] arr = { 8, 6, 9, 7, 5 };
            selectionSort(arr, arr.Length);
        }
    }
}
