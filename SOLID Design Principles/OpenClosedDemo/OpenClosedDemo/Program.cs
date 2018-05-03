using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empJohn = new OpenClosedDemo.PermanentEmployee(1, "John");
            Employee empJason = new OpenClosedDemo.TemporaryEmployee(2, "Jason");

            Console.WriteLine(string.Format("Employee {0} Bonus:{1}", empJohn.ToString(), empJohn.CalculateBonus(100000).ToString()));
            Console.WriteLine(string.Format("Employee {0} Bonus:{1}", empJason.ToString(), empJason.CalculateBonus(100000).ToString()));
            Console.ReadLine();
        }
    }
}
