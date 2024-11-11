using System.Diagnostics.CodeAnalysis;

namespace weatherSimulator
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days: ");
            int days = int.Parse(Console.ReadLine());
            int[] temperature = new int[days];
            string[] weather = { "sunny", "rainy", "snowy", "cloudy" };
            string[] actualWeather = new string[days];

            Random random = new Random();
            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-20, 40);
                actualWeather[i] = weather[random.Next(weather.Length)];
            }

            //foreach (int i in temperature)
            //{
            //    Console.WriteLine(i);
            //}
            //foreach (string i in actualWeather)
            //{
            //    Console.WriteLine(i);

            //}

            Console.WriteLine("The max tamperature is: " + temperature.Max());
            Console.WriteLine("The min tamperature is: " + temperature.Min());
            Console.WriteLine("The average of temperatures is "+averageTemp(temperature));
            Console.WriteLine("most condition: " + MostCommonWeather(actualWeather));

            Console.ReadKey();

        }

        static string MostCommonWeather(string[] conditions)
        {
            int count = 0;
            string mostCommon = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int temp = 0;
                for (int j = 0; j < conditions.Length; j++)
                {
                    if (conditions[j] == conditions[i]){
                        temp++;
                    }
                }

                if (temp > count){
                    count = temp;
                    mostCommon = conditions[i];
                }
            }
            return mostCommon;
        }

        static double averageTemp(int[] temperature)
        {
            double sum = 0;
            foreach(int item in temperature) 
            {
                sum = sum + item;

            }
            double average = sum / temperature.Length;
            return average;
        }

    }
}
