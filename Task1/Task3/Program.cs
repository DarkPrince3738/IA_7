using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var subject1 = new Subject();
            subject1.Name = "SleepWithProgramming";

            var teacher1 = new Teacher();
            teacher1.FirstName = "Olga";
            teacher1.LastName = "Chenko";
            teacher1.BirthDate = new DateTime(1992, 10, 21);
            teacher1.Subject = subject1;


            var student3 = new Student();
            student3.FirstName = "Kolya";
            student3.LastName = "Vasenko";
            student3.BirthDate = new DateTime(2005, 05, 7);

            var student2 = new Student();
            student2.FirstName = "Misha";
            student2.LastName = "KOKO";
            student2.BirthDate = new DateTime(1978, 01, 3);

            var student1 = new Student();
            student1.FirstName = "Vasya";
            student1.LastName = "Petrosenko";
            student1.BirthDate = new DateTime(2015, 07, 9);

            var studentList = new Student[3] { student1, student2, student3};

            var groupA = new Group();
            groupA.Name = "a";
            groupA.StudentList = studentList;
            groupA.LeaderTeacher = teacher1;

            var class1 = new Class();
            class1.Group = groupA;


            var school = new School();
            school.Classes = new Class[] { class1};
        }
    }
}
