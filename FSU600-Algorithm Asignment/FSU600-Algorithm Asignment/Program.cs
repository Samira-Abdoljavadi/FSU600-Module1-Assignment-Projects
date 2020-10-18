using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Algorithm;

namespace FSU600_Algorithm_Asignment
{
    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public int Experience { get; set; }
    }
    class Program
    {
        static int IndexMenu = 0;

        static void Main(string[] args)
        {

        // Call Menu method

            Menu();

        }

    // Menu Method
        public static void Menu()
        {

        // Define Menu Items

            List<string> MenuItems = new List<string>()
            {
                "Sorting",
                "Searching",
                "File",
                "Exit"
            };

            Console.CursorVisible = false;

            while (true)
            {

            // Call Draw Menu

                string SelectedItem = DrawMenu(MenuItems, IndexMenu);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(50, 10);

                if (SelectedItem == "Sorting")
                {
                    SortMenu();
                    continue;
                }

                else if (SelectedItem == "Searching")
                {
                    SearchMenu();
                    continue;
                }

                else if (SelectedItem == "File")
                {
                   
                    FileMenu();
                    continue;
                }

                else if (SelectedItem == "Exit")
                {
                    Environment.Exit(0);
                }
            }
        }

    // Sort Menu Method

        public static void SortMenu()
        {
            int ArraySize;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

        // Create the Array for the first time

            Console.SetCursorPosition(50, 10);
            Console.WriteLine("Input The Array Size:");

            Console.SetCursorPosition(60, 15);
            ArraySize = Convert.ToInt32(Console.ReadLine());

        // Call Prepare method

            int[] MyArray = Algorithmclass1.Prepare(ArraySize);

        // Define Sort Menu Items

            List<string> SortMenuItems = new List<string>()
            {
                "Insertion Sort",
                "Selection Sort",
                "Bubble Sort",
                "Merge Sort",
                "Quick Sort",
                "Lambda Sort",
                "New Array",
                "Return Back",
                "Exit"
            };

            Console.CursorVisible = false;

            while (true)
            {

            // Call Draw Menu to draw Sort Menu

                string SelectedItem = DrawMenu(SortMenuItems, IndexMenu);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(50, 10);

            // Call DisplayRunningTime method passing it the prepared array and the delegate object that has the name of the sorting algorithm.

                if (SelectedItem == "Insertion Sort")
                {

                // Delegate for Insertion sort

                    Algorithmclass1.SortDelegate InsDele = Algorithmclass1.InsertionSort;

                    Console.WriteLine("Insertion Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.SortRunTime(MyArray, InsDele);          

                }

                else if (SelectedItem == "Selection Sort")
                {

                // Delegate for Selection sort

                    Algorithmclass1.SortDelegate SelDele = Algorithmclass1.SelectionSort;

                    Console.WriteLine("Selection Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.SortRunTime(MyArray, SelDele);

                }

                else if (SelectedItem == "Bubble Sort")
                {

                // Delegate for Bubble Sort 

                    Algorithmclass1.SortDelegate BubbleDele = Algorithmclass1.BubbleSort;

                    Console.WriteLine("Bubble Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.SortRunTime(MyArray, BubbleDele);

                }

                else if (SelectedItem == "Merge Sort")
                {

                // Delegate for Merge Sort

                     Algorithmclass1.SortDelegate MergeDele = Algorithmclass1.MergeSort;

                    Console.WriteLine("Merge Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.SortRunTime(MyArray, MergeDele);

                }

                else if (SelectedItem == "Quick Sort")
                {

                // Delegate for Quick sort

                    Algorithmclass1.SortDelegate QuickDele = Algorithmclass1.QuickSort;

                    Console.WriteLine("Quick Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.SortRunTime(MyArray, QuickDele);

                }

                else if (SelectedItem == "Lambda Sort")
                {

                // Delegate for Lambda Sort

                    Algorithmclass1.SortDelegate LamSortDele = Algorithmclass1.LambdaSort;

                    Console.WriteLine("Lambda Sort:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.Randomize(MyArray);
                    Algorithmclass1.SortRunTime(MyArray, LamSortDele);

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

                // Call Prepare method

                    MyArray = Algorithmclass1.Prepare(ArraySize);
                   
                    continue;

                }

                else if (SelectedItem == "Return Back")
                {
                    return;
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

    // Search Menu Method

        public static void SearchMenu()
        {
            int ArraySize, X;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();

        // Create the Array for the first time

            Console.SetCursorPosition(50, 5);
            Console.WriteLine("Input The Array Size:");

            Console.SetCursorPosition(60, 8);
            ArraySize = Convert.ToInt32(Console.ReadLine());

        // Call Prepare method

            int[] MyArray = Algorithmclass1.Prepare(ArraySize);

        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //
            
        //This Section Shows the First, Middle and Last Item in Array just for testing the run time in different situation

                Console.SetCursorPosition(40, 12);
                Console.WriteLine("First, Middle and Last Item in Array:");
                Console.SetCursorPosition(52, 13);
                Console.WriteLine("{0}\t{1}\t{2}", MyArray[0], MyArray[MyArray.Length/2], MyArray[MyArray.Length-1] );

        // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

            Console.SetCursorPosition(45, 16);
            Console.WriteLine("Input The Element for Searching:");

            Console.SetCursorPosition(60, 20);
            X = Convert.ToInt32(Console.ReadLine());


        // Define Search Menu Items

            List<string> SearchMenuItems = new List<string>()
            {
                "Linear Search",
                "Binary Search",
                "Lambda Search",
                "New Search",
                "New Array",
                "Return Back",
                "Exit"
            };

            Console.CursorVisible = false;

            while (true)
            {

            // Call Draw Menu to draw Search Menu

                string SelectedItem = DrawMenu(SearchMenuItems, IndexMenu);

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(50, 10);

            // Call DisplayRunningTime method passing it the prepared array and the delegate object that has the name of the searching algorithm.

                if (SelectedItem == "Linear Search")
                {

                // Delegate for Linear Search

                    Algorithmclass1.SearchDelegate LineDele = Algorithmclass1.LineSearch;

                    Console.WriteLine("Linear Search:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.SearchRunTime(MyArray, X, LineDele);

                }

                else if (SelectedItem == "Binary Search")
                {

                // Delegate for Binary Search

                    Algorithmclass1.SearchDelegate BinDele = Algorithmclass1.BinarySearch;

                    Console.WriteLine("Binary Search:");

                // Sorting the Array

                    int[] SortedArray = MyArray.OrderBy(Array => Array).ToArray();

                // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

                //This Section Shows the First, Middle and Last Item in Array just for testing the run time in different situation

                    Console.SetCursorPosition(40, 12);
                    Console.WriteLine("First, Middle and Last Item in Array:");
                    Console.SetCursorPosition(52, 13);
                    Console.WriteLine("{0}\t{1}\t{2}", SortedArray[0], SortedArray[MyArray.Length / 2], SortedArray[MyArray.Length - 1]);

                // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

                    Console.SetCursorPosition(45, 16);
                    Console.WriteLine("Input The Element for Searching:");

                    Console.SetCursorPosition(60, 20);
                    int SX = Convert.ToInt32(Console.ReadLine());

                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.Clear();
                    Console.SetCursorPosition(50, 10);
                    Console.WriteLine("Binary Search:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.SearchRunTime(SortedArray, SX, BinDele);

                }

                else if (SelectedItem == "Lambda Search")
                {

                // Delegate for Lambda Search

                    Algorithmclass1.SearchDelegate LamSerDele = Algorithmclass1.LambdaSearch;

                    Console.WriteLine("Lambda Search:");
                    Console.SetCursorPosition(55, 12);

                    Algorithmclass1.SearchRunTime(MyArray, X, LamSerDele);

                }

                else if (SelectedItem == "New Search")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();

                // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

                //This Section Shows the First, Middle and Last Item in Array just for testing the run time in different situation

                    Console.SetCursorPosition(40, 12);
                    Console.WriteLine("First, Middle and Last Item in Array:");
                    Console.SetCursorPosition(52, 13);
                    Console.WriteLine("{0}\t{1}\t{2}", MyArray[0], MyArray[MyArray.Length / 2], MyArray[MyArray.Length - 1]);

                // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

                    Console.SetCursorPosition(45, 16);
                    Console.WriteLine("Input The Element for Searching:");

                    Console.SetCursorPosition(60, 20);
                    X = Convert.ToInt32(Console.ReadLine());

                    continue;

                }

                else if (SelectedItem == "New Array")
                {
                    Console.BackgroundColor = ConsoleColor.Gray;
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();

                    Console.SetCursorPosition(50, 5);
                    Console.WriteLine("Input The Array Size:");

                    Console.SetCursorPosition(60, 8);
                    ArraySize = Convert.ToInt32(Console.ReadLine());

                // Call Prepare method

                    MyArray = Algorithmclass1.Prepare(ArraySize);

                // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

                //This Section Shows the First, Middle and Last Item in Array just for testing the run time in different situation

                    Console.SetCursorPosition(40, 12);
                    Console.WriteLine("First, Middle and Last Item in Array:");
                    Console.SetCursorPosition(52, 13);
                    Console.WriteLine("{0}\t{1}\t{2}", MyArray[0], MyArray[MyArray.Length / 2], MyArray[MyArray.Length - 1]);

                // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // // //

                    Console.SetCursorPosition(45, 16);
                    Console.WriteLine("Input The Element for Searching:");

                    Console.SetCursorPosition(60, 20);
                    X = Convert.ToInt32(Console.ReadLine());

                    continue;

                }

                else if (SelectedItem == "Return Back")
                {
                    return;
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

    // File Menu Method

        public static void FileMenu()
        {

            //Console.BackgroundColor = ConsoleColor.Gray;
            //Console.ForegroundColor = ConsoleColor.Black;
            //Console.Clear();

        // Define File Menu Items

            List<string> FileMenuItems = new List<string>()
            {
                "Filter",
                "Map",
                "Reduce",
                "Return Back",
                "Exit"
            };

            Console.CursorVisible = false;

            //List<Employee> Employees = new List<Employee>();
            string[] lines = System.IO.File.ReadAllLines(@"C:\Employees.txt");
            //foreach (string line in lines)
            //{
            //    string[] split = line.Split('|');

            //    Employees.Add(new Employee { Name = split[0], Department = split[1], Experience = Convert.ToInt32(split[2]) } );

            //}

            int i = 0;

            while (true)
            {

            // Call Draw Menu to draw File Menu

                string SelectedItem = DrawMenu(FileMenuItems, IndexMenu);

                

                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                Console.SetCursorPosition(40, 10);

            //Write a C# filter function in that filters the  employee 's names for the string “an”
                
                if (SelectedItem == "Filter")
                {
                    Console.WriteLine("Filter:");
                    Console.SetCursorPosition(40, 12);
                    Console.WriteLine("The  Employee's Names that contains the string “an”:");

                    //Func<string, bool> filter = S => S.Contains("an");

                    //foreach (var Employe in Employees)
                    //    if (filter(Employe.Name))
                    //    {
                    //        Console.SetCursorPosition(50, 12 + (i+=2));
                    //        Console.WriteLine("{0}", Employe.Name);
                    //    }

                    Func<string, bool> filter = S => S.Substring(0, S.IndexOf('|')).Contains("an");
                    foreach (string line in lines)
                        if (filter(line))
                        {
                            Console.SetCursorPosition(50, 12 + (i += 2));
                            Console.WriteLine("{0}", line.Substring(0, line.IndexOf('|')));
                        }
                }

                //Write a C# map function  that manipulates the employees List and returns only the names in a separate list.

                else if (SelectedItem == "Map")
                {
                    Console.WriteLine("Map:");
                    Console.SetCursorPosition(40, 12);
                    Console.WriteLine("The  Employee's Names:");

                    string[] Names = new string[lines.Length];                    
                    
                    Func<string, string> Map = S => S.Substring(0, S.IndexOf(' '));

                    i = 0;
                    
                    foreach (string line in lines)
                        Names[i++] = Map(line);
                       

                        //if (Map(line))
                        //{
                        //    Console.SetCursorPosition(50, 12 + (i += 2));
                        //    Console.WriteLine("{0}", line.Substring(0, line.IndexOf('|')));
                        //}
                }

                else if (SelectedItem == "Reduce")
                {

                

                }

                else if (SelectedItem == "Return Back")
                {
                    return;
                }

                else if (SelectedItem == "Exit")
                {
                    Environment.Exit(0);
                }

                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 25);
                Console.WriteLine("Press Any Key To Continue");
                Console.ReadKey();

            }
        }

    // Draw Menue
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

    // Console.WriteLine(string.Format("Here's the Random Array: [{0}]", string.Join(", ", MyArray)));

    }
}
