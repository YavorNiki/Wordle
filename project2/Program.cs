namespace project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string location = "words.txt";
            string[] words = File.ReadAllLines(location);

            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].Trim().Substring(0, 5);
            }

            if (words.Length > 5756)
            {
                words[5756] = "chime";
            }

            View view = new View();

            bool playAgain = true;

            while (playAgain)
            {
                Gameplay gm = new Gameplay();
                gm.ChooseWord(words);
                List<string> pastGuesses = new List<string>();
                bool won = false;

                for (int j = 0; j < 6; j++)
                {
                    while (true)
                    {
                        Console.Clear();
                        view.Wordle();
                        view.WriteBoard(gm, pastGuesses);
                        view.DisplayKeyboard(gm);

                        string guess = view.Try(gm, words, pastGuesses);
                        if (guess != null)
                        {
                            gm.Comparer(guess);
                            pastGuesses.Add(guess);

                            if (guess == new string(gm.Choice))
                            {
                                Console.Clear();
                                view.Wordle();
                                view.WriteBoard(gm, pastGuesses);
                                view.DisplayKeyboard(gm);
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("\nYOU WIN!");
                                Console.ResetColor();
                                won = true;
                            }
                            break;
                        }
                    }

                    if (won)
                        break;
                }

                if (!won)
                {
                    Console.Clear();
                    view.Wordle();
                    view.WriteBoard(gm, pastGuesses);
                    view.DisplayKeyboard(gm);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nYOU LOSE! The word was: {new string(gm.Choice).ToUpper()}");
                    Console.ResetColor();
                }

                Console.Write("\nDo you want to play again? (y/n): ");
                string response = Console.ReadLine().Trim().ToLower();
                playAgain = response == "y";
            }
        }
    }
}
