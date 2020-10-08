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

        //A method Prepare that takes an array size n as a parameter. And create an array of integers with this specific size.
        //Then call the Randomize passing it the array.
        public static void Prepare(int ArraySize)
        {
            int[] MyArray = new int[ArraySize];
            Randomize(MyArray);
            Console.WriteLine(string.Format("Here's the Random Array: [{0}].", string.Join(", ", MyArray)));
            InsertionSort(MyArray);
            Randomize(MyArray);
            Console.WriteLine(string.Format("\nHere's the Random Array: [{0}].", string.Join(", ", MyArray)));
            SelectionSort(MyArray);
            Randomize(MyArray);
            Console.WriteLine(string.Format("\nHere's the Random Array: [{0}].", string.Join(", ", MyArray)));
            BubbleSort(MyArray);
        }

        //A method to Implement each of the following sorting algorithms: 
        //Insertion sort 
        public static void InsertionSort(int[] MyArray)
        {
            for ( int i = MyArray.Length-2; i >= 0 ; i--)
            {
                int temp = MyArray[i];
                int j;
                for (j = i + 1; j < MyArray.Length && MyArray[j] < temp; j++)
                    MyArray[j - 1] = MyArray[j];
                MyArray[j - 1] = temp;
            }
            Console.WriteLine(string.Format("Here's the Insertion Sorted Array: [{0}].", string.Join(", ", MyArray)));
        }

        //Selection sort
        public static void SelectionSort(int[] MyArray)
        {
            for (int i = 0; i < MyArray.Length - 1; i++)
            {
                int Min = i;
                for (int j = i + 1; j < MyArray.Length; j++)
                {
                    if (MyArray[Min] > MyArray[j])
                    {
                        Min = j;// keeps track of the index for the minimum value.
                    }
                }
                Swap(MyArray, i, Min);//swap the minimum element with the current element.
            }
            Console.WriteLine(string.Format("Here's the Selection Sorted Array: [{0}].", string.Join(", ", MyArray)));
        }

        //Bubble Sort  
        public static void BubbleSort(int[] MyArray)
        {
            for (int i = 0; i < MyArray.Length; i++)
            {
                for (int j = 0; j < MyArray.Length - 1; j++)
                {
                    if (MyArray[j] > MyArray[j + 1])
                    {
                        Swap(MyArray, j + 1, j);
                    }
                }
            }
            Console.WriteLine(string.Format("Here's the Bubble Sorted Array: [{0}].", string.Join(", ", MyArray)));
        }

        //Merge sort
        public static void MergeSort()
        {

        }

        //Quick sort
        public static void QuickSort()
        {

        }
    }
}
