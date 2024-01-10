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
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };
            int[] numbers = new int[1000];
            Random rnd = new Random();
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rnd.Next(100);
            }
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");
                sum = sum + numbers[i];
            }
            Console.WriteLine($"the sum of the numbers {sum}");

            Console.ReadLine();
        }
    }
}
