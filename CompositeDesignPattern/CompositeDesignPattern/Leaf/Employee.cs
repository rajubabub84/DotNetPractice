﻿using CompositeDesignPattern.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeDesignPattern.Leaf
{
    public class Employee : IEmployee
    {
        public string Name { get; set; }
        public string Department { get; set; }
        public Employee(string name,string dept)
        {
            this.Name = name;
            this.Department = dept;
        }
        public void GetDetails(int intendation)
        {
            Console.WriteLine(string.Format("{0}- Name:{1},Department:{2} (Leaf)",new string('-',intendation), this.Name, this.Department));
        }
    }
}
