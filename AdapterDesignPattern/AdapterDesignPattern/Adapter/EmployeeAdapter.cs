using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;

namespace AdapterDesignPattern.Adapter
{
    public class EmployeeAdapter:EmployeeManager,IEmployee
    {
        public override string GetAllEmployees()
        {
            string returnXml= base.GetAllEmployees();
            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(returnXml);
            return JsonConvert.SerializeObject(xmlDocument, Newtonsoft.Json.Formatting.Indented);
        }
    }
}
