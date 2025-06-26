using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CollectionProject
{
    class Student : IComparable<Student>
    {
        public int Sid { get; set; }
        public string Name { get; set; }
        public int Class { get; set; }
        public float Marks { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Sid > other.Sid)
                return 1;
            else if (this.Sid < other.Sid)
                return -1;
            else
                return 0;
        }
    }
    class ComparerStudents:IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Marks > y.Marks)
                return -1;
            else if (x.Marks < y.Marks)
                return -1;
            else
                return 0;

        }
    }
    class TestStudent
    {
        static void Main()
        {
            Student s1 = new Student { Sid = 1021, Name = "Scott", Class = 10, Marks = 545.00f };
            Student s2 = new Student { Sid = 1023, Name = "Vamsi", Class = 10, Marks = 455.00f };
            Student s3 = new Student { Sid = 1013, Name = "Himanshu", Class = 10, Marks = 525.00f };
            Student s4 = new Student { Sid = 1014, Name = "Harsh", Class = 10, Marks = 467.00f };

            List<Student> students = new List<Student>() { s1, s2, s3, s4 };
            students.Sort();
            foreach(Student S in students)
            {
                Console.WriteLine(S.Sid + " " + S.Name+" "+S.Class+" "+S.Marks);
            }
            Console.ReadLine();

        }
    }
}
