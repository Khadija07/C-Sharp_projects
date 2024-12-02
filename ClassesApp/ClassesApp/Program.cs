namespace ClassesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Car audi = new Car("A7", "Audi", true); //object created
            Car toyota = new Car("Yaris", "Toyota", false);
            audi.Model = "A10";
            audi.Brand = Console.ReadLine();

            Console.WriteLine("new model "+ audi.Brand);
            Console.WriteLine("new model " + toyota.Brand);

            Car car1 = new Car("A7", "Audi", true);
            car1.Drive();*/


            Customer customer = new Customer("KTK","Kilo","Espoo");

            customer.SetDetails("Khadija", "Kilo", "Espoo"); //changes to the name

            Customer.CustomerInfo(); //calling static method directly




            
            
            Console.ReadKey();
        }
    }
}
