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