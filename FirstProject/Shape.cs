using System;

namespace FirstProject;
public class Shape
{
    public int X { get; set; }
    public int Y { get; set; }

    //Słówko virtual pozwala przesłonić taką metodę w klasach pochodnych
    //w przeciwieństwie do abstract moga one mieć własną podstawową implementację
    public virtual void Draw()
    {
        Console.WriteLine("Drawing shape");
    }
}
public class Circle: Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing cirlce");
    }
}
public class Rectangle: Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing rectangle");
    }
}
public class Triangle: Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing triangle");
    }
}
