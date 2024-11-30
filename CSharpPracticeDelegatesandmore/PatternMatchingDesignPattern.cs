using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPracticeDelegatesandmore
{
    public class PatternMatchingDesignPattern
    {
        public static double calculateArea(Shape shape)
        {
            return shape switch
            {
                Circle c => Math.PI * c.Radius * c.Radius,
                Rectangle r => r.Length * r.Width,
                Triangle r => 0.5 * r.Base * r.Height,
                _ => throw new ArgumentException("Unknown shape")

            };
        }
    }
    public abstract class Shape { }
    public class Circle: Shape 
    {
        public double Radius { get; set; }
    }

    public class Rectangle : Shape
    {
        public double Length { get; set; }
        public double Width { get; set; }
    }

    public class Triangle : Shape
    {
        public double Base { get; set; }
        public double Height { get; set; }
    }



}
