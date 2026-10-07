using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        shapes.Add(new Square("blue", 5));
        shapes.Add(new Rectangle("red", 2, 4));
        shapes.Add(new Circle("pink", 3.1416));

        foreach (Shape item in shapes)
        {
            double area = item.GetArea();
            Console.WriteLine($"The color of the shape is {item.GetColor()}, and its area is: {area}");
        }
    }
}