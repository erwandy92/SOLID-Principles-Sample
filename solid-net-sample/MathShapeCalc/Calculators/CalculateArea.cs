using System;

public class CalculateArea: ICalculateArea
{
    public double sum_up_all_areas(List<IShape> shapes)
    {
        double sum = 0;
        for (int i = 0; i < shapes.Count; i++)
        {
            IShape shape = shapes[i];
            sum += shape.calc_area();
        }
        return sum;
    }

    public int count_shapes(List<IShape> shapes)
    {
        return shapes.Count;
    }
}