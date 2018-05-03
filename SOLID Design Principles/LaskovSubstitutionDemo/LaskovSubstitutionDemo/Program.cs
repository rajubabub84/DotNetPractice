using LaskovSubstitutionDemo.Implementation;
using LaskovSubstitutionDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskovSubstitutionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            employees.Add(new PermanentEmployee(1, "John"));
            employees.Add(new TemporaryEmployee(2, "Jason"));
            //employees.Add(new ContractEmployee(3, "Mike"));
            foreach (var employee in employees)
            {
                Console.WriteLine(string.Format("Employee {0} Bonus:{1} Minimum Salary:{2}",
                    employee.ToString(),
                    employee.CalculateBonus(100000).ToString(),
                    employee.GetMinimumSalary().ToString()));
            }

            List<IEmployee> employeesOnly = new List<IEmployee>();
            employeesOnly.Add(new PermanentEmployee(1, "John"));
            employeesOnly.Add(new TemporaryEmployee(2, "Jason"));
            employeesOnly.Add(new ContractEmployee(3, "Mike"));

            foreach (var employee in employeesOnly)
            {
                Console.WriteLine(string.Format("Employee {0} Minimum Salary:{1}",
                    employee.ToString(),
                    employee.GetMinimumSalary().ToString()));
            }

            //Employee empJohn = new PermanentEmployee(1, "John");
            //Employee empJason = new TemporaryEmployee(2, "Jason");
            //Employee empMike = new ContractEmployee(3, "Mike");

            //Console.WriteLine(string.Format("Employee {0} Bonus:{1}", empJohn.ToString(), empJohn.CalculateBonus(100000).ToString()));
            //Console.WriteLine(string.Format("Employee {0} Bonus:{1}", empJason.ToString(), empJason.CalculateBonus(100000).ToString()));
            //Console.WriteLine(string.Format("Employee {0} Bonus:{1}", empMike.ToString(), empMike.CalculateBonus(100000).ToString()));
            Console.ReadLine();
        }
    }
}
