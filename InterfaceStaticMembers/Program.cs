var rect = new Rectangle(2, 4);
var circle = new Circle(35);
var biggerShape = GetBiggerShape(rect, circle);
DisplayShape(rect);
void DisplayShape<T>(T shape) where T : IShape
{
    Console.WriteLine(T.Color);
    Console.WriteLine(shape.CalculateArea());
}
IShape GetBiggerShape<T, T2>(T s1, T2 s2) where T : IShape where T2 : IShape
{
    return s1 > s2 ? s1 : s2;
}

public interface IShape
{
    double CalculateArea();
    static abstract string? Color { get; set; }
    //możliwość implemetowania operatora
    static virtual bool operator > (IShape left, IShape right)
      => left.CalculateArea() > right.CalculateArea();
    static virtual bool operator < (IShape left, IShape right)
      => left.CalculateArea() < right.CalculateArea();
}
public class Rectangle: IShape
{
    private readonly double _width;
    private readonly double _height;
    public static string? Color { get; set; } = "red";
    public Rectangle(double width, double height)
    {
        _width = width;
        _height = height;
    }
    public double CalculateArea() => _width * _height;
}
public class Circle: IShape
{
    private readonly double _radius;
    public static string? Color { get; set; } = "green";
    public Circle(double radius)
    {
        _radius = radius;
    }
    public double CalculateArea() => _radius * _radius * Math.PI; 
}