using System;

public class CalculateArea
{
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

    public double count_shapes(List<Shape> shapes)
    {
        return shapes.Count;
    }
}