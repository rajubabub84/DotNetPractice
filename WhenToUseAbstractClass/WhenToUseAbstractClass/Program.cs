using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhenToUseAbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {          

            FullTimeEmployee fte = new WhenToUseAbstractClass.FullTimeEmployee()
            {
                ID = 101,
                FirstName = "Mike",
                LastName = "Jason",
                AnnualSalary = 60000
            };
            Console.WriteLine(fte.GetFullName());
            Console.WriteLine(fte.GetMonthlySalary());

            Console.WriteLine("...........");

            ContractEmployee cte = new ContractEmployee()
            {
                ID = 102,
                FirstName = "Sara",
                LastName = "S",
                HourlyPay = 200,
                TotalHours=40
            };
            Console.WriteLine(cte.GetFullName());
            Console.WriteLine(cte.GetMonthlySalary());

            Console.ReadLine();
        }
    }
}
