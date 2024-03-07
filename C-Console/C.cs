using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace text_files
{
    class TextFilesAnswers
    {
        static void Main(string[] args)
        {
            string inp = "";
            do
            {
                Console.WriteLine("[1] to display");
                Console.WriteLine("[2] to count chars");
                Console.WriteLine("[3] to encrypt");
                Console.WriteLine("[4] to decrypt");
                Console.WriteLine("[5] to Vernam cipher");
                inp = Console.ReadLine();
                if (inp == "1")
                {
                    Display();
                }
                else if (inp == "2")
                {
                    Counter();
                }
                else if (inp == "3")
                {
                    Encrypt();
                }
                else if (inp == "4")
                {
                    Decrypt();
                }
                else if (inp == "5")
                {
                    //Vernam();
                    Vernam2(); // this
                }

            } while (inp != "9");

            Console.ReadLine();
        }

        private static void Vernam2()
        {
            // this method does not work because
            // a plain text char can be coded as a new line char
            // this means it is not read as a normal char in the ReadLine method
            // and never decrypted back.
            int xored;
            string nstr = "";
            StreamReader film = new StreamReader("film.txt");
            string otp = File.ReadAllText("otp.txt");
            StreamWriter temp = new StreamWriter("temp.txt");
            while (!film.EndOfStream)
            {
                string lineOFText = film.ReadLine();
                nstr = "";
                for (int i = 0; i < lineOFText.Length; i++)
                {
                    xored = (int)lineOFText[i] ^ (int)otp[i];
                    nstr = nstr + (char)xored;
                }
                temp.WriteLine(nstr);
            }
            temp.Close();
            film.Close();
            File.Delete("film.txt");
            File.Move("temp.txt", "film.txt");
        }

        private static void Vernam()
        {
            int xored;
            string nstr = "";
            string text = File.ReadAllText("film.txt");
            string otp = File.ReadAllText("otp.txt");
            for (int i = 0; i < text.Length; i++)
            {
                xored = (int)otp[i] ^ (int)text[i];
                nstr = nstr + (char)xored;
            }
            File.WriteAllText("film.txt", nstr);
        }

        private static void Decrypt()
        {
            string news = "";
            string lineoftext;
            int asc; char chr; string nstr = "";
            StreamReader film = new StreamReader("film.txt");
            StreamWriter temp = new StreamWriter("temp.txt");
            while (!film.EndOfStream)
            {
                nstr = "";
                lineoftext = film.ReadLine();
                for (int i = 0; i < lineoftext.Length; i++)
                {
                    asc = (int)lineoftext[i];
                    asc = asc - 1;
                    chr = (char)asc;
                    nstr = nstr + chr;
                }
                temp.WriteLine(nstr);
            }
            film.Close();
            temp.Close();
            File.Delete("film.txt");
            File.Move("temp.txt", "film.txt");
        }

        private static void Encrypt()
        {
            string news = "";
            string lineoftext;
            int asc; char chr; string nstr = "";
            StreamReader film = new StreamReader("film.txt");
            StreamWriter temp = new StreamWriter("temp.txt");
            while (!film.EndOfStream)
            {
                nstr = "";
                lineoftext = film.ReadLine();
                for (int i = 0; i < lineoftext.Length; i++)
                {
                    asc = (int)lineoftext[i];
                    asc = asc + 1;
                    chr = (char)asc;
                    nstr = nstr + chr;
                }
                temp.WriteLine(nstr);
            }
            film.Close();
            temp.Close();
            File.Delete("film.txt");
            File.Move("temp.txt", "film.txt");
        }

        private static void Counter()
        {
            Console.WriteLine("Letter");
            char let = Convert.ToChar(Console.ReadLine());
            string line;
            int count = 0;
            StreamReader file = new StreamReader("film.txt");
            while (!file.EndOfStream)
            {
                line = file.ReadLine();
                for (int i = 0; i < line.Length; i++)
                {
                    if (line[i] == let)
                    {
                        count++;
                    }
                }

            }
            file.Close();
            Console.WriteLine("Letter " + let + " appeared " + count + " times");
        }

        private static void Display()
        {
            //string theFile = File.ReadAllText("film.txt");
            //Console.WriteLine(theFile);
            Console.WriteLine("------");
            string line;
            StreamReader file = new StreamReader("film.txt");
            while (!file.EndOfStream)
            {
                line = file.ReadLine();
                Console.WriteLine(line);
            }
            file.Close();
        }
    }
}
