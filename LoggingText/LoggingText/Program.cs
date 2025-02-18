namespace LoggingText;



class Program
{
    static void Main(string[] args)
    {
        //create folder and log text
        string directoryPath = @"/Users/khadijatulkobra/Desktop/:Logs";
        //string filePath = System.IO.Path.Combine(directoryPath, "log.txt");
        string filePath = Path.Combine(directoryPath, "log.txt");

        if (!Directory.Exists(directoryPath))
        {
            Directory.CreateDirectory(directoryPath);
        }
        File.AppendAllText(filePath, "Hello World!" + "\n");   
    }
}