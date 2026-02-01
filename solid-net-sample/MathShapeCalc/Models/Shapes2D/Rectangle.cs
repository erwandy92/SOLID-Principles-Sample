public class Rectangle : IShape
{
    public double length;
    public double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double getLength()
    {
        return length;
    }

    public double getWidth()
    {
        return width;
    }

    public double calc_area()
    {
        return getLength() * getWidth();
    }
}