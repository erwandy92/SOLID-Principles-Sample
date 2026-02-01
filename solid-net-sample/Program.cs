using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        CalculateArea areaCalculator = new CalculateArea();
        Square square = new Square(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Circle circle = new Circle(3);

        List<Object> shapes = new List<Object> { square, rectangle, circle };
        double totalArea = areaCalculator.sum_up_all_areas(shapes);

        Console.WriteLine(areaCalculator.print_shapes_count(shapes));
        Console.WriteLine(areaCalculator.print_shapes_calculated_areas(shapes));
    }
}
