namespace InheritanceExercise;

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee("John Doe", 123);
        employee.Display();
    }
}
public class Person
{
    // TODO: Declare a constructor that takes a name and prints a message
    public string Name {get; private set;  }
    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"Person constructor: {Name}");
    }
}

public class Employee : Person
{
    // TODO: Declare a constructor that takes a name and an ID, and calls the base class constructor
        
    public int ID {get; private set; }
        
    public Employee(string name, int id): base(name){
        ID = id;
        
            
    }

    public void Display()
    {
        Console.WriteLine($"Employee constructor: {Name}, ID: {ID}");
    }
}

public class Exercise
{
    public void PrintMessages()
    {
        Employee employee = new Employee("John Doe", 123);
        employee.Display();
    }
}