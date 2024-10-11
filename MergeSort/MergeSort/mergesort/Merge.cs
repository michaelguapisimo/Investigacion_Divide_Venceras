using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort.mergesort
{
    internal class Merge
    {
        public static void MergeSortArray(int[] array)
        {
            if (array.Length <= 1) return;
            else
            {
                int mitad = array.Length / 2;
                int[] izq = new int[mitad];
                int[] der = new int[array.Length - mitad];

                Array.Copy(array, 0, izq, 0, mitad);
                Array.Copy(array, mitad, der, 0, array.Length - mitad);

                MergeSortArray(izq);
                MergeSortArray(der);

                Merged(izq, der, array);
            }
        }

        private static void Merged(int[] left, int[] right, int[] array)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }

            while (i < left.Length)
            {
                array[k++] = left[i++];
            }

            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }
    }
}
