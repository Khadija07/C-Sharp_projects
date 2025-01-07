namespace QuizApp;

class Program
{
    static void Main(string[] args)
    {

        Question[] questions = new Question[]
        {
            new Question("What is the capital of Finland?", new string[] { "Barlin", "Paris", "Helsinki", "Madrid" }, 2),
            new Question("What is the capital of Bangladesh?", new string[] { "Barisal", "Chittagong", "Helsinki", "Dhaka" }, 3),
            new Question("What is 5 + 6?", new string[] { "4", "11", "3", "20" }, 1),
            new Question("What is the color of the orange?", new string[] { "Red", "Orange", "Yellow", "Blue" }, 1),
            
        };
        Quiz quiz = new Quiz(questions);
        quiz.StartQuiz();
        //quiz.DisplayQuestions(questions[0]);
        
        

        Console.ReadLine();
    }
}