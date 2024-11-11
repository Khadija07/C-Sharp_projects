
namespace averageTemperatureExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperatures = [10, -1, 12.5, 34.5, -10];
            Program myProg = new Program();
            myProg.CalculateAverage(temperatures);
            myProg.PrintAverage(temperatures);
            Console.ReadKey();

        }

        public void PrintAverage(double[] temperatures)
        {
            Console.WriteLine("The average temperature is: " + CalculateAverage(temperatures));

        }

        public double CalculateAverage(double[] temperatures)
        {
            double sum = 0;
            foreach (double item in temperatures)
            {
                sum += item;
            }

            double average = sum / temperatures.Length;
            return average;
        }
        
    }
}
