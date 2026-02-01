public class ShapesInfo
{

    private CalculateArea area_calculator = new CalculateArea();
    private CalculateVolume volume_calculator = new CalculateVolume();

    public String print_shapes_count(List<Shape> shapes)
    {
        return "Total Shapes: " + area_calculator.count_shapes(shapes);
    }

    public String print_shapes_calculated_areas(List<Shape> shapes)
    {
        return "Total Area: " + area_calculator.sum_up_all_areas(shapes);
    }

    public String print_shapes_calculated_volumes(List<Shape3D> shapes)
    {
        return "Total Volume: " + volume_calculator.sum_up_all_volumes(shapes);
    }
}