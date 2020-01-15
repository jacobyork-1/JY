using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Jacob");
            Console.Write("York");

            Console.Beep(2000, 500);


            Console.ReadKey();
        }
    }
}
