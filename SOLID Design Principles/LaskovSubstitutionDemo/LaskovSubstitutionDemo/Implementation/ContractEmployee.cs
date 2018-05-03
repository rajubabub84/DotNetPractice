using LaskovSubstitutionDemo.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaskovSubstitutionDemo.Implementation
{
    class ContractEmployee:IEmployee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public ContractEmployee() { }
        public ContractEmployee(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public override string ToString()
        {
            return string.Format("ID:{0},Name:{1}", this.ID, this.Name);
        }

        public decimal GetMinimumSalary()
        {
            return 5000;
        }
    }
}
