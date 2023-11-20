using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Console
{
    internal class C
    {
        static void Main(string[] args)
        {
            // copy the code into here 
            int choice = 0, denNumber = 0, bit, colheader;
            string binStr = "", hexStr = "";
            choice = 0;
            do
            {
                binStr = "";
                denNumber = 0;
                Console.WriteLine("1. Denary to Binary");
                Console.WriteLine("2. Binary to Denary");
                Console.WriteLine("3. den to hex");
                Console.WriteLine("4. Hex to DEN");
                Console.WriteLine("9. To exit");
                choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    // code for den to bin here
                    Console.WriteLine("Enter a denary number");
                    denNumber = Convert.ToInt32(Console.ReadLine());
                    while (denNumber != 0)
                    {
                        bit = denNumber % 2;
                        binStr = bit + binStr;
                        denNumber = denNumber / 2;
                    }
                    Console.WriteLine(binStr);
                }
                else if (choice == 2) // bin to den
                {
                    binStr = "10";
                    colheader = 1;
                    for (int i = binStr.Length - 1; i >= 0; i--)
                    {
                        bit = Convert.ToInt32(binStr[i].ToString());
                        denNumber = denNumber + (bit * colheader);
                        colheader = colheader * 2;
                    }
                    Console.WriteLine(denNumber);

                }
                else if (choice == 3) // den to hex
                {
                    Console.WriteLine("Enter a denary number");
                    denNumber = Convert.ToInt32(Console.ReadLine());
                    while (denNumber != 0)
                    {
                        bit = denNumber % 16;
                        if (bit == 10)
                        {
                            hexStr = "A" + hexStr;
                        }
                        else if (bit == 11)
                        {
                            hexStr = "B" + hexStr;
                        }
                        else if (bit == 12)
                        {
                            hexStr = "C" + hexStr;
                        }
                        else if (bit == 13)
                        {
                            hexStr = "D" + hexStr;
                        }
                        else if (bit == 14)
                        {
                            hexStr = "E" + hexStr;
                        }
                        else if (bit == 15)
                        {
                            hexStr = "F" + hexStr;
                        }
                        else
                        {
                            hexStr = bit + hexStr;
                        }
                        denNumber = denNumber / 16;
                    }
                    Console.WriteLine(hexStr);
                }
                else if (choice == 4) // hex to den
                {
                    string hexDigit = "";
                    Console.WriteLine("enter a hex number");
                    hexStr = Console.ReadLine();
                    colheader = 1;
                    for (int i = hexStr.Length - 1; i >= 0; i--)
                    {
                        //bit = Convert.ToInt32(hexStr[i].ToString());
                        hexDigit = hexStr[i].ToString().ToUpper();
                        if (hexDigit == "A")
                        {
                            bit = 10;
                        }
                        else if (hexDigit == "B")
                        {
                            bit = 11;
                        }
                        else if (hexDigit == "C")
                        {
                            bit = 12;
                        }
                        else if (hexDigit == "D")
                        {
                            bit = 13;
                        }
                        else if (hexDigit == "E")
                        {
                            bit = 14;
                        }
                        else if (hexDigit == "F")
                        {
                            bit = 15;
                        }
                        else
                        {
                            bit = Convert.ToInt32(hexDigit);
                        }
                        denNumber = denNumber + (bit * colheader);
                        colheader = colheader * 16;
                    }
                    Console.WriteLine(denNumber);
                }
            } while (choice != 9);

        }


    }
}
