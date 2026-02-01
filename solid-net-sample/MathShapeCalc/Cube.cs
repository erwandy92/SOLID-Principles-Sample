public class Cube: Shape, Shape3D
{
    public double side_length;

    public Cube(double side_length)
    {
        this.side_length = side_length;
    }

    public double getSideLength() {
        return side_length;
    }

    public double calc_area()
    {
        return 6 * Math.Pow(getSideLength(), 2);
    }

    public double calc_volume()
    {
        return Math.Pow(getSideLength(), 3);
    }
}