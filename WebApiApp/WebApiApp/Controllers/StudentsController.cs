using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiApp.Models;

namespace WebApiApp.Controllers
{
    [MyCustomExceptionFilter]
    public class StudentsController : ApiController
    {
        public List<Student> Get()
        {
            return StudentRepository.GetAllStudents();
        }

        public Student Get(string id)
        {
            Student student= StudentRepository.GetStudent(id);
            if (student == null)
                throw new HttpResponseException(new HttpResponseMessage {StatusCode=HttpStatusCode.NotFound,ReasonPhrase="Student Doesn't exist",Content=new StringContent("no record found") });
            return student;
        }

        public void Post(Student student)
        {
            StudentRepository.AddStudent(student);
        }

        public void Put(Student student)
        {
            StudentRepository.UpdateStudent(student);
        }

        public void Delete(string id)
        {
            StudentRepository.RemoveStudent(id);
        }
    }
}
