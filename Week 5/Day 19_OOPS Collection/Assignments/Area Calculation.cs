using System.Net;

namespace Assignment
{

    abstract class Shape
    {
        public abstract double CalculateArea();

        public void DisplayArea()
        {
            Console.WriteLine($"Total Area:{CalculateArea()}");
        }

    }

    class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(double radius)
        {
            Radius = radius;
        }

      
        public override double CalculateArea()
        {
           
            return Math.PI * Radius*Radius; 
        }
    }
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle (double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Height * Width;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

           
            Circle area1 = new Circle(5.56);


           
           Rectangle area2 = new Rectangle(10.56,9.65); 


            area1.DisplayArea();
            area2.DisplayArea();


            Console.ReadLine();
        }
    }
}
