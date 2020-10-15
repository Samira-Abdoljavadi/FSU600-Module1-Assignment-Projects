using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace FSU600_Algorithm_Asignment
{
    class Program
    {
        static int IndexMenu = 0;

        static void Main(string[] args)
        {

        //Call Menu method

            Menu();

        }

        public static void Menu()
        {
            int ArraySize;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

        //Create the Array for the first time

            Console.SetCursorPosition(50, 10);
            Console.WriteLine("Input The Array Size:");

            Console.SetCursorPosition(60, 15);
            ArraySize = Convert.ToInt32(Console.ReadLine());

        //Call Prepare method

            int[] MyArray = Algorithmclass1.Prepare(ArraySize);

        //Menu Items

            List<string> MenuItems = new List<string>()
            {
                "Insertion Sort",
                "Selection Sort",
                "Bubble Sort",
                "Merge Sort",
                "Quick Sort",
                "Lambda Sort",
                "New Array",
                "Exit"
            };

            Console.CursorVisible = false;

            while (true)
            {

            //Call Draw Menu

                string SelectedItem = DrawMenu(MenuItems, IndexMenu);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(50, 10);

            //Call DisplayRunningTime method passing it the prepared array and the delegate object that has the name of the sorting algorithm.

                if (SelectedItem == "Insertion Sort")
                {

                //Delegate for Insertion sort

                    Algorithmclass1.SortDelegaet InsDele = Algorithmclass1.InsertionSort;

                    Console.WriteLine("Insertion Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.DisplayRunTime(MyArray, InsDele);          

                }

                else if (SelectedItem == "Selection Sort")
                {

                //Delegate for Selection sort

                    Algorithmclass1.SortDelegaet SelDele = Algorithmclass1.SelectionSort;

                    Console.WriteLine("Selection Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.DisplayRunTime(MyArray, SelDele);

                }

                else if (SelectedItem == "Bubble Sort")
                {

                //Delegate for Bubble Sort 

                    Algorithmclass1.SortDelegaet BubbleDele = Algorithmclass1.BubbleSort;

                    Console.WriteLine("Bubble Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.DisplayRunTime(MyArray, BubbleDele);

                }

                else if (SelectedItem == "Merge Sort")
                {

                //Delegate for Merge Sort

                     Algorithmclass1.SortDelegaet MergeDele = Algorithmclass1.MergeSort;

                    Console.WriteLine("Merge Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.DisplayRunTime(MyArray, MergeDele);

                }

                else if (SelectedItem == "Quick Sort")
                {

                //Delegate for Quick sort

                    Algorithmclass1.SortDelegaet QuickDele = Algorithmclass1.QuickSort;

                    Console.WriteLine("Quick Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.DisplayRunTime(MyArray, QuickDele);

                }

                else if (SelectedItem == "Lambda Sort")
                {

                //Delegate for Lambda Sort

                    Algorithmclass1.SortDelegaet LambdaDele = Algorithmclass1.LambdaSort;

                    Console.WriteLine("Lambda Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.DisplayRunTime(MyArray, LambdaDele);

                }

                else if (SelectedItem == "New Array")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();

                    Console.SetCursorPosition(50, 10);
                    Console.WriteLine("Input The Array Size:");
                    Console.SetCursorPosition(60, 15);
                   
                    ArraySize = Convert.ToInt32(Console.ReadLine());

                //Call Prepare method

                    MyArray = Algorithmclass1.Prepare(ArraySize);
                   
                    continue;

                }

                else if (SelectedItem == "Exit")
                {
                    Environment.Exit(0);
                }

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 20);
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();

            }
        }

        public static string DrawMenu(List<string> MenuItems, int IndexMenu)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            while (true)
            {
                for (int i = 0; i < MenuItems.Count; i++)
                {
                    if (i == IndexMenu)
                    {
                        Console.BackgroundColor = ConsoleColor.Gray;
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.SetCursorPosition(50, 5 + i * 2);
                        Console.WriteLine(MenuItems[i]);
                    }
                    else
                    {
                        Console.SetCursorPosition(50, 5 + i * 2);
                        Console.WriteLine(MenuItems[i]);
                    }
                    Console.ResetColor();
                }

                ConsoleKeyInfo Currkey = Console.ReadKey();

                if (Currkey.Key == ConsoleKey.DownArrow)
                {
                    if (IndexMenu == MenuItems.Count - 1) { }
                    else  IndexMenu++; 
                }
                else if (Currkey.Key == ConsoleKey.UpArrow)
                {
                    if (IndexMenu <= 0) { }
                    else  IndexMenu--; 
                }
                else if (Currkey.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                }
                else if (Currkey.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                }
                else if (Currkey.Key == ConsoleKey.Enter)
                {
                    return MenuItems[IndexMenu];
                }
                else
                {
                    Console.Clear();
                }
            }
        }
    }
}
