using System;

namespace C_Console
{
    internal class C
    {
        static void Main(string[] args)
        {
            int x = GetNum();
            int y = GetNum();
            int sum = Add2Numbers(x, y);
            Console.WriteLine($"the sum of thenumbers are {x} amd {y} is {sum}");
            sum = 0;
            Add2NumbersWithRef(x, y, ref sum);
            Console.WriteLine($"the sum of thenumbers are {x} amd {y} is {sum}");
            HelloFunction();
            Console.ReadLine();
        }

        private static void Add2NumbersWithRef(int x, int y, ref int sum)
        {
            sum = x + y;
        }

        private static int Add2Numbers(int x, int y)
        {
            int sum = x + y;
            return sum;
        }

        private static int GetNum()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            return num;
        }

        private static void HelloFunction()
        {
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("hello from hellofunction");
                GoodByeFunction();
                counter++;
            }
        }

        private static void GoodByeFunction()
        {
            Console.WriteLine("hello from goodbye");
        }
    }
}
