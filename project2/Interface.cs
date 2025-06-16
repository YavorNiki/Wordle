namespace project2
{
    class View
    {
        public View() { }
        //Black, DarkBlue, DarkGreen, DarkCyan, DarkRed, DarkMagenta, DarkYellow,
        //Gray, DarkGray, Blue, Green, Cyan, Red, Magenta, Yellow, White
        public void Wordle()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n          W O R D L E\n");
            Console.ResetColor();
        }

        public string Try(Gameplay gm, string[] listOfWords, List<string> pastGuesses)
        {
            while (true)
            {
                Console.Clear();
                Wordle();
                WriteBoard(gm, pastGuesses);
                DisplayKeyboard(gm);

                Console.Write("Make your guess: ");
                string guess = Console.ReadLine().ToLower();

                if (guess.Length != 5)
                {
                    Console.WriteLine("  Your guess must contain exactly 5 LETTERS.");
                    Console.WriteLine("  Press ENTER to try again...");
                    Console.ReadLine();
                    continue;
                }

                foreach (char c in guess)
                {
                    if (c < 'a' || c > 'z')
                    {
                        Console.WriteLine("  Only lowercase English letters are allowed.");
                        Console.WriteLine("  Press ENTER to try again...");
                        Console.ReadLine();
                        continue;
                    }
                }

                if (!listOfWords.Contains(guess))
                {
                    Console.WriteLine("  Not a real word.");
                    Console.WriteLine("  Press ENTER to try again...");
                    Console.ReadLine();
                    continue;
                }

                return guess;
            }
        }


        public void WriteBoard(Gameplay gm, List<string> guesses)
        {
            for (int row = 0; row < 6; row++)
            {
                Console.Write("          ");
                if (row < guesses.Count)
                {
                    string guess = guesses[row];
                    for (int i = 0; i < 5; i++)
                    {
                        char letter = guess[i];
                        if (gm.Choice[i] == letter)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else if (gm.Choice.Contains(letter))
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }

                        Console.Write($"|{char.ToUpper(letter)}|");
                        Console.ResetColor();
                    }
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("| |");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public void DisplayKeyboard(Gameplay gm)
        {
            string qwerty = "qwertyuiopasdfghjklzxcvbnm";

            Console.WriteLine("\n");
            foreach (char c in qwerty)
            {
                if (gm.GreenLetters.Contains(c))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (gm.YellowLetters.Contains(c))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (gm.GrayLetters.Contains(c))
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.Write($" {char.ToUpper(c)} ");
                Console.ResetColor();

                if (c == 'p' || c == 'l' || c == 'm')
                    Console.WriteLine();
            }
            Console.WriteLine("\n");
        }

    }
}
