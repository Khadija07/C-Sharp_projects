namespace section6AdvancedExercise;

class Student
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Grade { get; set; }

    public Student(int id, string name, int grade)
    {
        ID = id;
        Name = name;
        Grade = grade;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Student> students = new Dictionary<string, Student>();
        students.Add("John", new Student(1, "John", 85));
        students.Add("Alice", new Student(2, "Alice", 90));
        students.Add("Bob", new Student(3, "Bob", 78));

        foreach (var student in students)
        {
            Console.WriteLine($"Name: {student.Value.Name}, Id: {student.Value.ID}, Grade: {student.Value.Grade}");
        }
        
    }
}