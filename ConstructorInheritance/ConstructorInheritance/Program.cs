namespace ConstructorInheritance;

class Program
{
    static void Main(string[] args)
    {
        Employee employee1 = new Employee("Mike", 56, "software developer", 123);
        //employee1.DisplayInfo();  //first goes to base class, then Employee class, then to displayinfo
        employee1.DisplayEmployeeInfo();
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
        Console.WriteLine($"derived: name: {Name}, age: {Age}");
    }

    public void DisplayEmployeeInfo()
    {
        DisplayInfo(); //call method from base class
        Console.WriteLine($"Name: {Name}, Age: {Age}, Job Title: {JobTitle}");
    }
}