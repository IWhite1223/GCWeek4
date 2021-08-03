using System;

namespace ObjectDemo2
{
    //Learning Stack and Heap
    class Rectangle
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
          // Let's try copying object varibles around
          //But first do it with integers to compare

            int x;
            x = 10;
            int y = x; // second equals first. this took the ten from x and coppied it into y
            //so now y has 10

            //now change x 
            x = 15;

            //now what is in y?
            //we didn't change y, so it still has 10 in it

            //now lets make an instance of rectangle

            Rectangle first;
            first = new Rectangle()
            { L = 15, W = 20 };
            Console.WriteLine(first.Area());

            Rectangle second;
            second = first;
            Console.WriteLine(second.Area());

            second.L = 25;
            Console.WriteLine(first.L);

            


        }
    }
}

