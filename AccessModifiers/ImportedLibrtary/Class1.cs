using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImportedLibrtary
{
    public class Class1
    {
        protected int subract(int x, int y)
        {
            return x - y;
        }
        protected internal int Mutliply(int x, int y)
        {
            return x * y;
        }
    }
    internal class Class2
    {
        protected internal int Divide(int x, int y)
        {
            return x / y;
        }
    }

    public class Class3
    {
        public void Print()
        {
            Class2 c2 = new Class2();
            c2.Divide(4,2);
        }
    }

    

}
