using MergeSort.mergesort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Merge merge = new Merge();
            int[] array = new int[6];
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Escribe un digito: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Merge.MergeSortArray(array);
            

            Console.WriteLine("Arreglo ordenado:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.ReadKey();
            
        }
    }
}
