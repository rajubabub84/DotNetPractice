using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Web.Factory.AbstractFactory
{
    public class EmployeeSystemManager
    {
        IComputerFactory _iComputerFactory;
        public EmployeeSystemManager(IComputerFactory iComputerFactory)
        {
            _iComputerFactory = iComputerFactory;
        }

        public string GetSystemDetails()
        {
            IBrand brand = _iComputerFactory.Brand();
            IProcessor processor = _iComputerFactory.Processor();
            ISystemType systemType = _iComputerFactory.SystemType();
            string returnValue = string.Format("{0} {1} {2}", brand.GetBrand(), systemType.GetSystemType(), processor.GetProcessor());
            return returnValue;
        }
    }
}