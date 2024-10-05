public class Scripture
{
    private string _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference.GetDisplayText();
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int numberToHide)
    {

    }

    public string GetDisplayText()
    {
        return $"{_words}";
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }


}