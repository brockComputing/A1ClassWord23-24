using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number_Conversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice, denNumber, bit, colheader;
            string binStr, hexStr;
            choice = 0;
            //Menu
            do
            {
                binStr = "";
                denNumber = 0;
                Console.WriteLine("1. Denary to Binary");
                Console.WriteLine("2. Binary to Denary");
                Console.WriteLine("3. Denary to Hexadecimal");

                Console.WriteLine("9. To exit");
                choice = Convert.ToInt32(Console.ReadLine());
                //Den to Bin
                if (choice == 1)
                {
                    Console.WriteLine("Input denary number");
                    denNumber = Convert.ToInt32(Console.ReadLine());
                    while (denNumber != 0)
                    {
                        bit = (denNumber % 2);
                        denNumber = denNumber / 2;
                        string Rbit = Convert.ToString(bit);
                        binStr = Rbit + binStr;

                    }
                    Console.WriteLine(binStr);
                    Console.ReadLine();
                }
                //Bin to Den
                else if (choice == 2)
                {
                    Console.WriteLine("Input binary number");
                    binStr = Console.ReadLine();
                    colheader = 1;
                    denNumber = 0;
                    for (int i = (binStr.Length - 1); i >= 0; i--)
                    {
                        bit = Convert.ToInt32(binStr[i]);
                        denNumber = denNumber + ((bit - 48) * colheader);
                        colheader = colheader * 2;
                    }
                    Console.WriteLine(denNumber);
                    Console.ReadLine();
                }
                //Den to Hex
                else if (choice == 3)
                {
                    hexStr = "";
                    Console.WriteLine("Input denary number");
                    denNumber = Convert.ToInt32(Console.ReadLine());
                    while (denNumber != 0)
                    {
                        bit = (denNumber % 16);
                        denNumber = denNumber / 16;
                        string hexbit = Convert.ToString(bit);
                        Console.WriteLine(hexbit);
                        if (hexbit == "10")
                        {
                            hexbit = "A";
                        }
                        else if (hexbit == "11")
                        {
                            hexbit = "B";
                        }
                        else if (hexbit == "12")
                        {
                            hexbit = "C";
                        }
                        else if (hexbit == "13")
                        {
                            hexbit = "D";
                        }
                        else if (hexbit == "14")
                        {
                            hexbit = "E";
                        }
                        else if (hexbit == "15")
                        {
                            hexbit = "F";
                        }
                        hexStr = hexbit + hexStr;
                    }
                    Console.WriteLine(hexStr);
                    Console.ReadLine();
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Input denary number");
                    hexStr = Console.ReadLine();
                    colheader = 1;
                    denNumber = 0;
                    for (int i = (hexStr.Length - 1); i >= 0; i--)
                    {
                        bit = Convert.ToInt32(hexStr[i]);
                        denNumber = denNumber + ((bit - 52) * 16);
                        colheader = colheader * 2;
                        string hexbit = Convert.ToString(bit);
                       // Console.WriteLine(hexbit);
                        if (hexbit == "A")
                        {
                            hexbit = "10";
                        }
                        else if (hexbit == "B")
                        {
                            hexbit = "11";
                        }
                        else if (hexbit == "C")
                        {
                            hexbit = "12";
                        }
                        else if (hexbit == "D")
                        {
                            hexbit = "13";
                        }
                        else if (hexbit == "E")
                        {
                            hexbit = "14";
                        }
                        else if (hexbit == "F")
                        {
                            hexbit = "15";
                        }
                    }
                    Console.WriteLine(denNumber);
                    Console.ReadLine();
                }
            } while (choice != 9);

        }
    }
}

