namespace AdvanceExerciceInheritance;

class Program
{
    static void Main(string[] args)
    {
        Animal animal = new Animal();
        animal.MakeSound();
        
        Dog dog = new Dog();
        dog.MakeSound();
        
        Cat cat = new Cat();
        cat.MakeSound();
    }
}

class Animal
{
    public virtual void MakeSound()
    {
        Console.WriteLine("Animal makes a sound");
    }
}

class Dog : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Dog barks");
    }
}

class Cat : Animal
{
    public override void MakeSound()
    {
        Console.WriteLine("Cat meows");
    }

}