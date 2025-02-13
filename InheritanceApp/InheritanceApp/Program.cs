namespace InheritanceApp;

class Program
{
    static void Main(string[] args)
    {
        Cat mycat = new Cat();
        mycat.Meow();
        mycat.Eat();
        
        
        
        Console.ReadKey();
    }
}

class Animal    //base class
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public virtual void MakeSound()    //virtual keyword in the base class
    {
        Console.WriteLine("makeSound");
    }
}

class Cat : Animal          //Derived Class: inherited Animal class using the ":" and the class name, now cat has to all methods of Animal class
{
    public override void MakeSound()  //override keyword in derived class, to override the method in the base class
    {
        Console.WriteLine("Meowing...");
    }
}

class Persian : Cat   //Further Derived Class
{
    public override void MakeSound()
    {
        Console.WriteLine("Persian Cat is Screaming...");
    }
}


