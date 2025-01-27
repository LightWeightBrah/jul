using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PierdzieloneAlgorytmySzypula
{
    public static class Sorter
    {
        public static int[] GenerateRandomArray(int length, int minValue, int maxValue)
        {
            int seed = (int)DateTime.Now.Ticks % int.MaxValue; // Pobranie unikalnego ziarna z czasu
            Random random = new Random(seed);
            int[] array = new int[length];

            for (int i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue + 1);
            }

            return array;
        }

        public static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;

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
            for (int i = 1; i < array.Length; i++)
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

        public static int[] CountingSort(int[] array)
        {
            if (array.Length == 0)
                return array;

            // Znalezienie minimalnej i maksymalnej wartości w tablicy
            int min = array.Min();
            int max = array.Max();

            // Przesunięcie wartości, aby indeksy były dodatnie
            int range = max - min + 1;
            int[] count = new int[range];

            // Zliczanie wystąpień (przesunięte indeksy)
            for (int i = 0; i < array.Length; i++)
            {
                count[array[i] - min]++;
            }

            // Przekształcenie tablicy zliczeń w tablicę pozycji
            for (int i = 1; i < count.Length; i++)
            {
                count[i] += count[i - 1];
            }

            // Tworzenie posortowanej tablicy
            int[] output = new int[array.Length];
            for (int i = array.Length - 1; i >= 0; i--)
            {
                output[count[array[i] - min] - 1] = array[i];
                count[array[i] - min]--;
            }

            return output;
        }


        public static int[] MergeSort(int[] array)
        {
            int n = array.Length;
            if (n < 2)
                return array;

            int mid = n / 2;
            int[] left = new int[mid];
            int[] right = new int[n - mid];

            for (int i = 0; i < mid; i++)
            {
                left[i] = array[i];
            }
            for (int i = mid; i < n; i++)
            {
                right[i - mid] = array[i];
            }

            MergeSort(left);
            MergeSort(right);

            Merge(left, right, array);

            return array;

        }

        private static void Merge(int[] left, int[] right, int[] array)
        {
            int nL = left.Length;
            int nR = right.Length;

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < nL && j < nR)
            {
                if (left[i] <= right[j])
                {
                    array[k] = left[i];
                    i++;
                }
                else
                {
                    array[k] = right[j];
                    j++;
                }

                k++;
            }

            while (i < nL)
            {
                array[k] = left[i];
                i++;
                k++;
            }
            while (j < nR)
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

        public static int[] QuickSort(int[] array, int start, int end)
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
 