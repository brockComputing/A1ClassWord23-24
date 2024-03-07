using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysExtraTasks
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            string test = "Uk,1,pounds,france, 1.2, euro";
            string[] stuff = test.Split(',');
            CharCount();
            //string currentLine;
            //StreamReader currentFile = new StreamReader("film.txt");
            //while (!currentFile.EndOfStream)
            //{
            //    currentLine = currentFile.ReadLine();
            //    Console.WriteLine(currentLine);
            //}
            //currentFile.Close();

            Console.ReadLine();
        }

        private static void CharCount()
        {
            Console.WriteLine("Enter a letter");
            string letter = Console.ReadLine();
            string currentLine;
            int count = 0;
            StreamReader currentFile = new StreamReader("film.txt");
            while (!currentFile.EndOfStream)
            {
                currentLine = currentFile.ReadLine();
                foreach (char theLetter in currentLine)
                {
                    if (theLetter.ToString() == letter)
                    {
                        count++;
                    }
                }
                //for (int i = 0; i < currentLine.Length; i++)
                //{
                //    if (currentLine[i].ToString() == letter)
                //    {
                //        count++;
                //    }
                //}
            }
            Console.WriteLine($"The letter {letter} occurs {count} times");
            currentFile.Close();
        }
    }
}