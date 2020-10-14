
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

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

        public static int[] Prepare(int ArraySize)
        {
            int[] MyArray = new int[ArraySize];

            Randomize(MyArray);
            
            return MyArray;
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

        public static void MergeSort(int[] MyArray)
        {
            SortofMS(MyArray, 0, MyArray.Length - 1);
        }

        //Sort Method of Merge Sort

            public static void SortofMS(int[] MyArray, int Low, int High)
            {
                int Mid;
                if (Low < High)
                {
                    Mid = (Low + High) / 2;
                    SortofMS(MyArray, Low, Mid);
                    SortofMS(MyArray, Mid + 1, High);
                    MergeofMS(MyArray, Low, Mid, High);
                }
            }

        //Merge Method of Merge Sort

            public static void MergeofMS(int[] MyArray, int Low, int Mid, int High)
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

        public static void QuickSort(int[] MyArray)
        {
            SortofQS(MyArray, 0, MyArray.Length - 1);
        }

        //Sort Method of Quick Sort

            public static void SortofQS(int[] MyArray, int Low, int High)
            {
                if (Low < High)
                {
                    int Pivot = Partition(MyArray, Low, High);

                    SortofQS(MyArray, Low, Pivot - 1);
                    SortofQS(MyArray, Pivot + 1, High);
                }

            }

        //Partition Method of Quick Sort

            public static int Partition(int[] MyArray, int Low, int High)
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

    //A delegate that has the same signature of the sorting method (has an array as parameter)

        public delegate void SortDelegaet(int[] MyArray);

    //A method DisplayRunningTime that has an array and a delegate object as parameters:

        public static void DisplayRunTime(int[] MyArray, SortDelegaet SortDele)
        {
            Stopwatch StopWatch = new Stopwatch();
       
            StopWatch.Start();
            
            SortDele(MyArray);

            StopWatch.Stop();

            TimeSpan Ts = StopWatch.Elapsed;
            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                        Ts.Hours, Ts.Minutes, Ts.Seconds, Ts.Milliseconds);
        }

        //Instaed of sorting in place, create a method that sorts an array without affecting the original(avoid mutation) 
        //by using Lambda expression and then fill in the table with running time.

       

    }
}
