namespace DateTimePart;

class Program
{
    static void Main(string[] args)
    {
        DateTime date = new DateTime(2025, 02, 21);
        Console.WriteLine("Today is {0}", date);
        Console.WriteLine("Tomorrow is {0}", date.AddDays(1));
        Console.WriteLine("Today is {0}", date.DayOfWeek);
        Console.WriteLine($"Tomorrow is {date.ToUniversalTime()}");
        
        //current time 
        Console.WriteLine(DateTime.Now);
        
        //tomorrow
        Console.WriteLine(DateTime.Now.AddDays(1));
        
        //calling method to get day after tomorrow
        DateTime dayAfter = DayAfterTomorrow();
        Console.WriteLine(dayAfter);
        
        Console.WriteLine(DateTime.Now.DayOfWeek);
    }

    static DateTime DayAfterTomorrow()
    {
        return DateTime.Now.AddDays(2);
    }
}