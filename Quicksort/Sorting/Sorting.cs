using System;

namespace Sorting
{
    public class Sorting
    {
        public static void Quicksort(int[] arr, int p, int r)
        {
            if (p < 0 || r >= arr.Length)
            {
                throw new ArgumentException("Bounds passed are out of array bounds");
            }
            if (p < r)
            {
                var q = Partition(arr, p, r);
                Quicksort(arr, p, q-1);
                Quicksort(arr, q+1, r);
            }
        }

        private static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];  
          
            int i = low - 1;  
            for (int j = low; j < high; j++) 
            { 
                if (arr[j] <= pivot) 
                { 
                    i++; 
                    int temp = arr[i]; 
                    arr[i] = arr[j]; 
                    arr[j] = temp; 
                } 
            } 
            
            int temp1 = arr[i+1]; 
            arr[i+1] = arr[high]; 
            arr[high] = temp1; 
  
            return i+1;
        }
    }
}