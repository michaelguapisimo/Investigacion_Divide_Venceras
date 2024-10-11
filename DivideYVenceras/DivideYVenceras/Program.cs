using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definición de un array de enteros con valores no ordenados
            int[] datos = { -1, 2, 777, 4, -56, 12, 40, 1, 2, 10, 0, 7 };
            // Imprime los valores del array no ordenados
            Console.WriteLine("Datos NO ordenados");
            PrintArray(datos);
            // Llama al algoritmo QuickSort para ordenar el array
            Console.WriteLine("Datos SI ordenados");
            QuickSortAlgorithm(datos, 0, datos.Length - 1);
            // Imprime los valores del array ya ordenados
            PrintArray(datos);
        }

        // Método que implementa el algoritmo de ordenación QuickSort
        static void QuickSortAlgorithm(int[] datos, int menor, int mayor)
        {
            if (menor < mayor)
            {
                int pivote = Partition(datos, menor, mayor);
                QuickSortAlgorithm(datos, menor, pivote - 1);
                QuickSortAlgorithm(datos, pivote + 1, mayor);
            }
        }
        // Método que realiza la partición del array
        static int Partition(int[] datos, int menor, int mayor)
        {
            int pivote = datos[mayor];
            int i = menor - 1;
            // Recorre los elementos desde el índice 'menor' hasta 'mayor - 1'
            for (int j = menor; j < mayor; j++)
            {
                // Si el elemento actual es menor que el pivote, intercambia con el elemento en 'i'
                if (datos[j] < pivote)
                {
                    i++;
                    Swap(datos, i, j);
                }
            }

            Swap(datos, i + 1, mayor);
            return i + 1;
        }// Método para intercambiar dos elementos en un array
        static void Swap(int[] datos, int i, int j)
        {
            // Intercambia los valores en los índices 'i' y 'j'
            int temp = datos[i];
            datos[i] = datos[j];
            datos[j] = temp;
        }
        // Método para imprimir los elementos de un array
        static void PrintArray(int[] datos)
        {
            // Itera sobre cada elemento del array y lo imprime en consola
            foreach (var item in datos)
            {
                Console.WriteLine(item);
            }
        }

    }

}