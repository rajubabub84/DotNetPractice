using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Models;

namespace Web.Factory.FactoryMethod
{
    public class EmployeeManagerFactory
    {
        public BaseEmployeeFactory CreateFactory(Employee employee)
        {
            BaseEmployeeFactory returnValue = null;
            if(employee.EmployeeTypeID==1)
            {
                returnValue = new PermanentEmployeeFactory(employee);
            }
            else if(employee.EmployeeTypeID==2)
            {
                returnValue = new ContractEmployeeFactory(employee);
            }
            return returnValue;
        }
    }
}