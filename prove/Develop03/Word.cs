// Word.cs
public class Word
{
    private string wordText;
    private bool isHidden;

    public Word(string wordText)
    {
        this.wordText = wordText;
        this.isHidden = false;
    }

    public string GetWordText()
    {
        return isHidden ? "___" : wordText;
    }

    public void Hide()
    {
        isHidden = true;
    }

    public bool AllWordsHidden()
    {
        return isHidden;
    }
}
