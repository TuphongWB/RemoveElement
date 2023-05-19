using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveElement
{
    internal class Program
    {
        public static void PrintArray(int[] array, int size)
        {
            Console.WriteLine("Array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of elements in the array: ");
            int size = int.Parse(Console.ReadLine());

            int[] arr = new int[size];

            Console.WriteLine("Enter the elements of the array: ");
            for (int i = 0; i < size; i++)
            {
                Console.Write("Element {0}: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the element to delete: ");
            int element = int.Parse(Console.ReadLine());

            int index = -1;

            // Find the index of the element in the array
            for (int i = 0; i < size; i++)
            {
                if (arr[i] == element)
                {
                    index = i;
                    break;
                }
            }

            if (index != -1)
            {
                // Shift elements to the left to overwrite the element to delete
                for (int i = index; i < size - 1; i++)
                {
                    arr[i] = arr[i + 1];
                }

                size--; // Reduce the size of the array

                Console.WriteLine("Element {0} has been deleted.", element);
            }
            else
            {
                Console.WriteLine("Element {0} is not found in the array.", element);
            }

            PrintArray(arr, size);
            Console.ReadKey();
        }

    }
}
