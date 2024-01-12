class WordManager
{
    private List<string> selectedWordList;

    public WordManager(List<string> wordList)
    {
        selectedWordList = wordList;
    }

    public string GetRandomWord()
    {
        if (selectedWordList.Count > 0)
        {
            Random random = new ();
            int randomIndex = random.Next(0, selectedWordList.Count);
            return selectedWordList[randomIndex];
        }
        else
        {
            return null;
        }
    }
}

