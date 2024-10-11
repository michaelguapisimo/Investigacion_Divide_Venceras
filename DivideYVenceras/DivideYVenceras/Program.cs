using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    internal class Program
    {
        private static int j;

        static void Main(string[] args)
        {
            int[] datos = { -1, 2, 777, 4, -56, 12, 40, 1, 2, 10, 0, 7 };
            Console.WriteLine("Datos NO ordenados");
            PrintArray(datos);
        }

        static void QuickSortAlgorithm(int[] datos, int menor, int mayor)
        {
            if(menor < mayor)
            {
                int pivote = Partition(datos, menor, mayor);
                QuickSortAlgorithm(datos, menor, pivote 
            }
        }
        static int Partition(int[] datos, int menor, int mayor) 
        {
            int pivote = datos[mayor];
            int i = menor - 1;

            for (int j = menor; j < mayor; j++) ;
            {
                if (datos[j] < pivote)
                {
                    i++;
                    Swap(datos, i, j);  
                }
            }

            Swap(datos, i + 1, mayor);
            return i + 1;
        }
        
        static void Swap(int[] datos, int i, int j) 
        { 
            int temp = datos[i];
            datos[i] = datos[j];
            datos[j] = temp;

        }

        static void PrintArray(int[] datos)
        {
            foreach (var item in datos) 
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
