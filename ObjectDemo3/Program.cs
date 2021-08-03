using System;

namespace ObjectDemo3
{
    
    //created a Model od some concept called "rectangle"
    //a model is a computer representation of some real world thing
    class Rectangle
    {
        public int L;
        public int W;

        public int Area()
        {
            return L * W;
        }

    }
    class Program
    {
      
      static void TestParam(int n ) 
        {
           //Pass by value means the value, not the original
           //varible itself, get passed into the function
            n++;
            Console.WriteLine(n);
        }

        static void PrintRect(Rectangle r)
        {
            Console.WriteLine("Here is your rectangle:");
            //This is a destrcutive operation because we're breaking or destroying 
            //this object that was sent in. Be carefull with that!
            //alternatice is "non destructive" where we dont change the objects we received.

            r.W = r.W + 1;
            Console.WriteLine(r.W);
            Console.WriteLine(r.L);
            Console.WriteLine(r.Area());

        }

        static void PrintRect2(Rectangle r) 
        {
            // a non destuctive approach. This is the best practice and best way to not break it.
            Rectangle myCopy = new Rectangle() { L = r.L, W = r.W };
            myCopy.W = myCopy.W + 1;
            Console.WriteLine(myCopy.W);
            Console.WriteLine(myCopy.L);
            Console.WriteLine(myCopy.Area());

        }


        static void Main(string[] args)
        {

            int x = 10;
            x++; 
            //x = x +1
            Console.WriteLine(x++);
            Console.WriteLine(x);

            //TestParam(x);
            //Console.WriteLine(x);

            //Rectangle first = new Rectangle() { L = 15, W = 10 };
            //PrintRect(first);

            //Console.WriteLine("Heres tje orignial. it changed !!");
            //Console.WriteLine(first.L);
            //Console.WriteLine(first.W);
            //Console.WriteLine(first.Area());

        }
    } 
}
   

