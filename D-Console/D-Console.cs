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
            int x = GetNum();
            int y = GetNum();
            int sum = 0;
            //no 5
            sum = Add2Nums(x, y) + 56 ;
            Console.WriteLine($"the addition is {sum}");
            sum = 0;
            Add2NumsWithRef(x, y,ref sum);
            Console.WriteLine($"the addition is {sum}");
            HelloFunction();

            int counter = LetterCount("e", "the cat sat on the mat"); 
            Console.ReadLine();
        }

        private static int LetterCount(string letter, string sentance)
        {
            int count = 0;
            for (int i = 0; i < sentance.Length; i++)
            {
                if (true)
                {
                    count++;
                }
            }

            return count;
        }

        private static void Add2NumsWithRef(int x, int y, ref int sum)
        {
            sum = x + y;
        }

        private static int GetNum()
        {
            Console.Write("Enter a number: ");
            int x = Convert.ToInt32(Console.ReadLine());
            return x;
        }

        private static int Add2Nums(int x, int y)
        {
            int answer = x + y;
            return answer;
        }

        private static void HelloFunction()
        {
            OrangeJuice();
            
            Console.WriteLine("hello from hello function");
        }

        private static void OrangeJuice()
        {
            int counter = 0; //local var
            for (int i = 0; i < 10; i++)
            {
                counter++;
                Console.WriteLine("this is from orange juice");
            }
        }
    }



}

