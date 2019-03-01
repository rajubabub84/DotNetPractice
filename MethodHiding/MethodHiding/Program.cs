using System;

namespace MethodHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClassB b = new ClassB();
            //ClassA a = new ClassA();
            ClassA a;
            a = new ClassB();

            //Console.WriteLine(b.add(3, 2));
           Console.WriteLine(a.add(3, 2));
           // Console.WriteLine(b.sub(3, 2));
            Console.WriteLine(a.sub(3, 2));
            Console.ReadLine();
        }
    }

    public class ClassA
    {
        public virtual int add(int x, int y)
        {
            return x + y;
        }

        public virtual int sub(int x,int y)
        {
            return x - y;
        }
    }

    public class ClassB : ClassA
    {
        public new int  add(int x,int y)
        {
            return x - y;
        }

        public override int sub(int x, int y)
        {
            return x + y;
        }
    }
}