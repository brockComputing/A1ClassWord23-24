using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter12
{
    class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public bool DepositPaid { get; set; }
        public DateTime Dob { get; set; }
        public string studentID { get; set; }
        public ConsoleColor hairColour { get; set; }
    }


    class Program
    {

        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();

            for (int i = 0; i < 4; i++)
            {
                string xx;
                Student student = new Student();
                Console.WriteLine("Enter the name");
                student.FirstName = Console.ReadLine() + i;
                studentList.Add(student);
                xx = "helerjl";
            }
            
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(studentList[i].FirstName);
            }



            Console.ReadLine();
        }



    }
}