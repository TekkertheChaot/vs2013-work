using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operatoren
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            int y = x++;
            Console.Write(x);
            Console.Write(y);
            Console.Write(x--);
            Console.Write(x);
            Console.ReadLine();
        }
    }
}
