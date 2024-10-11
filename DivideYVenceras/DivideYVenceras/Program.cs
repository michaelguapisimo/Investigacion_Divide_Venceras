using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        class QuickSortExample
        {
            // Método para intercambiar los elementos
            static void Swap(int[] array, int i, int j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }

            // Método que realiza la partición
            static int Partition(int[] array, int low, int high)
            {
                int pivot = array[high]; // Se elige el último elemento como pivote
                int i = low - 1;

                for (int j = low; j < high; j++)
                {
                    if (array[j] < pivot)
                    {
                        i++;
                        Swap(array, i, j);
                    }
                }
                Swap(array, i + 1, high);
                return i + 1;
            }

            // Método de QuickSort recursivo
            static void QuickSort(int[] array, int low, int high)
            {
                if (low < high)
                {
                    int pi = Partition(array, low, high);

                    // Ordenar las dos particiones recursivamente
                    QuickSort(array, low, pi - 1);  // Lado izquierdo del pivote
                    QuickSort(array, pi + 1, high); // Lado derecho del pivote
                }
            }

            // Método principal
            static void Main(string[] args)
            {
                int[] array = { 34, 7, 23, 32, 5, 62 };

                Console.WriteLine("Array antes de Quick Sort:");
                Console.WriteLine(string.Join(", ", array));

                // Llamada al método QuickSort
                QuickSort(array, 0, array.Length - 1);

                Console.WriteLine("Array después de Quick Sort:");
                Console.WriteLine(string.Join(", ", array));
            }

        }
    }
}