using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 5, 2, 3, 5, 6, 7, -1, -3, -6, 10, 15, 23 };

            WriteToConsole(a);

            QuickSort.QuickSortRecursive(ref a, 0, a.Length - 1);

            Console.WriteLine();
            WriteToConsole(a);
            
            
        }

        private static void WriteToConsole( int[] array)
        {
            foreach (var item in array)
            {
                Console.Write(item + "/");
            }
        }
    }
}
