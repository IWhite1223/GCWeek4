using System;

namespace ObjectDemo
{
    class MyClass
    {
        // member variables 
        public int L;
        public int W;

        //member functions (Methods)

        public int Area()
        {
            return L * W;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int x; //our basic types int, double, decimal. etc. Are "value" types. They go on the stack.
            x = 10;
            Console.WriteLine(x);

            MyClass y; // Our classes (and strings) are objects and go on the heap. So our varible holds a pointer to it.
            y = new MyClass();
            y.L = 15;
            y.W = 20;
            Console.WriteLine(y.Area());

            MyClass z;
            z = new MyClass();
            z.L = 20;
            z.W = 25;
            Console.WriteLine(z.Area());
        }
    }
}
