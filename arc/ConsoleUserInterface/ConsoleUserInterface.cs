namespace arc.ConsoleUserInterface;

public class CLI
{
    public void WelcomeMessage()
    {
        Console.WriteLine("Welcome to the Arcade machine rehabilitation perform");
        SelectPrompt();
        WelcomeSelectOptions();
    }

    private static void WelcomeSelectOptions()
    {
        Console.WriteLine("reg : Register an Account");
        Console.WriteLine("snd : Sound Interface");
        Console.WriteLine("ply : Play a Game");
        Console.WriteLine("exit : Exit the App");
    }

    private static void SelectPrompt()
    {
        Console.WriteLine("Select an action :");
        Console.WriteLine();
    }

    public string ReadContent()
    {
        return Console.ReadLine();
    }

    public void PrintContent(string content)
    {
        Console.WriteLine(content);
    }
}