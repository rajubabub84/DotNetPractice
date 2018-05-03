using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApiTokenBasedAuthentication.Controllers
{
    public class EmployeeController : ApiController
    {
        [HttpGet]
        [Authorize]
        public List<Employee> GetEmployees()
        {
            using (var db = new DotNetPracticeEntities())
            {
                var employess = db.Employees.ToList();
                return employess;
            }
        }
        
    }
}
