// See https://aka.ms/new-console-template for more information
using System;
public class MyClass
{
    // TODO: Declare a private readonly field to store the value

    private static string nextID = "";
    
    private readonly string _id;
    // TODO: Create a public read-only property to expose the field's value
    public string ID { get { return _id; } }

    public MyClass(string value)
    {
        // TODO: Initialize the readonly field with the value parameter
        _id = value;
    }
}

public class Exercise
{
    public void PrintReadOnlyProperty()
    {
        // TODO: Create an instance of MyClass with the value "Read-Only Property Value"
        MyClass myClass = new MyClass("Read-Only Property Value");
        Console.WriteLine(myClass.ID);
        
        // TODO: Print the value of the read-only property to the console
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Exercise exercise = new Exercise();
        exercise.PrintReadOnlyProperty();
    }
}