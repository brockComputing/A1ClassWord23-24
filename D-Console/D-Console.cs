using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice = 0, denNumber = 0, bit, colheader;
            string binStr = "", hexStr = "";
            choice = 0;
            do
            {
                binStr = "";
                denNumber = 0;
                Console.WriteLine("1. Denary to Binary");
                Console.WriteLine("2. Binary to Denary");
                Console.WriteLine("9. To exit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("enter a den number");
                    denNumber = Convert.ToInt32(Console.ReadLine());
                    while (denNumber != 0)
                    {
                        bit = denNumber % 2;
                        binStr = bit + binStr;
                        denNumber = denNumber / 2;
                    }
                    Console.WriteLine(binStr);
                }
                else if (choice == 2)
                {
                    binStr = "1101";
                    int x = 9;
                    string theString = "";
                    //theString =  x.ToString()
                    bit = Convert.ToInt32( binStr[3].ToString());
                    //Console.WriteLine(bit);
                    for (int i = binStr.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine(binStr[i].ToString());
                        

                    }
                }
                else if (choice == 3) // den to hex
                {

                }
            } while (choice != 9);
        }


    }



}

