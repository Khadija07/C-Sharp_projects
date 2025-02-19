namespace DependencyInjection;

public interface ITools
{
    void NeedChef(Chef chef);
    void NeedIngredients(Ingredients ingredients);
}
public class Chef
{
    public void DoSomething()
    {
        Console.WriteLine("chef is here!");
    }
}

public class Ingredients
{
    public void DoSomething()
    {
        Console.WriteLine("ingredient is here!");
    }
}

public class Cook
{
    private Chef _chef;
    private Ingredients _ingredients;
    
    //constructor Dependency Injection
    public Cook(Chef chef, Ingredients ingredients)  //giving the constructors while using the Cook class.
    {
        
        //here we had to create objects to use it, but in constructor DI, they are already given through parameters from outside
        //_chef = new Chef();
        //_ingredients = new Ingredients();
        
        _chef = chef;
        _ingredients = ingredients;
        
    }

    public void Display()
    {
        _chef.DoSomething();
        _ingredients.DoSomething();
        Console.WriteLine("Cook complete!");
    }
}

//setter DI
public class Cooking
{
    //property
    public Chef Chef { get; set; }
    public Ingredients Ingredients { get; set; }
    

    public void Display()
    {
        Chef.DoSomething();
        Ingredients.DoSomething();
        Console.WriteLine("Cooking complete!");
    }
}

//interface injection
public class InterfaceCook : ITools
{
    private Chef _chef;
    private Ingredients _ingredients;
    
    public void NeedChef(Chef chef)
    {
        _chef = chef;
    }

    public void NeedIngredients(Ingredients ingredients)
    {
        _ingredients = ingredients;
        
    }

    public void Display()
    {
        
        _chef.DoSomething();
        _ingredients.DoSomething();
        Console.WriteLine("Interface Cooking complete!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Chef chef = new Chef(); //create the dependency outside
        Ingredients ingredients = new Ingredients();
        
       
        Cook cook = new Cook(chef, ingredients); //providing the dependency in constructor
        cook.Display();
        
        
        Cooking cooking = new Cooking();
        
        //inject dependencies via setter
        cooking.Chef = chef;
        cooking.Ingredients = ingredients;
        cooking.Display();
        
        //interface injection
        InterfaceCook interfaceCook = new InterfaceCook();
        interfaceCook.NeedChef(chef);
        interfaceCook.NeedIngredients(ingredients);
        interfaceCook.Display();
    }
}