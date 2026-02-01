using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        ICalculateArea areaCalculator = new CalculateArea();
        ICalculateVolume volumeCalculator = new CalculateVolume();
        ICalculateVolume volumeCalculatorV2 = new CalculateVolumeV2();

        //2D Shapes
        Square square = new Square(5);
        Rectangle rectangle = new Rectangle(4, 6);
        Circle circle = new Circle(3);

        //3D Shape
        Cube cube = new Cube(2);

        //Not a Shape
        // NotAShape notAShape = new NotAShape();

        List<IShape> shapes = new List<IShape> { square, rectangle, circle, cube };
        double totalArea = areaCalculator.sum_up_all_areas(shapes);

        List<IShape3D> shapes3D = new List<IShape3D> { cube };
        double totalVolume = volumeCalculator.sum_up_all_volumes(shapes3D);

        ShapesInfo shapesInfo = new ShapesInfo(areaCalculator, volumeCalculatorV2);
        Console.WriteLine(shapesInfo.print_shapes_count(shapes));
        Console.WriteLine(shapesInfo.print_shapes_calculated_areas(shapes));
        Console.WriteLine(shapesInfo.print_shapes_calculated_volumes(shapes3D));
    }
}
