namespace SortingAlgorithms
{
    class QuickSort
    {
        //ref is not nessesery because array is referance type but it makes readable
        public static void QuickSortRecursive(ref int[] arr, int left, int right)
        {
            if (left < right)
            {
                //we determine pivot
                int q = Partition(ref arr, left, right);
                QuickSortRecursive(ref arr, left, q - 1);
                QuickSortRecursive(ref arr, q + 1, right);
            }
        }
        //we swap it
        private static int Partition(ref int[] arr, int left, int right)
        {
            //we pick last item as pivot
            int pivot = arr[right];
            int temp;
            int i = left;

            for (int j = left; j < right; ++j)
            {
                if (arr[j] <= pivot)
                {
                    temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;
                    i++;
                }
            }

            arr[right] = arr[i];
            arr[i] = pivot;

            return i;
        }
    }
}
