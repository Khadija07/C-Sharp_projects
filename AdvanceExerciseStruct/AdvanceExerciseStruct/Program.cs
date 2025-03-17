using System.Drawing;

namespace AdvanceExerciseStruct;

class Program
{
    static void Main(string[] args)
    {
        Exercise ex = new Exercise();
        ex.TestEvents();
    }
}

public struct Event
{
    public DateTime StartDate;
    public DateTime EndDate;

    public Event(DateTime startDate, DateTime endDate)
    {
        StartDate = startDate;
        EndDate = endDate;
    }

    public double GetDuration()
    {
        return (EndDate.Day - StartDate.Day);
    }

    public bool IsOverlapping(Event otherEvent)
    {
        if (StartDate < otherEvent.StartDate && EndDate > otherEvent.StartDate)
        {
            return true;
        }
        return false;
    }
}

public class Exercise
{
    public void TestEvents()
    {
        DateTime startDate = new DateTime(2024, 7, 1);
        DateTime endDate = new DateTime(2024, 7, 10);
        Event firstEvent = new Event(startDate, endDate);
        
        Console.WriteLine($"Event 1 Duration: {firstEvent.GetDuration()}");
        
        DateTime start = new DateTime(2024, 7, 5);
        DateTime end = new DateTime(2024, 7, 15);
        Event secondEvent = new Event(start, end);
        Console.WriteLine($"Event 2 Duration: {secondEvent.GetDuration()}");
        
        Console.WriteLine($"Events Overlap: {firstEvent.IsOverlapping(secondEvent)}");
        
    }
}