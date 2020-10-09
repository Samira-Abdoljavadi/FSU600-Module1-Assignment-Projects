
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

        //Call InsertionSort

            Randomize(MyArray);
            Console.WriteLine(string.Format("Here's the Random Array: [{0}].", string.Join(", ", MyArray)));
            InsertionSort(MyArray);
            Console.WriteLine(string.Format("Here's the Insertion Sorted Array: [{0}].", string.Join(", ", MyArray)));

        //Call SelectionSort

            Randomize(MyArray);
            Console.WriteLine(string.Format("\nHere's the Random Array: [{0}].", string.Join(", ", MyArray)));
            SelectionSort(MyArray);
            Console.WriteLine(string.Format("Here's the Selection Sorted Array: [{0}].", string.Join(", ", MyArray)));

        //Call BubbleSort

            Randomize(MyArray);
            Console.WriteLine(string.Format("\nHere's the Random Array: [{0}].", string.Join(", ", MyArray)));
            BubbleSort(MyArray);
            Console.WriteLine(string.Format("Here's the Bubble Sorted Array: [{0}].", string.Join(", ", MyArray)));

        //Call MergeSort

            Randomize(MyArray);
            Console.WriteLine(string.Format("\nHere's the Random Array: [{0}].", string.Join(", ", MyArray)));
            MergeSort(MyArray, 0, MyArray.Length - 1);
            Console.WriteLine(string.Format("Here's the Merge Sorted Array: [{0}].", string.Join(", ", MyArray)));

        //Call QuickSort

            Randomize(MyArray);
            Console.WriteLine(string.Format("\nHere's the Random Array: [{0}].", string.Join(", ", MyArray)));
            QuickSort(MyArray, 0, MyArray.Length - 1);
            Console.WriteLine(string.Format("Here's the Quick Sorted Array: [{0}].", string.Join(", ", MyArray)));

            //for(int i=0; i<MyArray.Length; i++)
            //    MyArray[i] = Convert.ToInt32(Console.ReadLine());
        }

        //A method to Implement each of the following sorting algorithms: 

        //Insertion sort 

        public static void InsertionSort(int[] MyArray)
        {
            for (int i = MyArray.Length - 2; i >= 0; i--)
            {
                int temp = MyArray[i];
                int j;
                for (j = i + 1; j < MyArray.Length && MyArray[j] < temp; j++)
                {
                    MyArray[j - 1] = MyArray[j];
                }
                MyArray[j - 1] = temp;
            }
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
        }

    //Merge Sort

        static public void MergeSort(int[] MyArray, int Low, int High)
        {
            int Mid;
            if (Low < High)
            {
                Mid = (Low + High) / 2;
                MergeSort(MyArray, Low, Mid);
                MergeSort(MyArray, Mid + 1, High);
                MergeofMS(MyArray, Low, Mid, High);
            }
        }

        //Merge Method of Merge Sort

            static public void MergeofMS(int[] MyArray, int Low, int Mid, int High)
            {
                int i = Low, j = Mid + 1, k = Low;
                int[] temp = new int[MyArray.Length];    // temp is a temporary array to store result
                while (i <= Mid && j <= High)
                {
                    if (MyArray[i] < MyArray[j])
                    {
                        temp[k++] = MyArray[i++];
                    }
                    else
                    {
                        temp[k++] = MyArray[j++];
                    }
                }
                while (j <= High)
                {
                    temp[k++] = MyArray[j++];
                }
                while (i <= Mid)
                {
                    temp[k++] = MyArray[i++];
                }
                for (i = Low; i <= High; i++)
                {
                    MyArray[i] = temp[i];
                }
            }

    //Quick sort

        static public void QuickSort(int[] MyArray, int Low, int High)
        {
            if (Low < High)
            {
                int Pivot = Partition(MyArray, Low, High);

                QuickSort(MyArray, Low, Pivot - 1);
                QuickSort(MyArray, Pivot + 1, High);
            }

        }

        //Partition Method of Quick Sort

            static public int Partition(int[] MyArray, int Low, int High)
            {
                int Pivot = Low++;
                while (Low < High)
                {
                    while (MyArray[Low] < MyArray[Pivot] && Low < High)
                    {
                        Low++;
                    }
                    while (MyArray[High] > MyArray[Pivot] && High > Low)
                    {
                        High--;
                    }
                    if (Low < High)
                    {
                        Swap(MyArray, Low++, High--);
                    }
                }
                if (MyArray[High] <= MyArray[Pivot])
                {
                    Swap(MyArray, High, Pivot);
                    return (High);
                }
                else
                {
                    Swap(MyArray, High - 1, Pivot);
                    return (High - 1);
                }
            }
    }
}
