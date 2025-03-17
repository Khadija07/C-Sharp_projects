namespace Dictionary;

class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Employee(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        //declaring dictionary
        Dictionary<int, string> employees = new Dictionary<int, string>();
        
        //complex object as the value of a dictionary
        Dictionary<int, Employee> employeeObj = new Dictionary<int, Employee>();
        
        employeeObj.Add(1, new Employee("Fatima", 25));
        employeeObj.Add(2, new Employee("Lubna", 15));
        employeeObj.Add(3, new Employee("Tasnim", 35));

        foreach (var employee in employeeObj)
        {
            Console.WriteLine($"ID: {employee.Key}, name: {employee.Value.Name}, age: {employee.Value.Age}");
        }
        
        //adding items to dictionary
        employees.Add(10, "Ktk");
        employees.Add(15, "Alex");
        employees.Add(20, "Ayn");
        employees.Add(40, "Mike");

        string name = employees[10];
        Console.WriteLine(name);

        employees[15] = "Ana";
        Console.WriteLine(employees[15]);
        
        employees.Remove(20);

        foreach (KeyValuePair<int, string> e in employees)
        {
            Console.WriteLine(e);
        }
        
        //checking and adding value to a key
        if (!employees.ContainsKey(10))
        {
            employees.Add(10, "Sarah");
        }

        int counter = 20;
        if (employees.ContainsKey(counter))
        {
            counter++;
        }
        employees.Add(counter, "Lubna");
        
        //dicts plus string as key
        var codes = new Dictionary<string, string>
        {
            ["HEL"] = "Helsinki",    //we can now directly declare the string key and value, without using add method.
            ["SAU"] = "Saudi"
        };
        
        //checking if a value exists in a specific key, the program won't crash even if the key doesn't exist
        if (codes.TryGetValue("SAU", out string state))
        {
            Console.WriteLine(state);
        }

        foreach (var code in codes)
        {
            Console.WriteLine($"code: {code.Key}, state: {code.Value}");
        }
        

        Console.ReadKey();

    }
}