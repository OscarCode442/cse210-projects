// Scripture.cs
using System;

public class Scripture
{
    private string reference;
    private string text;

    public Scripture(string reference, string text)
    {
        this.reference = reference;
        this.text = text;
    }

    public string GetReference()
    {
        return reference;
    }

    public string GetText()
    {
        return text;
    }

    public int GetWordCount()
    {
        return text.Split(' ').Length;
    }
}
