// Added the ability to only remove the words that have not already been selected from before with a do while loop to make
// sure that the program selects multiple choices for the letters in the sections and allows it to properly display the
// outlay.



public class Word
{
    private string _text;
    private string _hiddenText;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
        char[] hiddenChars = new char[_text.Length];
        for (int i = 0; i < _text.Length; i++)
        {
            hiddenChars[i] = '_';
        }
        _hiddenText = new string(hiddenChars);
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return _isHidden ? "____" : _text;
    }
}