using System;

namespace Assignment
{
    internal class Program
    {
        static int CalculateArea(int side)
        {
            return side * side;
        }

        static double CalculateArea( double r)
        {
            return Math.PI * r * r;
        }

        static float CalculateArea(float length, float breadth)
        {
            return length * breadth;
        }
    
   
        static void Main(string[] args)
        {
        
            Console.WriteLine("Area of square:"+ CalculateArea(3));
        
            Console.WriteLine("Area of Circle:"+CalculateArea(4.5));
            Console.WriteLine("Area of Rectangle:"+ CalculateArea(30.45f,40));

        }
    }
}
