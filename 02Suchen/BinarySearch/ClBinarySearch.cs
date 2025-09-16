using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSAnzeigen;
using NS_Standardalgorithmen_Csharp;

namespace NSBinarySearch
{
    internal class ClBinarySearch
    {
        static void Main(string[] args)
        {
            int[] intArray = ClAnzeigen.FillRandomIntArraySizeOf(30);
            ClStandardAlgorithmus.BubbleSortOn(intArray);

            ClAnzeigen.PrintIntArray(intArray);

            BinarySearchOn(intArray);

            Console.ReadKey();


        }

        private static void BinarySearchOn(int[] array)
        {
            Console.WriteLine("Nach welcher Zahl willst du in deinem sortiertem Array suchen?");
            int eingabe = int.Parse(Console.ReadLine());

            int untergrenze = 0;
            int obergrenze = array.Length - 1;

            int zähler = 1;
            int index = -1;

            while (untergrenze <= obergrenze)
            {

                int mitteIndex = (obergrenze + untergrenze) / 2;
                Console.WriteLine($"{zähler}. Durchlauf...");

                if (eingabe == array[mitteIndex])

                {
                    index = mitteIndex;
                    break;
                }

                if (eingabe > array[mitteIndex])
                {
                    untergrenze = mitteIndex + 1;
                }
                else
                    obergrenze = mitteIndex - 1;
                zähler++;
            }
            ;

            if (index != -1)
                Console.WriteLine($"{eingabe} wurde an der index Stelle {index} gefunden.");
            else
                Console.WriteLine($"{eingabe} befindet sich nicht im Array.");
        }
    }
}
