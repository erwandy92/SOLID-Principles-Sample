public class Circle : Shape
{
    public double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double getRadius()
    {
        return radius;
    }

    public double calc_area()
    {
        return Math.PI * getRadius() * getRadius();;
    }
}