using System.Net.Mime;

namespace LoggingText;

public interface Ilogger
{
    void Log(string message);
}

//writes in the file inside folder /Logs
/*
public class FileLogger : Ilogger
{
    public void Log(string message)
    {
        //create folder and log text
        string directoryPath = @"/Users/khadijatulkobra/Desktop/:Logs";
        //string filePath = System.IO.Path.Combine(directoryPath, "log.txt");
        
        string filePath = Path.Combine(directoryPath, "log.txt");

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        File.AppendAllText(filePath, message + "\n");   
    }
}
*/

public class Database : Ilogger
{
    public void Log(string message)
    {
        Console.WriteLine(message);
    }
}

public class Application
{
    private readonly Ilogger _logger;

    public Application(Ilogger logger)
    {
        _logger = logger;
    }

    public void Display()
    {
        _logger.Log("Application starting");
    }
    
}
class Program
{
    static void Main(string[] args)
    {
        //output in file
        Ilogger fileservice = new FileLogger();
        Application application = new Application(fileservice);
        application.Display();
        
        //output in console
        Ilogger database = new Database();
        application = new Application(database); //same object taking new classes
        application.Display();
    }
}

//Decoupling: the Application class depends on the Ilogger interface rather than
//specific implementations like FileLogger or DatabaseLogger