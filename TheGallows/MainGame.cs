class MainGame
{
    static void Main(string[] args)
    {
        List<string> selectedWordList = listRusWord.GetRandomWord();

        WordManager wordManager = new WordManager(selectedWordList);
        string selectedWord = wordManager.GetRandomWord();

        if (selectedWord != null)
        {
            GameManager.PlayGame(selectedWord);
        }
        Console.ReadKey();
    }

}