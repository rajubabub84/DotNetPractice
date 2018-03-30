using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton fromemployee = Singleton.GetInstance;
                fromemployee.PrintDetails("from employee");

            Singleton fromStudent =  Singleton.GetInstance;
            fromStudent.PrintDetails("from student");

            //Singleton.DerivedSingleton ds = new SingletonDemo.Singleton.DerivedSingleton();
            //ds.PrintDetails("from derived class");

            Console.ReadLine();
        }
    }


}
