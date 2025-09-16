using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubbleSort
{
    internal class Program
    {
        static Random zufall = new Random();
        static void Main(string[] args)
        {
            int[] intArray = FillRandomIntArray();

            Console.WriteLine("unsortiert:");
            IntArrayAnzeigen(intArray);


            BubbleSortOn(intArray);


            Console.WriteLine("sortiert:");
            IntArrayAnzeigen(intArray);

        }
        private static void BubbleSortOn(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                    }
                }

            }
        }
        private static int[] FillRandomIntArray()
        {
            int[] randomIntArray = new int[zufall.Next(5, 11)];

            for (int i = 0; i < randomIntArray.Length; i++)
            {
                randomIntArray[i] = zufall.Next(1, 256);
            }

            return randomIntArray;
        }
        static void IntArrayAnzeigen(int[] array)
        { 
            for(int i = 0;i < array.Length;i++) {Console.WriteLine(array[i]); }
        }

    }
}
