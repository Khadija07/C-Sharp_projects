namespace MathFunc;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ceiling:" + Math.Ceiling(16.3));
        Console.WriteLine("floor:" + Math.Floor(16.3));

        int x = 10;
        int y = 15;
        
        Console.WriteLine("Lowest between x and y is " + Math.Min(y, x) );
        Console.WriteLine("Highest between x and y is " + Math.Max(y, x) );
        
        Console.WriteLine("2 to the pow of 4 is" + Math.Pow(2, 4));
        Console.WriteLine("positive " + Math.Abs(-20));
        Console.WriteLine("cos of 1 is: {0}", Math.Cos(1));
    }
    
}