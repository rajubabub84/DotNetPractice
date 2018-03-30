using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApiApp.Models;

namespace WebApiApp
{
    public class StudentRepository
    {      

        private static List<Student> students;
        
        public static List<Student> GetAllStudents()
        {
            students = new List<Student>
            {
                    new Student {StudentID="1",FirstName="fname1",LastName="lanme1" },
                     new Student {StudentID="2",FirstName="fname2",LastName="lanme2" },
                      new Student {StudentID="3",FirstName="fname3",LastName="lanme3" }
            };

            return  students;   
            
        }

        public static Student GetStudent(string studentID)
        {
            students = new List<Student>
            {
                    new Student {StudentID="1",FirstName="fname1",LastName="lanme1" },
                     new Student {StudentID="2",FirstName="fname2",LastName="lanme2" },
                      new Student {StudentID="3",FirstName="fname3",LastName="lanme3" }
            };
            Student student = students.Find(s => s.StudentID == studentID);
            if (student == null)
                return null;
            
            return student;
        }

        public static void RemoveStudent(string studentID)
        {
            Student student = students.Find(s => s.StudentID == studentID);
            students.Remove(student);
        }

        public static void AddStudent(Student student)
        {
            students.Add(student);
        }

        public static void UpdateStudent(Student student)
        {

        }
    }
}