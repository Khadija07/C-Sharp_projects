namespace ListSection;

class Program
{
    static void Main(string[] args)
    {
        //creating and initializing a list
        List<string> colors = new List<string>();   
        List<int> numbers = new List<int>{30, 2, 12, 6, 8, 10};
        
        colors.Add("red");
        colors.Add("green");
        colors.Add("blue");
        colors.Add("red");

        //List<string> colorList = ["red, green, blue"];

        foreach (string color in colors)
        {
            
            Console.WriteLine(color);
        }

        bool deleteColor = colors.Remove("red");  //removes the first occurence
        
        //removes all the occurrences of red
        while (deleteColor) //this will be true as long as there is red in the list
        {
            deleteColor = colors.Remove("red");  
        }
        
        foreach (string color in colors)
        {
            
            Console.WriteLine(color);
        }
        
        
        //sorting
        Console.WriteLine("unsorted list");

        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        
        numbers.Sort();
        Console.WriteLine("sorted list");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
            
        }
        
        
        //return list of numbers greater and equal to 10
        List<int> higherNums1 = numbers.FindAll(x => x >= 10); //predicate with lambda expression
        Console.WriteLine("higher and equal to 10");

        foreach (int number in higherNums1)
        {
            Console.WriteLine(number);
            
        }
        
        //define the predicate to check if a number is greater than 10
        Predicate<int> isGreaterThanTen = x => x > 10;
        List<int> higherNums2 = numbers.FindAll(isGreaterThanTen);
        
        Console.WriteLine("higher than 10");
        foreach (int number in higherNums2)
        {
            Console.WriteLine(number);
        }
        
        //ANY method
        bool hasLargerNum = numbers.Any(x => x > 20);
        if (hasLargerNum)
        {
            Console.WriteLine("there are numbers larger than 20");
        }
        
        //product class
        List<Product> products = new List<Product>{new Product {name = "apple", price = 0.7}, 
            new Product {name = "berry", price = 0.8}};
        

        foreach (Product product in products)
        {
            Console.WriteLine(product.name);
        }
        
        //using LINQ with list, list.where(), System.link namespace is needed to use LINQ
        List<Product> cheapProducts = products.Where(x => x.price < 1.0).ToList();
        
        
        
        
        Console.ReadKey();
    }
}