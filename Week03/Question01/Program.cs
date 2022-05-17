using System;

namespace Question01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool debug = false;

            Person myPerson = new Person();
            myPerson.Greet();

            Student myStudent = new Student();
            myStudent.setAge(21);
            myStudent.Greet();
            myStudent.ShowAge();

            Teacher myTeacher = new Teacher();
            myTeacher.setAge(30);
            myTeacher.Greet();
            myTeacher.Explain();

            if (debug) {
                Console.ReadLine();
            }
        }
    }
}
