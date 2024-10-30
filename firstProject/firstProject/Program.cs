// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information


Console.WriteLine("Enter First Number!");
double myNumber1 = 0.0, myNumber2 = 0.0;
string userInput = Console.ReadLine();
myNumber1 = double.Parse(userInput);


Console.WriteLine("Enter Second Number!");

userInput = Console.ReadLine();

myNumber2 = double.Parse(userInput);

double sum = myNumber1 + myNumber2;
sum = Math.Round(sum, 2);



//Console.WriteLine("your sum "+ sum);
Console.WriteLine($"your sum is {sum}");


Console.ReadKey();



