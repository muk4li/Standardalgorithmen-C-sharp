using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NSAnzeigen
{
    
    public static class ClAnzeigen
    {
        static Random zufall = new Random();

        static void Main(string[] args)
        {


        }





        public static int[] FillRandomIntArraySizeOf(int size)
        {
            int[] randomIntArray = new int[size];

            for (int i = 0; i < randomIntArray.Length; i++)
            {
                randomIntArray[i] = zufall.Next(-128, 128);
            }

            return randomIntArray;
        }
        public static void PrintIntArray(int[] intArray)
        {
            for (int i = 0; i < intArray.Length; i++) { Console.WriteLine(intArray[i]); }
        }
        public static void PrintStringArray(string[] stringArray)
        {
            for (int i = 0; i < stringArray.Length; i++)
            { 
                Console.WriteLine(stringArray[i]);
            }

        }



    }
}
