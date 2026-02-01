using System;

public class CalculateVolumeV2: ICalculateVolume
{

    public double sum_up_all_volumes(List<Shape3D> shapes)
    {
        double sum = 0;
        for (int i = 0; i < shapes.Count; i++)
        {
            Shape3D shape = shapes[i];
            sum += shape.calc_volume();
        }
        return sum + 10000; // just to differentiate from previous version
    }
}