using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> students = new List<Student>()
            {
                new Student(){ID=1,Name="aaa",Age=15},
                new Student(){ID=2,Name="bbb",Age=16},
                new Student(){ID=3,Name="ccc",Age=17},
                new Student(){ID=4,Name="ddd",Age=18},
                new Student(){ID=5,Name="eee",Age=19}
            };

            var result = from student in students
                         where student.Age > 17
                         select student;


            students.Add(new Student() { ID = 6, Name = "fff", Age = 20 });

            foreach(Student s in result)
            {
                Console.WriteLine(s.Name);
            }

            Console.ReadLine();   
            


        }
    }

    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
