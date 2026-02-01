public class Square : IShape
{
    public double side_length;

    public Square(double side_length)
    {
        this.side_length = side_length;
    }

    public double getSideLength() {
        return side_length;
    }

    public double calc_area()
    {
        return Math.Pow(getSideLength(), 2);
    }
}