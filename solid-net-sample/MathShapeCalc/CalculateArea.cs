using System;

public class CalculateArea
{
    // public double CalculateCircleArea(double radius)
    // {
    //     return System.Math.PI * radius * radius;
    // }

    // public double CalculateRectangleArea(double length, double width)
    // {
    //     return length * width;
    // }

    // public double CalculateTriangleArea(double @base, double height)
    // {
    //     return 0.5 * @base * height;
    // }

    public double sum_up_all_areas(List<Shape> shapes)
    {
        double sum = 0;
        for (int i = 0; i < shapes.Count; i++)
        {
            Shape shape = shapes[i];
            sum += shape.calc_area();
        }
        return sum;
    }
}