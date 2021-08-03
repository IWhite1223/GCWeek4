using System;

namespace Lab4._1
{
    class Parallelagram
    {
        public double L;
        public double W;

        public double GetArea()
        {
            return L * W;
        }

        public double GetPerimeter()
        {
            return (2 * (L + W));
        }
        public void PrintParallelagram()
        {
            
            Console.WriteLine($"Width: {W}");
            Console.WriteLine($"Legnth: {L}");
            Console.WriteLine($"Area: {GetArea()}");
            Console.WriteLine($"Perimeter: {GetPerimeter()}");
        }

    }
        
    class Program
    {
        static void TestParam(int n)
        {
            //Pass by value means the value, not the original
            //varible itself, get passed into the function
            n++;
            Console.WriteLine(n);
        }
      

        static void Main(string[] args)
        {
            Parallelagram A = new Parallelagram() { L = 20, W = 10 };
            Console.WriteLine($"Length: {A.L}");
            Console.WriteLine($"Width: {A.W}");
            Console.WriteLine($"Area: {A.GetArea()}");
            Console.WriteLine($"Parimeter: {A.GetPerimeter()}");
            A.PrintParallelagram();
            

        }
    }
}
