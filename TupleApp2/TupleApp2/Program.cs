using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TupleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            TupleClass tc = new TupleApp2.TupleClass();
            Console.WriteLine(tc.returntuple().Item1);
            Console.WriteLine(tc.returntuple().Item2);
            Console.WriteLine(tc.returntuple().Item3);
            Console.ReadLine();

        }
    }

    public class TupleClass
    {
        public Tuple<int,string,string> returntuple()
        {
            Tuple<int,string,string> tp = new Tuple<int,string,string>(1, "abc", "def");
            return tp;
        }
    }
}
