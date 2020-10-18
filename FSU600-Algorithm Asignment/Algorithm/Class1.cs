
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

// // // // // // // // // // // // // // // // // // // // //    PART D  // // // // // // // // // // // // // // // // // // // // //

namespace Algorithm
{

    // Create a dynamic link library with the name Algorithm

    public class Algorithmclass1
    {

        // A method Swap to swap two data values at two positions in a given integer array.

        public static void Swap(int[] MyArray, int m, int n)
        {
            int temp;
            temp = MyArray[m];
            MyArray[m] = MyArray[n];
            MyArray[n] = temp;
        }

        // A method Randomize to create the random array of data, random numbers are between 0 and 10 times the array size.

        public static void Randomize(int[] MyArray)
        {
            Random randNum = new Random();
            for (int i = 0; i < MyArray.Length; i++)
            {
                MyArray[i] = randNum.Next(0, MyArray.Length * 10);
            }
        }

        // A method Prepare that takes an array size n as a parameter. And create an array of integers with this specific size.
        // Then call the Randomize passing it the array.

        public static int[] Prepare(int ArraySize)
        {
            int[] MyArray = new int[ArraySize];

            Randomize(MyArray);

            return MyArray;
        }

        // A method to Implement each of the following sorting algorithms: 

        // Insertion sort 

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

        // Selection sort

        public static void SelectionSort(int[] MyArray)
        {
            for (int i = 0; i < MyArray.Length - 1; i++)
            {
                int Min = i;
                for (int j = i + 1; j < MyArray.Length; j++)
                {
                    if (MyArray[Min] > MyArray[j])
                    {
                        Min = j;
                    }
                }
                Swap(MyArray, i, Min);
            }
        }

        // Bubble Sort  

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

        // Merge Sort

        public static void MergeSort(int[] MyArray)
        {
            SortofMS(MyArray, 0, MyArray.Length - 1);
        }

        // Sort Method of Merge Sort

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

        // Merge Method of Merge Sort

        public static void MergeofMS(int[] MyArray, int Low, int Mid, int High)
        {
            int i = Low, j = Mid + 1, k = Low;
            int[] temp = new int[MyArray.Length];    //  temp is a temporary array to store result
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

        // Quick sort

        public static void QuickSort(int[] MyArray)
        {
            SortofQS(MyArray, 0, MyArray.Length - 1);
        }

        // Sort Method of Quick Sort

        public static void SortofQS(int[] MyArray, int Low, int High)
        {
            if (Low < High)
            {
                int Pivot = Partition(MyArray, Low, High);

                SortofQS(MyArray, Low, Pivot - 1);
                SortofQS(MyArray, Pivot + 1, High);
            }

        }

        // Partition Method of Quick Sort

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

        // Instaed of sorting in place, create a method that sorts an array without affecting the original(avoid mutation) 
        // by using Lambda expression

        // Lambda Sort

        public static void LambdaSort(int[] MyArray)
        {
            MyArray.OrderBy(Array => Array);
        }

        // A delegate that has the same signature of the sorting method (has an array as parameter)

        public delegate void SortDelegate(int[] MyArray);

        // A method DisplayRunningTime that has an array and a delegate object as parameters

        public static async void SortRunTime(int[] MyArray, SortDelegate SortDele)
        {
            Stopwatch StopWatch = new Stopwatch();

            StopWatch.Start();

            SortDele(MyArray);

            StopWatch.Stop();

            TimeSpan Ts = StopWatch.Elapsed;
            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                        Ts.Hours, Ts.Minutes, Ts.Seconds, Ts.Milliseconds);
        }

// // // // // // // // // // // // // // // // // // // // //   PART C  // // // // // // // // // // // // // // // // // // // // //

    // A method to Implement each of the following searching algorithms

    //  Linear Search 

        public static int LineSearch(int[] MyArray, int X)
        {

            int i;
            for (i = 0; i < MyArray.Length && MyArray[i] != X; i++) ;

            if (i < MyArray.Length && MyArray[i] == X) { return i; }
            else { return -1; }

        }

    //  Binary Search

        public static int BinarySearch(int[] MyArray, int X)
        {

            int i = 0, j = MyArray.Length, Mid;

            while (i < j)
            {
                Mid = (i + j) / 2;

                if (X > MyArray[Mid]) { i = Mid + 1; }
                else { j = Mid; }
            }

            if (i <= j && X == MyArray[i]) { return i; }
            else { return -1; }

        }

    // Lambda Search

        public static int LambdaSearch(int[] MyArray, int X)
        {

            return (MyArray.Where(i => i == X).Count() - 1);

        }

    // Create a suitable delegate that represents searching methods

        public delegate int SearchDelegate(int[] MyArray, int X);

    // Improve DisplayRunningTime method to display the running time of the searching algorithms

        public static async void SearchRunTime(int[] MyArray, int X, SearchDelegate SearchDele)
        {
            int Location;
            Stopwatch StopWatch = new Stopwatch();

            StopWatch.Start();

            Location = SearchDele(MyArray, X);

            StopWatch.Stop();

            if (Location == -1)
                Console.WriteLine("Not Found");
            else Console.WriteLine("Found");

            TimeSpan Ts = StopWatch.Elapsed;
            Console.WriteLine("Elapsed Time is {0:00}:{1:00}:{2:00}.{3}",
                        Ts.Hours, Ts.Minutes, Ts.Seconds, Ts.Milliseconds);
        }

// // // // // // // // // // // // // // // // // // // // //   PART A  // // // // // // // // // // // // // // // // // // // // //

        static string[] Lines = System.IO.File.ReadAllLines(@"C:\Employees.txt");

    //Write a C# filter function in that filters the  employee 's names for the string “an”

        public static Func<List<string>> Filter = () =>
        {

            var Names = new List<string>();
            
            foreach (string Line in Lines)
                if (Line.Substring(0, Line.IndexOf('|')).Contains("an"))
                {
                    Names.Add(Line.Substring(0, Line.IndexOf('|')));
                }

            return Names;

        };

    //Write a C# map function  that manipulates the employees List and returns only the names in a separate list.

        public static Func<List<string>> Map = () =>
           {

               var Names = new List<string>();
               
               foreach (String Line in Lines)
                   Names.Add(Line.Substring(0, Line.IndexOf('|')));

               return Names;
           };

        //Write a C# reduce function that manipulates the employees List and the sum of the years of experience of the employees.

        public static Func<int> Reduce = () =>
        {
            int i = 0;

            foreach (String Line in Lines)
                i += Convert.ToInt32(Line.Substring(Line.LastIndexOf('|')+1)) ;
            return i;
        };
    }
}
