using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    //Create a dynamic link library with the name Algorithms that contains
    public class Algorithmclass1
    {

        //A method Swap to swap two data values at two positions in a given integer array.
        public static void Swap(int[] MyArray, int m, int n)
        {
            int temp;
            temp = MyArray[m];
            MyArray[m] = MyArray[n];
            MyArray[n] = temp;
        }

        //A method Randomize to create the random array of data, random numbers are between 0 and 10 times the array size.
        public static void Randomize(int[] MyArray)
        {
            Random randNum = new Random();
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = randNum.Next(0, MyArray.Length * 10);
            }
        }

        //A method Prepare that takes an array size n as a parameter. And create an array of integers with this specific size. and then call the Randomize passing it the array.
        public static void Prepare(int ArraySize)
        {
            int[] MyArray = new int[ArraySize];
            Randomize(MyArray);
            Console.WriteLine(string.Format("Here's the Random Array: [{0}].", string.Join(", ", MyArray)));
        }
    }
}
