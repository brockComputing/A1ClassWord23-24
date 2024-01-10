//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace XmasTest
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            //no5 part done
//            int num = 20;
//            bool isPrime = true;
//            for (int i = 2; i < num; i++)
//            {
//                if (num % i == 0)
//                {
//                    isPrime = false;
//                }
//            }
//            if (isPrime)
//            {
//                Console.WriteLine($"{num } is prime");
//            }
//            else
//            {
//                Console.WriteLine($"{num} is not prime");
//            }
//            Console.ReadLine();






//            //Console.WriteLine("enter you age");
//            //int age = Convert.ToInt32(Console.ReadLine());
//            //while (age < 16 || age > 65)
//            //{
//            //    Console.WriteLine("the age entered is not valid");
//            //    Console.WriteLine("enter you age");
//            //    age = Convert.ToInt32(Console.ReadLine());
//            //}
//            //Console.WriteLine("valid age entered");
//            // NO2
//            double perimter = 0, length = 0, width = 0;
//            GetDimensions(ref length, ref width);
//            perimter = CalculatePerimeter(length, width);
//            OutputPerimeter(perimter);
//            Console.ReadLine();

//        }
//        private static void OutputPerimeter(double perimter)
//        {
//            Console.WriteLine($"The perimter is {perimter.ToString("N2")}");
//        }
//        private static double CalculatePerimeter(double length, double width)
//        {
//            return length * 2 + width * 2;
//        }
//        private static void GetDimensions(ref double length, ref double width)
//        {
//            Console.WriteLine("enter the length");
//            length = Convert.ToDouble(Console.ReadLine());
//            Console.WriteLine("enter the width");
//            width = Convert.ToDouble(Console.ReadLine());
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //no5
            int num = 20;
            bool isPrime = true;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                }
            }
            if (isPrime)
            {
                Console.WriteLine("is a prime");
            }
            else
            {
                Console.WriteLine("not a prime");
            }


            double ave;
            int[] numbers = new int[] { 10, 1, 9, 3, 8, 5, 7, 7, 6, 9, 5, 11, 4, 13, 3, 15, 2, 17, 1, 19, 9, 3, 9, 3, 9, 3, };
            ave = calculateAverage(numbers);
            displayAve(ave);
            drawArray(numbers);
            Console.ReadLine();
        }

        private static void displayAve(double ave)
        {
            Console.WriteLine($"the average is {ave.ToString("N2")}");
        }

        private static void drawArray(int[] numbers)
        {
            int spaces = 0, stars = 0;
            // add code here
            for (int i = 0; i < numbers.Length; i = i + 2)
            {
                spaces = numbers[i];
                stars = numbers[i + 1];
                drawSpaces(spaces);
                drawStars(stars);
                Console.WriteLine();
                //Console.Read();
            }

        }
        static void DrawSomeThing(int count, string item)
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(item);
            }
        }
        private static void drawStars(int stars)
        {
            for (int i = 0; i < stars; i++)
            {
                Console.Write("*");
            }
        }

        private static void drawSpaces(int spaces)
        {
            for (int i = 0; i < spaces; i++)
            {
                Console.Write(" ");
            }
        }



        private static double calculateAverage(int[] numbers)
        {
            double ave = 0, total = 0;
            // add code here
            for (int i = 0; i < numbers.Length; i++)
            {
                total = total + numbers[i];
            }
            ave = total / numbers.Length;
            return ave;
        }
    }
}


