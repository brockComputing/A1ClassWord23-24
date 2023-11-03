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
            for (int i = 0; i < 10; i++)
            {
                int square = i * i;
                Console.WriteLine($"{i:-3}{square:-4}");
            }
            Console.ReadLine();
        }
        
       
        
    }
}
