using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS_Standardalgorithmen_Csharp
{
    public class ClStandardAlgorithmus
    {
        static void Main(string[] args)
        {
        }
        /// <summary>
        /// Sortiert ein int array absteigen (descending)
        /// </summary>
        /// <param name="array"></param>
        public static void BubbleSortOn(int[] array)
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
        /// <summary>
        /// sucht nach "gesucht" im array, gibt ersten gefundenen index aus, ansonsten -1. (Wert kann auch mehrmals im array vorkommen!)
        /// </summary>
        /// <param name="gesucht"></param>
        /// <param name="array"></param>
        /// <returns>int</returns>
        public static int BinarySearchOfIntOn(int gesucht,int[] array)  
        {

            int untergrenze = 0;
            int obergrenze = array.Length - 1;

            while (untergrenze <= obergrenze)
            {
                int mitteIndex = (obergrenze + untergrenze) / 2;

                if (gesucht == array[mitteIndex])
                    return mitteIndex;

                if (gesucht > array[mitteIndex])
                {
                    untergrenze = mitteIndex + 1;
                }
                else
                    obergrenze = mitteIndex - 1;
            }
            return -1;


        }


    }
}
