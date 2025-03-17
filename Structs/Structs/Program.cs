namespace Structs;

public struct Point
{
    
    //common practice to make structs imutable
    //by declaring all fields at readonly and providing only get accessors for properties
    
    //public int X;
    //public int Y;
    
    public double X{get;}  //get accessors for properties
    public double Y{get;}
    

    public Point(double x, double y)
    {
        X = x;
        Y = y;
        
    }

    public void Display()
    {
        Console.WriteLine($"X: {X}, Y: {Y}");
    }

    public double Distance(Point p)
    {
        double xDiff = X - p.X;
        double yDiff = Y - p.Y;
        return Math.Sqrt(xDiff * xDiff + yDiff * yDiff);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Point p1 = new Point(5, 5);
        // p1.X = 5; //always assign value in the intial stage for the variable, public int X.
        // p1.Y = 5;
        p1.Display();
        
        //no need to create new instances, like class
        Point p2 = p1;
        p2.X = 7;
        p2.Display();

        Point p3 = new Point(2, 5);
        p3.Display();

        //measuring distance between two points(p1,p2)
        double distance = p1.Distance(p2);
        Console.WriteLine($"Distance: {distance:F3}"); //3 decimal places :F3
    }
}