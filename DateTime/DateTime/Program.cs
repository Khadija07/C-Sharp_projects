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
        
        DateTime dayMay = new DateTime(1997, 05, 07);
        Console.WriteLine("7th May is "+ dayMay.DayOfWeek);
        
        DateTime dayMarch = new DateTime(1992, 03, 08);
        Console.WriteLine("8th March is "+ dayMarch.DayOfWeek);
        
        //current time 
        Console.WriteLine(DateTime.Now);
        
        //tomorrow
        Console.WriteLine(DateTime.Now.AddDays(1));
        
        //calling method to get day after tomorrow
        DateTime dayAfter = DayAfterTomorrow();
        Console.WriteLine(dayAfter);
        
        Console.WriteLine(DateTime.Now.DayOfWeek);
        Console.WriteLine(FirstDayOfTheYear());

        DateTime d = DateTime.Now;
        Console.WriteLine($"{d.Hour} o'clock and {d.Minute} minutes and {d.Second} seconds");

    }

    static DateTime DayAfterTomorrow()
    {
        return DateTime.Now.AddDays(2);
        
    }

    static DateTime FirstDayOfTheYear()
    {
        return new DateTime(DateTime.Now.Year, 1, 1);
    }
}