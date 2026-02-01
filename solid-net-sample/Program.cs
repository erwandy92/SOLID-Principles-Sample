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
        Cube cube = new Cube(2);
        NotAShape notAShape = new NotAShape();

        List<Shape> shapes = new List<Shape> { square, rectangle, circle, cube, notAShape };
        double totalArea = areaCalculator.sum_up_all_areas(shapes);

        ShapesInfo shapesInfo = new ShapesInfo();
        Console.WriteLine(shapesInfo.print_shapes_count(shapes.Count));
        Console.WriteLine(shapesInfo.print_shapes_calculated_areas(totalArea));
    }
}
