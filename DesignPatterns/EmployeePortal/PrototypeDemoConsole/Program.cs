using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace PrototypeDemoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //ShallowCopy();
            ShallowCopyRef();
        }
        public static void ShallowCopy()
        {
            Employee empJohn = new Employee()
            {
                Id = new Guid(),
                Name = "John",
                DepartmentID = 150
            };
            Console.WriteLine(empJohn.ToString());

            Employee empSam = (Employee)empJohn.Clone();
            empSam.Name = "SamPaul";
            Console.WriteLine(empSam.ToString());

            Console.WriteLine("Changed Johns Department ID to 161");
            empJohn.DepartmentID = 161;
            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());
            Console.ReadLine();
        }

        public static void ShallowCopyRef()
        {
            Employee empJohn = new Employee()
            {
                Id = new Guid(),
                Name = "John",
                DepartmentID = 150,
                AddressDetails = new Address()
                {
                    DoorNo = 10,
                    StreetNo = 20,
                    ZipCode = 90025,
                    Country = "US"
                }
            };

            Console.WriteLine(empJohn.ToString());

            Employee empSam = (Employee)empJohn.Clone();
            empSam.Name = "Sam Paul";
            empSam.DepartmentID = 151;            
            empSam.AddressDetails.DoorNo = 11;
            empSam.AddressDetails.StreetNo = 21;

            Console.WriteLine(empSam.ToString());

            Console.WriteLine("Modified Address Details of John");            
            empJohn.AddressDetails.DoorNo = 30;
            empJohn.AddressDetails.StreetNo = 40;
            empJohn.DepartmentID = 160;

            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());

            Console.ReadLine();
           
        }

        public static void PrototypeDemo()
        {
            Employee empJohn = new Employee()
            {
                Id = new Guid(),
                Name = "John",
                DepartmentID = 150,
                AddressDetails = new Address()
                {
                    DoorNo = 10,
                    StreetNo = 20,
                    ZipCode = 90025,
                    Country = "US"
                }
            };

            Console.WriteLine(empJohn.ToString());

            Employee empSam = (Employee)empJohn.DeepCopy();
            empSam.Name = "Sam Paul";
            empSam.DepartmentID = 151;
            empSam.AddressDetails.DoorNo = 11;
            empSam.AddressDetails.StreetNo = 21;

            Console.WriteLine(empSam.ToString());

            Console.WriteLine("Modified Address Details of John");
            empJohn.AddressDetails.DoorNo = 30;
            empJohn.AddressDetails.StreetNo = 40;
            empJohn.DepartmentID = 160;

            Console.WriteLine(empJohn.ToString());
            Console.WriteLine(empSam.ToString());

            Console.ReadLine();
        }
    }
    public partial class Employee:CloneablePrototype<Employee>
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int DepartmentID { get; set; }       
        public override string ToString()
        {
            return string.Format("Name:{0} "+"DepartmentID:{1} {2}",this.Name,this.DepartmentID.ToString(), AddressDetails.ToString());
        }

    }
    public partial class Employee : ICloneable
    {
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
    public partial class Employee
    {
        public Address AddressDetails { get; set; }
    }
    public class Address
    {
        public Address() { }
        public int DoorNo { get; set; }
        public int StreetNo { get; set; }
        public int ZipCode { get; set; }
        public string Country { get; set; }
        public override string ToString()
        {
            return string.Format("Addres Details:Door No:{0},Street:{1},ZipCode:{2},Country:{3}",this.DoorNo,this.StreetNo,this.ZipCode.ToString(),this.Country);
        }
    }

    public abstract class CloneablePrototype<T>
    {
        public T Clone()
        {
            return (T)this.MemberwiseClone();
        }

        public T DeepCopy()
        {
            string result = JsonConvert.SerializeObject(this);
            return JsonConvert.DeserializeObject <T>(result);
        }
    }
}
