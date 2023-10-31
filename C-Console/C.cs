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
            // iteration


            for (int rows = 0; rows < 10; rows++)
            {
                for (int stars = 0; stars < 3; stars++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }


    }
}
