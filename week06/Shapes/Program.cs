using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Square sq1 = new Square();
        sq1.SetSide(3);
        sq1.SetColor("Yellow");
        Console.WriteLine(sq1.GetArea());

        Rectangle rc1 = new Rectangle();
        rc1.SetLength(3);
        rc1.SetWidth(5);
        rc1.SetColor("Green");
        Console.WriteLine(rc1.GetArea());

        Circle cr1 = new Circle();
        cr1.SetRadius(2);
        cr1.SetColor("Blue");
        Console.WriteLine(cr1.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq1);
        shapes.Add(rc1);
        shapes.Add(cr1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape.GetShapeType()} is {shape.GetColor()} and has an area of {shape.GetArea()}");
        }
    }
}