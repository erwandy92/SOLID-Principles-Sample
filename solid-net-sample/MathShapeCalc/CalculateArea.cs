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

    public double sum_up_all_areas(List<Object> shapes)
    {
        double sum = 0;
        for (int i = 0; i < shapes.Count; i++)
        {
            Object shape = shapes[i];
            if(shape is Square)
            {
                sum += Math.Pow(((Square)shape).side_length, 2);
            }
            else if(shape is Rectangle)
            {
                Rectangle rectangle = (Rectangle)shape;
                sum += rectangle.getLength() * rectangle.getWidth();
            }else if(shape is Circle)
            {
                Circle circle = (Circle)shape;
                sum += Math.PI * circle.getRadius() * circle.getRadius();
            }else if(shape is Cube)
            {
                Cube cube = (Cube)shape;
                sum += 6 * Math.Pow(cube.getSideLength(), 2);
            }
        }
        return sum;
    }
}