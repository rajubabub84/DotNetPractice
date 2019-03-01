using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOutVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=1;
            int y=2;

            Program p = new Program();
            p.modify(ref x, out y);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.ReadLine();
        }

        public void modify(ref int refVariable,out int outVariable)
        {
           // refVariable = 10;
           outVariable = 20;
        }
    }
}
