public class Scripture
{
    private Reference _reference;

    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] words = text.Split(' ');
        foreach (string word in words)
        {
            _words.Add(new Word(word));
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordNum = _words.Count;

        for (int i = 0; i < numberToHide; i++)
        {

            int randomWord;
            do
            {
                randomWord = random.Next(wordNum);

            } while (_words[randomWord].IsHidden());


            _words[randomWord].Hide();
        }
    }
    public string GetDisplayText()
    {
        List<string> displayWords = new List<string>();
        foreach (Word word in _words)
        {
            displayWords.Add(word.GetDisplayText());
        }
        return string.Join(" ", displayWords);
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden() != true)
            {
                return false;
            }
        }
        return true;
    }


}