using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Web.Managers;

namespace Web.Factory
{
    public class EmployeeManagerFactory
    {
        public IEmployeeManager GetEmployeeManager(int employeeType)
        {
            IEmployeeManager returnValue = null;
            if (employeeType == 1)
                returnValue = new PermanentEmployeeManager();
            else if (employeeType == 2)
                returnValue = new ContractEmployeeManager();
            return returnValue;
        }
    }    
}