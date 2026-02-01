public class NotAShape : Shape
{
    public double calc_area()
    {
        throw new System.InvalidOperationException("NotAShape does not have area");
    }
}