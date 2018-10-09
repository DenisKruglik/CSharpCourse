using System;
using System.Collections.Generic;
using System.Linq;

namespace Sorting
{
    public static class Sorting
    {
        public static void Quicksort(int[] arr)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array to be sorted must not be null");
            }
            
            var r = arr.Length - 1;
            QuicksortLogic(arr, 0, r);
        }

        public static void Quicksort(int[] arr, int p, int r)
        {
            if (arr == null)
            {
                throw new ArgumentNullException("Array to be sorted must not be null");
            }
            
            if (p < 0 || r >= arr.Length)
            {
                throw new ArgumentException("Bounds passed are out of array bounds");
            }

            if (p >= r)
            {
                throw new ArgumentException("Left bound must be less than right bound");
            }
            
            QuicksortLogic(arr, p, r);
        }
        
        private static void QuicksortLogic(int[] arr, int p, int r)
        {
            if (p < r)
            {
                var q = Partition(arr, p, r);
                QuicksortLogic(arr, p, q-1);
                QuicksortLogic(arr, q+1, r);
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

        public static void MergeSort(int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array to be sorted must not be null");
            }

            if (array.Length <= 1)
            {
                return;
            }

            var end = array.Length - 1;
            MergeSortLogic(array, 0, end);
        }

        public static void MergeSort(int[] array, int start, int end)
        {
            if (array == null)
            {
                throw new ArgumentNullException("Array to be sorted must not be null");
            }

            if (start < 0 || end >= array.Length)
            {
                throw new ArgumentException("Bounds passed are out of array bounds");
            }

            if (start >= end)
            {
                throw new ArgumentException("Left bound must be less than right bound");
            }

            if (array.Length <= 1)
            {
                return;
            }

            MergeSortLogic(array, start, end);
        }
        
        private static void MergeSortLogic(int[] array, int start, int end)
        {
            if (start < end) 
            { 
                int middle = (start + end) / 2; 

                MergeSortLogic(array, start, middle); 
                MergeSortLogic(array, middle + 1, end); 

                Merge(array, middle, start, end); 
            }
        }

        private static void Merge(int[] arr, int middle, int start, int end)
        {
            int leftLength = middle - start + 1; 
            int rightLength = end - middle; 

            int[] left = new int[leftLength]; 
            int[] right = new int[rightLength]; 

            int i, j; 
            for (i = 0; i < leftLength; i++) 
            { 
                left[i] = arr[start + i]; 
            } 

            for (i = 0; i < rightLength; i++) 
            { 
                right[i] = arr[i + middle + 1]; 
            } 

            int k = start; 
            i = 0; j = 0; 
            while (i < leftLength && j < rightLength) 
            { 
                if (left[i] < right[j]) 
                { 
                    arr[k] = left[i]; 
                    i++; 
                } 
                else 
                { 
                    arr[k] = right[j]; 
                    j++; 
                } 
                k++; 
            } 

            while (i < leftLength) 
            { 
                arr[k] = left[i]; 
                i++; k++; 
            } 

            while (j < rightLength) 
            { 
                arr[k] = right[j]; 
                j++; k++; 
            } 
        }
    }
}