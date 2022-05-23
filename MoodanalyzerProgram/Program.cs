using MoodanalyzerProgram;

public class Program
{
    public static void Main(String[] args)
    {
        MoodAnalyze moodAnalyze = new MoodAnalyze();
        string inputString = moodAnalyze.CheckingMood("sad");
        Console.WriteLine("i am in " + inputString + "   mood");
    }
}