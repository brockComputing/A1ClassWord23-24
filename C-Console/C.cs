using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Chap12
{
    class Student
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public bool DepositPaid { get; set; }
        public DateTime Dob { get; set; }
        public int AttendancePercent { get; set; }
        public ConsoleColor HairColour { get; set; }
    }

    class Chapter12
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            for (int i = 0; i < 4; i++)
            {
                string teststr = "hello";
                Student student = new Student();
                student.FirstName = "Geoff-" + i;
                studentList.Add(student);
                teststr = "bye";
            }
            test
            foreach (var item in studentList)
            {
                Console.WriteLine(item.FirstName);
            }
            //Console.WriteLine(student1.FirstName);
            //Console.WriteLine(student1.HairColour);
            //Console.WriteLine(student2.FirstName);
            //Console.WriteLine(student2.HairColour);

            Console.ReadLine();
        }


    }
}
