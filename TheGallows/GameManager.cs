class GameManager
{
    public static void PlayGame(string selectedWord)
    {
        List<string> listWordSymbol = Enumerable.Repeat("*", selectedWord.Length).ToList();
        int errorsCount = selectedWord.Length;

        Console.WriteLine($"Количество ошибок: {errorsCount}");

        while (listWordSymbol.Contains("*") && errorsCount > 0)
        {
            foreach (string symbol in listWordSymbol)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();

            Console.Write("\nВведите букву слова: ");
            char charWord = '\0';
            bool correctInput = false;
            bool guessedLetter = false;

            do
            {
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || input.Length != 1 || !char.TryParse(input, out charWord))
                {
                    Console.WriteLine("Пожалуйста, введите корректный символ.");
                    continue;
                }

                charWord = Char.ToLower(charWord);

                if (charWord == ' ')
                {
                    Console.WriteLine("Пожалуйста, введите корректный символ.");
                }
                else
                {
                    correctInput = true;
                }
            } while (!correctInput);

            for (int i = 0; i < selectedWord.Length; i++)
            {
                if (charWord == Char.ToLower(selectedWord[i]))
                {
                    listWordSymbol[i] = charWord.ToString();
                    Console.WriteLine($"Верно {charWord}\n");
                    guessedLetter = true;
                }
            }

            if (!guessedLetter) // Если буква не была угадана, уменьшаем количество ошибок
            {
                Console.WriteLine("Буква неправильная");
                errorsCount--;
                Console.WriteLine($"Количество ошибок: {errorsCount}");
            }
        }

        if (!listWordSymbol.Contains("*"))
        {
            Console.WriteLine("Вы угадали слово!");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Вы не угадали слово!");
            Console.WriteLine();
            Console.WriteLine($"Вот правильное слово --> {selectedWord} <--");
            Console.WriteLine();
        }
    }
}
