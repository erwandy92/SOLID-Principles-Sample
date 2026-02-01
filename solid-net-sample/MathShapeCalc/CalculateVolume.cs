using System;

public class CalculateVolume: ICalculateVolume
{

    public double sum_up_all_volumes(List<Shape3D> shapes)
    {
        double sum = 0;
        for (int i = 0; i < shapes.Count; i++)
        {
            Shape3D shape = shapes[i];
            sum += shape.calc_volume();
        }
        return sum;
    }
}