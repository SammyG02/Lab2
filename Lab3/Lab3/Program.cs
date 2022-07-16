using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {

        abstract class BaseClass
        {
            public abstract double calculateArea();
            public abstract double calculatePerimeter();

            public static readonly double PI = 3.14;
            

            public double length{ get; set; }
            public double width { get; set; }
            public double radius{ get; set; }

                                     

        }
        class Circle : BaseClass
        {
            public override double calculateArea()
            {
                return (PI * radius * radius);
            }

            public override double calculatePerimeter()
            {
                return (2 * PI * radius);
            }
        }
        class Rectangle : BaseClass
        {
            public override double calculateArea()
            {
                return (length*width);
            }

            public override double calculatePerimeter()
            {
                return ((length+width)*2);
            }

        }
        

        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.radius = 4;

            Console.WriteLine(circle.calculateArea());
            
            Console.WriteLine(circle.calculatePerimeter());
            

            Rectangle rectangle = new Rectangle();
            rectangle.width = 4;
            rectangle.length = 5;
            Console.WriteLine(rectangle.calculateArea());
            Console.WriteLine(rectangle.calculatePerimeter());
         
           
            

        }
    }
}
