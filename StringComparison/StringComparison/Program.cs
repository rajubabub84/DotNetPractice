using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int x = 1;
                int y = 0;
                int z = x / y;
                string a = "Class";
                string b = "class";
                if (a == b)
                {
                    Console.WriteLine("equal");
                }
                else
                {
                    Console.WriteLine("not equal");
                }

                if (a.Equals(b))
                {
                    Console.WriteLine("equal");
                }
                else
                {
                    Console.WriteLine("not equal");
                }

                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine("exception occured");
            }
            int i = 10;

            Console.ReadLine();

        }
    }
}
