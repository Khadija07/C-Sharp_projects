namespace ConstructorInheritance;

class Program
{
    static void Main(string[] args)
    {
        //Employee employee1 = new Employee("Mike", 56, "software developer", 123);
        //employee1.DisplayInfo();  //first goes to base class, then Employee class, then to displayinfo
        //employee1.DisplayEmployeeInfo();

        Manager Carl = new Manager("carl", 60, "manager", 103, 10);
        Carl.Aging(10);
        Carl.DisplayInfo();
        //Carl.DisplayManagerInfo();
        
        //Console.WriteLine(Carl.ToString());  //every class inherits from the 'object' class, press 'command' keyboard and go to the ToString(), the class is 'object class'
    }
}

public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    
    //base class constructor
    public Person(string name, int age)
    {
        Console.WriteLine("Constructor");
        Name = name;
        Age = age;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
    
    //below are XML comments, we can see the description when we hover over the method name 'Aging'
    
    /// <summary> Adds years to the the age of the object </summary>
    /// <param name="years"></param>
    /// <returns> New age after becoming older</returns>

    public int Aging(int years)
    {
        Age += years;
        return Age;
    }
}

public class Employee : Person
{
    public string JobTitle { get; private set; }
    public int EmployeeId { get; private set; }
    
    //derived class constructor
    public Employee(string name, int age, string jobTitle, int employeeId) : base(name, age)  //with base, it is called the base class constructor
    {
        Console.WriteLine("Derived class Constructor");
        JobTitle = jobTitle;
        EmployeeId = employeeId;
        //Console.WriteLine($"derived: name: {Name}, age: {Age}");
    }

    public void DisplayEmployeeInfo()
    {
        DisplayInfo(); //call method from base class
        Console.WriteLine($"EmployerID: {EmployeeId}, Job Title: {JobTitle}");
    }
}

//multiple derived classes
public class Manager : Employee
{
    public int TeamSize { get; private set; }
    public Manager(string name, int age, string jobTitle, int employeeId, int teamSize) : base(name, age, jobTitle, employeeId)
    {
        TeamSize = teamSize;
    }

    public void DisplayManagerInfo()
    {
        DisplayEmployeeInfo();
        Console.WriteLine($"Team Size: {TeamSize}");
    }
}