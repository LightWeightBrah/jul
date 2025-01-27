using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierdzieloneAlgorytmySzypula
{
    public static class TestSort
    {
        public static int[] BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                bool swapped = false;
                for(int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;

                        swapped = true;
                    }
                }

                if (!swapped)
                    break;
            }

            return array;
        }

        public static int[] InsertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int value = array[i];
                int hole = i;

                while (hole > 0 && array[hole - 1] > value)
                {
                    array[hole] = array[hole - 1];
                    hole--;
                }

                array[hole] = value;
            }

            return array;
        }

        public static int[] MergeSort(int[] array)
        {
            int n = array.Length;

            if (n < 2)
                return array;

            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for(int i = 0; i < left.Length; i++)
            {
                left[i] = array[i];
            }

            for(int i = 0; i < right.Length; i++)
            {
                right[i] = array[i + mid];
            }

            MergeSort(left);
            MergeSort(right);

            Merge(array, left, right);

            return array;
        }

        private static void Merge(int[] array, int[] left, int[] right)
        {
            int nL = left.Length;
            int nR = right.Length;

            int i = 0;
            int j = 0;
            int k = 0;

            while(i < nL && j < nR)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                    k++;
                }    
                else
                {
                    array[k] = right[j];
                    j++;
                    k++;
                }
            }

            while(i < nL)
            {
                array[k] = left[i];
                i++;
                k++;
            }

            while(j < nR)
            {
                array[k] = right[j];
                j++;
                k++;
            }

        }

        public static int[] QuickSortHelper(int[] array)
        {
            array = QuickSort(array, 0, array.Length - 1);
            return array;
        }

        private static int[] QuickSort(int[] array, int start, int end)
        {
            if(start < end)
            {
                int partitionIndex = Partition(array, start, end);
                QuickSort(array, start, partitionIndex - 1);
                QuickSort(array, partitionIndex + 1, end);
            }

            return array;
        }

        private static int Partition(int[] array, int start, int end)
        {
            int pivot = array[end];
            int partitionIndex = start;

            for(int i = start; i < end; i++)
            {
                if (array[i] <= pivot)
                {
                    Swap(array, i, partitionIndex);
                    partitionIndex++;
                }
            }

            Swap(array, partitionIndex, end);

            return partitionIndex;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }


    }
}
