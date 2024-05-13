using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scratch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "hello";

            x = x.Insert(4,x[1].ToString());
            x = x.Remove(2,1);
            Console.WriteLine(x);
            Console.ReadLine();
          
        }
        static int counter = 0;
        private static void Hello()
        {
          
        }
    }
}
