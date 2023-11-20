using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num = GetNum();
            int x = GetNum();
            Console.WriteLine($"hello from main {num}");
            Console.ReadLine();
        }

        private static int GetNum()
        {
            Console.WriteLine("Enter a number");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }

        private static void HelloFunction()
        {
            Console.WriteLine("hello from hello function or method");
            Bosswell();
        }

        private static void Bosswell()
        {
            Console.WriteLine("hello from Boswell");
        }
    }
}
