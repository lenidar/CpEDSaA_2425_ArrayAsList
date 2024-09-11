using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CpEDSaA_2425_ArrayAsList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[0];
            Random rnd = new Random();

            DisplayArray(list);

            for (int x = 0; x < 100; x++)
            {
                list = AddToArray(list, rnd.Next(20));
                DisplayArray(list);
            }

            Console.ReadKey();
        }

        static void DisplayArray(int[] array)
        {
            Console.WriteLine("The current length of the array is " + array.Length);
            Console.WriteLine("It contains the following values:");

            foreach (int i in array)
                Console.Write(i + "\t");

            Console.WriteLine("\n\n");
        }

        static int[] AddToArray(int[] array, int value)
        {
            int[] newArray = new int[array.Length + 1];

            for(int x = 0; x< array.Length; x++)
                newArray[x] = array[x];

            newArray[array.Length] = value;

            return newArray;
        }
    }
}
