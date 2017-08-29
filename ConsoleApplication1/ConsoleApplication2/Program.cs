using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[2, 2] { { 1, 2 }, { 3, 4 } };

            Console.WriteLine("\n" + arr[0, 0] + arr[0, 1] + "\n" + 
                              arr[1, 0] + arr[1, 1] + "\n\n");

            Console.WriteLine("{0} {1} \n{2} {3} ", arr[0, 0], arr[0, 1], arr[1, 0], arr[1, 1]);
            Console.WriteLine("Arrays can be fun...");
            Console.ReadLine();
        }
    }
}
