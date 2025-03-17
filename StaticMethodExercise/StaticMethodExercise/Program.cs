namespace StaticMethodExercise
{
    internal class Program
    {

        public static int DoubleValue(int number)
        {
            number = number * 2;
            return number; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.DoubleValue(10));

            Console.ReadKey();
        }

        

    }

}
