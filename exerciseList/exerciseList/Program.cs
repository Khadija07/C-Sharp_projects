namespace exerciseList;

class Program
{
    static void Main(string[] args)
    {
        /*List<int> exerciseList = new List<int>();
        exerciseList.Add(1);
        exerciseList.Add(2);
        exerciseList.Add(3);
        foreach (int exercise in exerciseList)
        {
            Console.Write($"{exercise} ");
        }*/
        
        /*List<int> myNumbers = new List<int> { 1, 6, 3 };
        bool greaterThanFive = myNumbers.Any(x => x > 5);
        if (greaterThanFive)
        {
            Console.WriteLine("True");
        }
        else
        {
            Console.WriteLine("False");
        }*/
        
        /*Dictionary<string, List<int>> print = new Dictionary<string, List<int>>();
        print.Add("A", new List<int>{1,2,3});
        foreach (KeyValuePair<string,List<int>> item in print)
        {
            for (int i = 0; i < item.Value.Count; i++)
            {
                Console.Write(item.Value[i] + " ");
            }
        }*/

        try
        {
            Console.Write("Trying... ");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
        finally
        {
            Console.WriteLine("Finally executed.");
        }
    }
}