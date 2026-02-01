public class ShapesInfo
{

    private readonly ICalculateArea area_calculator;
    private readonly ICalculateVolume volume_calculator;

    public ShapesInfo(ICalculateArea calculateArea, ICalculateVolume calculateVolume)
    {
        this.area_calculator = calculateArea;
        this.volume_calculator = calculateVolume;
    }
    public String print_shapes_count(List<IShape> shapes)
    {
        return "Total Shapes: " + area_calculator.count_shapes(shapes);
    }

    public String print_shapes_calculated_areas(List<IShape> shapes)
    {
        return "Total Area: " + area_calculator.sum_up_all_areas(shapes);
    }

    public String print_shapes_calculated_volumes(List<IShape3D> shapes)
    {
        return "Total Volume: " + volume_calculator.sum_up_all_volumes(shapes);
    }
}