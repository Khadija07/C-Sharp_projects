namespace QuizApp;

public class Quiz
{
    private Question[] _questions;   //array that will hold multiple Question objects
    private int _correctAnswers = 0;

    public Quiz(Question[] questions)
    {
        this._questions = questions;
    }

    public void StartQuiz()
    {
        Console.WriteLine("Welcome to the Quiz App!");
        int questionNumber = 1;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("=====================================================================");
        Console.WriteLine("=======================   Q U E S T I O N S   =======================");
        Console.WriteLine("=====================================================================");
        Console.ResetColor();
        foreach (Question question in _questions)
        {
            Console.WriteLine("Question " + questionNumber++ + ": ");
            DisplayQuestions(question);
            int userAnswer = GetUserAnswer();
          
            if (question.IsCorrect(userAnswer))
            {
                _correctAnswers++;
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Wrong! The correct answer is " + question.Answers[question.CorrectAnswerIndex]);    //displaying the correct answer
            }
        }
        
        DisplayAnswers();
    }

    private void DisplayAnswers()
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        Console.WriteLine("=====================================================================");
        Console.WriteLine("======================= R  E   S   U   L   T   S ====================");
        Console.WriteLine("=====================================================================");
        Console.ResetColor();

        double percentage = (double)(_correctAnswers / _questions.Length);

        if (percentage >= 0.9)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Game Over! You have answered {_correctAnswers} of {_questions.Length} questions. CONGRATULATIONS!");
        }
        else
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Game Over! You have answered {_correctAnswers} of {_questions.Length} questions.");
        }
    }

 

    private void DisplayQuestions(Question question)
    {
        Console.WriteLine($"Question: {question.QuestionText}");
        for (int i = 0; i < question.Answers.Length; i++)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;   //color of the font
            Console.Write("  ");
            Console.Write(i + 1);
            Console.ResetColor();
            Console.WriteLine($". {question.Answers[i]}");
            
        }
    }

    private int GetUserAnswer()
    {
        string input = Console.ReadLine();
        int choice = 0;
        while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)    //checks whether input can be converted to int, if yes, assigns value to choice, also checks if it is within the range
        {
            Console.WriteLine("Please enter a valid choice between 1 and 4.");
            input = Console.ReadLine();
        }
        return choice - 1; //as the user will start from 1, but the actual value index starts from 0.
    }
}