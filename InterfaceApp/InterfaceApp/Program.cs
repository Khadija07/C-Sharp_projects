namespace InterfaceApp;

class Program
{
    //interface: It ensures that a class implements specific methods without dictating how they should be implemented.
    public interface IAnimal
    {
        //declare method
        void Eat(string food);
        void MakeNoise();
    }
    
    public class Dog: IAnimal
    {
        //methods are implemented
        public void Eat(string food)
        {
           Console.WriteLine($"dog eating {food}");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Dog barks!");
        }
    }

    public class Cat : IAnimal
    {
        public void Eat(string food)
        {
            Console.WriteLine($"cat drinking {food}");
        }

        public void MakeNoise()
        {
            Console.WriteLine("Cat meows!!");
        }
    }
    static void Main(string[] args)
    {
        Dog dog = new Dog();
        dog.MakeNoise();
        dog.Eat("bone");
        Cat cat = new Cat();
        cat.MakeNoise();
        cat.Eat("milk");
    }
}