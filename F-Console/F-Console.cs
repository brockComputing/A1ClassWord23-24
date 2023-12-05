using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VernamCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            string plainText = "", cipherText = "", oneTimePAd = "";
            do
            {
                Console.WriteLine("1. to enter one-time pad");
                Console.WriteLine("2. to enter plain text");
                Console.WriteLine("3. to enter cipher text");
                Console.WriteLine("4. to display cipher text");
                Console.WriteLine("5. to display plain text");
                Console.WriteLine("6. to display one-time pad");
                Console.WriteLine("7. Encrypt.");
                Console.WriteLine("8. Decrypt.");

                choice = Console.ReadLine();
                if (choice == "1")
                {
                    oneTimePAd = GetText("Enter the one time pad");
                }
                else if (choice == "2")
                {
                    plainText = GetText("Please enter the plain text");
                }
                else if (choice == "3")
                {
                    cipherText = GetText("Please enter the cipher text");
                }
                else if (choice == "4")
                {
                    Console.WriteLine("the cipher text --" + cipherText);
                }
                else if (choice == "5")
                {
                    Console.WriteLine("the plain text --" + plainText);
                }
                else if (choice == "6")
                {
                    Console.WriteLine("the one-time pad --" + oneTimePAd);
                }
                else if (choice == "7")
                {
                    cipherText = DoVernamCipher(plainText, oneTimePAd);
                }
                else if (choice == "8")
                {
                    plainText = DoVernamCipher(cipherText, oneTimePAd);
                }
            } while (choice.ToUpper() != "Y");
        }



        private static string DoVernamCipher(string plainORCipherText, string oneTimePad)
        {
            string output = "";
            int numberValuePlainText = 0, numberValueOneTimePad = 0;
            char charTobeAdded = ' ';
            int newValue = 0;
            for (int i = 0; i < plainORCipherText.Length; i++)
            {
                // numberValuePlainText <- plainORCipherText at position i -65
                numberValuePlainText = plainORCipherText[i] - 65; 
                // numberValueOneTimePad <- oneTimePad at position i - 65
                // newValue <-(numberValuePlainText Xor numberValueOneTimePad)
                // charTobeAdded <- ConvertTochar(newvalue + 65)
                // output <- output + charTobeAdded
            }

            return output;
        }
        private static string GetText(string v)
        {
            Console.WriteLine(v);
            return Console.ReadLine().ToUpper();
        }

    }
}
