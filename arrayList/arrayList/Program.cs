using System.Collections;

namespace arrayList;

class Program
{
    static void Main(string[] args)
    {
        
        //declare arrayList
        ArrayList myArrayList = new ArrayList();
        myArrayList.Add("Hello");
        myArrayList.Add("World");
        myArrayList.Add(25);
        myArrayList.Add(10);
        myArrayList.Add(6.5);
        
        double sum = 0;

        foreach (object obj in myArrayList) //as the array contains data of all types, we have to declare it as 'object', not 'int obj in myArrayList'
        {
            if (obj is double)
            {
                sum += (double)obj;   //even if it is a double, we have to cast the value in double to add
            }
            else if (obj is int)
            {
                sum += Convert.ToDouble(obj); //convert int to double to add
            }
            
        }
        Console.WriteLine($"sum: {sum}");
        
        
        //Nullable
        
        int? num = null;

        if (num.HasValue)
        {
            Console.WriteLine($"num: {num.Value}");
        }
        else
        {
            //Console.WriteLine(num.Value); //we cannot write this as num does not have any value
        }
    }
}