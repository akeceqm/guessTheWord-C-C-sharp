class listRusWord
{
    public static List<string> GetRandomWord()
    {
        string directoryPath = "C:\\Users\\vladk\\source\\repos\\TheGallows\\TheGallows";
        return LoadWordsFromDirectory(directoryPath);
    }

    static List<string> LoadWordsFromDirectory(string directoryPath)
    {
        List<string> words = new List<string>();

        try
        {
            foreach (string filePath in Directory.GetFiles(directoryPath))
            {
                string[] lines = File.ReadAllLines(filePath);
                words.AddRange(lines);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка при чтении файлов: {ex.Message}");
        }

        return words;
    }
}