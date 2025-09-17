using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSAnzeigen
{
    
    public static class ClAnzeigen
    {
        public static Random zufall = new Random();

        static void Main(string[] args)
        {


        }




        /// <summary>
        /// returns an randomized int array with the Length as the given size (int)
        /// </summary>
        /// <param name="size"></param>
        /// <returns>int array (with given size, but randomized elements range of -128 to +127)</returns>
        public static int[] FillRandomIntArraySizeOf(int size)
        {
            int[] randomIntArray = new int[size];

            for (int i = 0; i < randomIntArray.Length; i++)
            {
                randomIntArray[i] = zufall.Next(-128, 128);
            }

            return randomIntArray;
        }
        /// <summary>
        /// Console.Writelines each element from given int array. As for-loop.
        /// </summary>
        /// <param name="intArray"></param>
        public static void PrintIntArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++) { Console.WriteLine(intArray[i]); }
        }
        /// <summary>
        /// Console.Writelines each element from given int array. As for-loop.
        /// </summary>
        /// <param name="stringArray"></param>
        public static void PrintStringArray(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            { 
                Console.WriteLine(stringArray[i]);
            }

        }



    }
}
