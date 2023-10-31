using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progtest1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ex1
            //Console.WriteLine("enter number of litres used ");
            //int litres = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("enter distance travelled");
            //int distance = Convert.ToInt32(Console.ReadLine());
            //double mpg = distance / (litres * 0.219969);
            //Console.WriteLine("Your fuel consumption is " + mpg.ToString("N2") + "mpg");
            //Console.ReadLine();
            //ex2
            //Console.WriteLine("enter your name");
            //string name = Console.ReadLine();
            //Console.WriteLine("enter your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //int yearsLeft = 80 - age;
            //int deathYear = DateTime.Now.Year + yearsLeft;
            //Console.WriteLine(name + " you will die in the year " + deathYear);
            //Console.ReadLine();
            //ex3
            //Console.WriteLine("enter a number between 0 and 15");
            //int dec = Convert.ToInt32(Console.ReadLine());
            //string binStr = "";
            //int original = dec;
            //binStr = Convert.ToString(dec % 2) + binStr;
            //dec = dec / 2;
            //binStr = Convert.ToString(dec % 2) + binStr;
            //dec = dec / 2;
            //binStr = Convert.ToString(dec % 2) + binStr;
            //dec = dec / 2;
            //binStr = Convert.ToString(dec % 2) + binStr;
            //dec = dec / 2;
            //Console.WriteLine(original + " as binary is " + binStr);
            //Console.ReadLine();

            // ex 4

            //Double cm, inch;
            //int foot;

            //Console.Write("Enter your height in cm: ");
            //cm = Convert.ToDouble(Console.ReadLine());

            //inch = cm / 2.54;
            //foot = Convert.ToInt32(inch) / 12; // killer line as it does integer divide and will always round down
            //inch = inch - (foot * 12);
            //Console.Write($"{foot}' {Convert.ToInt32(inch)}\""); // the inches will round up or down
            //Console.ReadLine();

        }
    }
}
