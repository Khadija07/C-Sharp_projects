namespace DIExercice;

public interface IShape
{
    double GetArea();
}

public class Circle : IShape
{
    private double _radius;
    
    public Circle(double r)
    {
        _radius = r;
    }
    public double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
}

public class Rectangle : IShape
{
    private double _height;
    private double _width;
    
    public Rectangle(double w, double h)
    {
        _height = h;
        _width = w;
    }

    public double GetArea()
    {
        return _height * _width;
    }
}

public class ExerciseP
{
    
    public void PrintAreas()
    {
        // TODO: Add your code here
        IShape shape = new Circle(5);
        IShape shape2 = new Rectangle(5, 5);
        Console.WriteLine(shape.GetArea());
        Console.WriteLine(shape2.GetArea());
    }
}
public class Polymorphism
{
    public void PrintAreas()
    {
        // TODO: Add your code here
        IShape shape = new Circle(5);
        IShape shape2 = new Rectangle(6, 4);
        Console.WriteLine($"Area: {shape.GetArea()}");
        Console.WriteLine($"Area: {shape2.GetArea()}");
    }
}