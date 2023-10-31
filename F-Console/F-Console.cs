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
            Random rand = new Random();
            int suitno = rand.Next(1, 5);
            if (suitno == 1)
            {
                Console.WriteLine("hearts");
            }
            Console.WriteLine($" "); // random no between 10-20
            
            Console.WriteLine();


            DateTime dob = Convert.ToDateTime("24/11/1967");
            DateTime thedateNow = DateTime.Now;
            TimeSpan ts = new TimeSpan();
            ts = thedateNow - dob;
            Console.WriteLine($"days alive {ts.TotalDays}");

            int month = 3;
            int noOfDays = 0;
            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    noOfDays = 31;
                    if (true)
                    {

                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    noOfDays = 30;
                    break;
                case 2:
                    noOfDays = 28;
                    break;
                default:
                    Console.WriteLine("Not a month");
                    break;
            }




            Console.ReadLine();
        }
    }
}
