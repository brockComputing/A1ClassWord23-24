using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F_Console
{
    internal class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            
            for (int i = 0; i < 6; i++)
            {
                int number = rnd.Next(5, 11);
                Console.WriteLine($"Random number: {number}");
                //Console.ReadLine();
            }


            int x = GetNum();
            int y = GetNum();
            int sum = AddNums(x, y);
            Console.WriteLine($"THE ADDITION {x} and {y} is {sum}");
            sum = 0;
            AddNumsWithRef(x, y, ref sum);
            Console.WriteLine($"THE ADDITION {x} and {y} is {sum}");
            HelloFunction();

            Console.ReadLine();
        }
        private static void AddNumsWithRef(int x, int y, ref int sum)
        {
            sum = x + y;
        }
        private static int AddNums(int dave, int anne)
        {
            return dave + anne;
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
