﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Composite
{
    public class Manager : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public List<IEmployee> SubOrdinates;
        public Manager(string name,string dept)
        {
            this.Name = name;
            this.Department = dept;
            this.SubOrdinates = new List<IEmployee>();
        }
        public void GetDetails(int intendation)
        {
            Console.WriteLine(string.Format("{0}+Name:{1},Department:{2} - Manager(Composite)",new string('-',intendation), this.Name,this.Department));
            foreach(IEmployee component in SubOrdinates)
            {
                component.GetDetails(intendation+1);
            }
        }
    }
}
