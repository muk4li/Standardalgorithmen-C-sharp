using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSAnzeigen;
using NS_Standardalgorithmen_Csharp;

namespace MergeSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = ClAnzeigen.FillRandomIntArraySizeOf(10);
            Console.WriteLine("unsortiert:");
            ClAnzeigen.PrintIntArray(array);

            MergeSort(array, 0, array.Length-1);
            Console.WriteLine("sortiert");
            ClAnzeigen.PrintIntArray(array);



        }

        static void MergeSort(int[] intArray,int firstPosition,int lastPosition)
        {
            if (firstPosition < lastPosition)
            {
                int midIndex = (lastPosition + firstPosition) / 2;
                MergeSort(intArray, firstPosition, midIndex);
                MergeSort(intArray, midIndex + 1, lastPosition);


                Merge(intArray, firstPosition, midIndex, lastPosition);
            }
        }
        static void Merge(int[] intArray, int min, int mid, int max)
        {
            int i1 = mid - min+1;
            int i2 = max - mid;

            int[] leftTree = new int[i1];
            int[] rightTree = new int[i2];

            for (int i =0; i<i1;i++)
                leftTree[i] = intArray[min+i];
            for (int j = 0; j < i2; j++)
                rightTree[j] = intArray[mid + 1 + j];

            int leftI = 0, rightI = 0, index = min;

            while (leftI < i1 && rightI < i2)
            {
                if (leftTree[leftI] <= rightTree[rightI])
                {
                    intArray[index] = leftTree[leftI];
                    leftI++;
                }
                else
                {
                    intArray[index] = rightTree[rightI];
                    rightI++;
                }
                index++;
            }

            while (leftI < i1)
            {
                intArray[index] = leftTree[(leftI++)];
                index++;
            }

            while (rightI < i2)
            {
                intArray[index] = rightTree[(rightI++)];
                index++;
            }
        }



    }
}
