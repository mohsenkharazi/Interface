using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var square = new Square(5);
            DisplayPolygon("square", square);

            var triangle = new Triangle(5);
            DisplayPolygon("triangle", triangle);

            var Octagon = new Octagon(7);
            DisplayPolygon("octagon", Octagon);

            Console.ReadKey();
        }

        public static void DisplayPolygon(string name, dynamic polygon)
        {
            try
            {
                Console.WriteLine($"name : {name}\n" +
                    $"{polygon.Sides} \n" +
                    $"{polygon.Length} \n" +
                    $"{polygon.GetArea()} \n" +
                    $"{polygon.GetPerimeter()} \n");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()} :::: {ex.Message}");
            }

        }
    }
}
