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
            int ArraySize;
            string ch;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(50, 10);
            Console.WriteLine("Input The Array Size:");
            Console.SetCursorPosition(60, 15);
            ArraySize = Convert.ToInt32(Console.ReadLine());

        //Call Prepare method

            int[] MyArray = Algorithmclass1.Prepare(ArraySize);
            Console.WriteLine(string.Format("Here's the Random Array: [{0}]", string.Join(", ", MyArray)));

        //Call Menu method

            Menu(MyArray);

        //Instaed of sorting in place, create a method that sorts an array without affecting the original(avoid mutation) 
        //by using Lambda expression and then fill in the table with running time.




            //ch = Console.ReadLine();
        }

        public static void Menu(int[] MyArray)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            List<string> MenuItems = new List<string>()
            {
                "Insertion Sort",
                "Selection Sort",
                "Bubble Sort",
                "Merge Sort",
                "Quick Sort",
                "Exit"
            };

            Console.CursorVisible = false;
            

            while (true)
            {
                string SelectedItem = DrawMenu(MenuItems, IndexMenu);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(50, 10);

                //Call DisplayRunningTime method passing it the prepared array and the delegate object that has the name of the sorting algorithm.

                if (SelectedItem == "Insertion Sort")
                {
                //Delegate for Insertion sort
                                    
                    Console.WriteLine("Insertion Sort:");

                    Algorithmclass1.SortDelegaet InsDele = Algorithmclass1.InsertionSort;

                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.DisplayRunTime(MyArray, InsDele);

                }

                else if (SelectedItem == "Selection Sort")
                {
                //Delegate for Selection sort

                    
                    Console.WriteLine("Selection Sort:");

                    Algorithmclass1.SortDelegaet SelDele = Algorithmclass1.SelectionSort;

                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.DisplayRunTime(MyArray, SelDele);

                }

                else if (SelectedItem == "Bubble Sort")
                {
                //Delegate for Bubble Sort 

                    Console.WriteLine("Bubble Sort:");
                    
                    Algorithmclass1.SortDelegaet BubbleDele = Algorithmclass1.BubbleSort;

                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.DisplayRunTime(MyArray, BubbleDele);

                }

                else if (SelectedItem == "Merge Sort")
                {
                //Delegate for Merge Sort

                    Console.WriteLine("Merge Sort");
                    
                    Algorithmclass1.SortDelegaet MergeDele = Algorithmclass1.MergeSort;

                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.DisplayRunTime(MyArray, MergeDele);

                }

                else if (SelectedItem == "Quick Sort")
                {
                //Delegate for Quick sort

                    Console.WriteLine("Quick Sort:");
                    
                    Algorithmclass1.SortDelegaet QuickDele = Algorithmclass1.QuickSort;

                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.DisplayRunTime(MyArray, QuickDele);

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
                        Console.SetCursorPosition(50, 10 + i * 2);
                        Console.WriteLine(MenuItems[i]);
                    }
                    else
                    {
                        Console.SetCursorPosition(50, 10 + i * 2);
                        Console.WriteLine(MenuItems[i]);
                    }
                    Console.ResetColor();
                }

                ConsoleKeyInfo Currkey = Console.ReadKey();
                if (Currkey.Key == ConsoleKey.DownArrow)
                {
                    if (IndexMenu == MenuItems.Count - 1) { }
                    else { IndexMenu++; }
                }
                else if (Currkey.Key == ConsoleKey.UpArrow)
                {
                    if (IndexMenu <= 0) { }
                    else { IndexMenu--; }
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
                    return "";
                }

                //Console.Clear();
                //return "";

            }
        }


    }
}
