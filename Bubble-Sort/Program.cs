using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_Sort
{
    internal class Program
    {
        // Bubble Sort Method V1
        public static void bubbleSortV1(int[] arr, int n)
        {
            Console.WriteLine("V2 Current Array: [{0}]", string.Join(", ", arr));

            // Vòng lặp ngoài chạy từ n - 1 về 0
            for (int i = n - 1; i >= 0; i--)
            {
                // Vòng lặp trong duyệt từ đầu đến i
                for (int j = 0; j < i; j++)
                {
                    // Đổi chỗ nếu phần tử đứng trước lớn hơn phần tử đứng sau
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("V2 Result Array: [{0}]", string.Join(", ", arr));
        }

        static void Main(string[] args)
        {
            int[] arr = { 9, 7, 8, 6, 5 };
            bubbleSortV1(arr, arr.Length);
        }
    }
}
