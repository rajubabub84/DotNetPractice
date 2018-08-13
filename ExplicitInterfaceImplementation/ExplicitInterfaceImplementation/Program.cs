using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaceImplementation
{
    interface I1
    {
        void InterfaceMethod();
    }
    interface I2
    {
        void InterfaceMethod();
    }
    class Program:I1,I2
    {
        void I1.InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }

        public void InterfaceMethod()
        {
            Console.WriteLine("I1 Interface Method");
        }
        void I2.InterfaceMethod()
        {
            Console.WriteLine("I2 Interface Method");
        }
        static void Main(string[] args)
        { 
            //One way
            Program p = new Program();
            ((I1)p).InterfaceMethod();
            ((I2)p).InterfaceMethod();

            //Another way
            I1 i1 = new Program();
            I2 i2 = new Program();
            i1.InterfaceMethod();
            i2.InterfaceMethod();
            

            //Default Implementation
            p.InterfaceMethod();
            ((I2)p).InterfaceMethod();

            Console.Read();
        }       
    }
}
