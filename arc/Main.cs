namespace arc
{
    public class Arcade
    {
        
        private static ConsoleUserInterface.CLI _consoleUserInterface = new ConsoleUserInterface.CLI();
        /* Arcade machine prog
         Welcome
         Register
         Play ; Sound ; Profile ; Controllers 
         Exit
        */
        public static void Main()
        {
            _consoleUserInterface.WelcomeMessage();
            var myLine = _consoleUserInterface.ReadContent();
            _consoleUserInterface.PrintContent(myLine);
        }
    }
}
