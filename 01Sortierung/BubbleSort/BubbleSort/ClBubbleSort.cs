using NSAnzeigen;
using System;

namespace NSBubbleSort
{
    internal class ClBubbleSort
    {
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
        static void Main(string[] args)
        {
            int[] intArray = ClAnzeigen.FillRandomIntArraySizeOf(10);

            Console.WriteLine("unsortiert:");
            ClAnzeigen.PrintIntArray(intArray);


            BubbleSortOn(intArray);


            Console.WriteLine("sortiert:");
            ClAnzeigen.PrintIntArray(intArray);


        }
        

    }
}
