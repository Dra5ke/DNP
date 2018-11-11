using System;

namespace Exercise_2._1
{
    class Student
    {
        public void Hi()
        {
            System.Console.WriteLine("Hi, I'm a student!");
        }
    }

    class DNPStudent : Student
    {
        new public void Hi()
        {
            System.Console.WriteLine("Hi, I'm a DNP stuent!");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dnpStudent = new DNPStudent();

            dnpStudent.Hi();
            
            Student student = (Student) dnpStudent;

            student.Hi();
        }
    }
}
