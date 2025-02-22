namespace Enums;

enum Days
{
    Mon, Tue, Wed, Thu, Fri, Sat, Sun
}

enum Months
{
    Jan, Feb, Mar, Apr, May, June, July = 10, Aug, Sep, Oct, Nov, Dec
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Days d1 = Days.Mon;
        Months m1 = Months.Jan;
        
        Console.WriteLine(d1);
        Console.WriteLine((int)Days.Fri);
        Console.WriteLine(m1);
    }
}