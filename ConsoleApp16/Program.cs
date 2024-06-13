using HW_W5_01.A;
using System.Drawing;
using HW_W5_01.B;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {   //A :
            var shapes = new List<Shape>()
            {
                new Rectangular(2,3),
                new Square(3)
            };
            // Polymorphism
            shapes.ForEach(x => Console.WriteLine($"Area : {x.Area()}"));
            Console.WriteLine("".PadLeft(50,'*'));
            //B:
            var triangles = new List<Triangle>()
            {
                new RightTriangle(2, 3),
                new equilateralTriangle(3)
            };
            // Polymorphism
            triangles.ForEach(x => Console.WriteLine($"Area : {x.Area()}"));
        }
    }
}
