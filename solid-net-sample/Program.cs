using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        ICalculateArea areaCalculator = new CalculateArea();
        ICalculateVolume volumeCalculator = new CalculateVolume();
        
        //2D Shapes
        Square square = new Square(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Circle circle = new Circle(3);

        //3D Shape
        Cube cube = new Cube(2);

        //Not a Shape
        // NotAShape notAShape = new NotAShape();

        List<Shape> shapes = new List<Shape> { square, rectangle, circle, cube };
        double totalArea = areaCalculator.sum_up_all_areas(shapes);

        List<Shape3D> shapes3D = new List<Shape3D> { cube };
        double totalVolume = volumeCalculator.sum_up_all_volumes(shapes3D);

        ShapesInfo shapesInfo = new ShapesInfo(areaCalculator, volumeCalculator);
        Console.WriteLine(shapesInfo.print_shapes_count(shapes));
        Console.WriteLine(shapesInfo.print_shapes_calculated_areas(shapes));
        Console.WriteLine(shapesInfo.print_shapes_calculated_volumes(shapes3D));
    }
}
