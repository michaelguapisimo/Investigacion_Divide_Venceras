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
            int[] datos = { -1, 2, 777, 4, -56, 12, 40, 1, 2, 10, 0, 7 };
            Console.WriteLine("Datos NO ordenados");
            PrintArray(datos);
        }

        static void Swap(int[] datos, int i, int j) 
        { 
            int temp = datos[i];
            datos[i] = datos[j];
            datos[j]= temp;
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
