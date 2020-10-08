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
        static void Main(string[] args)
        {
            int ArraySize;
            string ch;
            Console.WriteLine("Input The Array Size:");
            ArraySize = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Array Size is:" + ArraySize);
            Algorithmclass1.Prepare(ArraySize);
            ch = Console.ReadLine();
        }
    }
}
