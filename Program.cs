using System;

namespace SingleResponsibility
{
    public class Student
    {
        public string StudentName { get; set; }
        public string StudentSurName { get; set; }
        public int StudentNo { get; set; }

        public Student(string name,string surName,int no)
        {
            this.StudentName = name;
            this.StudentSurName = surName;
            this.StudentNo = no;
        }
    }
    public class StudentWriter
    {
        public void WriteStudent(Student student)
        {
            Console.WriteLine("Student Name: " + student.StudentName);
            Console.WriteLine("Student Surname: " + student.StudentSurName);
            Console.WriteLine("Student Number: " + student.StudentNo);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Jack", "Necker", 18);

            StudentWriter writer = new StudentWriter();

            writer.WriteStudent(student);
        }
    }
}
