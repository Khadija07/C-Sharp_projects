using System.Diagnostics;

namespace TryCatch;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        int result = 0;
        
        //debug log
        Debug.WriteLine("program is running!");

        try
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());

            result = num2 / num1;
        }
        catch (FormatException
               ex) //to check the type of exception, print ex.toString(), such as "System.FormatException: The input string 'f' was not in a correct format."
        {
            Console.WriteLine("Invalid number!" + ex.Message);
        }
        catch (OverflowException ex)
        {
            Console.WriteLine("Number too big!" + ex.Message);
        }
        catch (Exception ex) //default exception
        {
            Console.WriteLine(ex.ToString()); //this will show the error message to the user, shows in console
            Debug.WriteLine(ex.Message); //this shows in debug output
            Debug.WriteLine(ex
                .ToString()); //converting the entire exception to string, it is only executed during 'debugging', not in build mode
        }
        finally
        {
            Console.WriteLine("Program is running!");
        }

        Age age = new Age(35);
       
        if (age.CurrentAge > 20)
        {
            throw new Exception("age greater than 20!");  //application will crash 
        }
        Console.WriteLine($"age: {age.CurrentAge}");
        

    }
}

public class Age
{
    public int CurrentAge { get; set; }

    public Age(int age)
    {
        CurrentAge = age;
    }
}