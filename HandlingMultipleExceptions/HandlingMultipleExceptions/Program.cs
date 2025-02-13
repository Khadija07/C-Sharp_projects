namespace HandlingMultipleExceptions;

class Program
{
    static void Main(string[] args)
    {
        
       Program program = new Program();
       program.HandleMultipleExceptions("x", 2);
        
        
    }
    public void HandleMultipleExceptions(string s, int num)
    {
        
        int[] numbers = { 1, 2, 3 };

        try
        {
            int n = int.Parse(s);
            Console.WriteLine(numbers[num]);

        }
        catch (FormatException)
        {
            Console.WriteLine("Invalid format.");
        }
        catch (IndexOutOfRangeException)
        {
            Console.WriteLine("Index out of range.");
        }
        
    }
    
    
}
