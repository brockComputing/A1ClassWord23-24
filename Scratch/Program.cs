using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Hello();
            Console.ReadLine();
        }
        static int counter = 0;
        private static void Hello()
        {
            for (int i = 0; i < 20000; i++)
            {
                counter++;
                Console.WriteLine($"Hello {counter}");
                Hello();
            }
        }
    }
}
