using ImportedLibrtary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifiers
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            ClasssB b = new ClasssB();
            
            
        }

        
    }

    public class ClassA:Class1
    {
        protected int add(int x, int y)
        {
            Mutliply(2, 3);
            subract(3, 2);

            return x + y;
        }
    }

    internal class ClasssB:ClassA
    {
        //public void Add()
        //{
        //    // add(2, 3);            
        //}
    }



}
