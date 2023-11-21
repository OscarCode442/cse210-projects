// ScriptureLibrary.cs
using System;
using System.Collections.Generic;
using System.Linq;

public class ScriptureLibrary
{
    private List<Scripture> scriptures;

    public ScriptureLibrary()
    {
        // Add your scriptures to the library
        scriptures = new List<Scripture>
        {
            new Scripture("John 3:16", "For God so loved the world..."),
            new Scripture("Proverbs 3:5-6", "Trust in the Lord with all your heart..."),
            // Add more scriptures as needed
        };
    }

    public Scripture GetRandomScripture()
    {
        var random = new Random();
        return scriptures[random.Next(0, scriptures.Count)];
    }
}
