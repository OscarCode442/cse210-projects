

//the program works with a library of scriptures, and a random scripture is selected each time the user wants to practice.
using System;

class Program
{
    static void Main()
    {
        var scriptureLibrary = new ScriptureLibrary();
        var scriptureMemorizer = new ScriptureMemorizer(scriptureLibrary);

        while (!scriptureMemorizer.AllWordsHidden)
        {
            Console.WriteLine(scriptureMemorizer.GetHiddenText());
            Console.WriteLine("Press Enter to continue or type 'quit' to end:");

            string userInput = Console.ReadLine();
            if (userInput.ToLower() == "quit")
                break;

            scriptureMemorizer.HideRandomWords();
            Console.Clear();
        }
    }
}
