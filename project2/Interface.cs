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
            Console.WriteLine("          W O R D L E"); // 10 space-a
            Console.ResetColor();
        }
        public string Try(Gameplay gm, string[] listOfWords)
        {
            Console.Write("Make your guess: ");

            while (true)
            {
                bool error = false;
                string guess = Console.ReadLine().ToLower();

                if (guess.Length != 5)
                {
                    Console.Write("  Your guess must contain only 5 LETTERS\nMake a valid guess: ");
                    continue;
                }

                foreach (char c in guess)
                {
                    if (c > 122 || c < 97)
                    {
                        Console.Write("  Your guess must contain only 5 LETTERS\nMake a valid guess: ");
                        error = true;
                        break;
                    }
                }

                if (!listOfWords.Contains(guess))
                {
                    Console.WriteLine("  Not a real word\nMake a valid guess: ");
                    continue;
                }

                if (error)
                    continue;

                return guess;
            }


        }
        public void WriteWord(Gameplay gm, string guess)
        {
            //gm.Comparer(guess, gm.Choice);

            //purva bukva
            #region
            if (guess[0] == gm.Choice[0])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"          |{char.ToUpper(guess[0])}| ");
                Console.ResetColor();

            }
            else if (guess[0] == guess[1] || guess[0] == guess[2] || guess[0] == guess[3] || guess[0] == guess[4])
            {
                Console.Write($"          |{char.ToUpper(guess[0])}| ");

            }
            else if (gm.Choice.Contains(guess[0]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"          |{char.ToUpper(guess[0])}| ");
                Console.ResetColor();

            }
            else
            {
                Console.Write($"          |{char.ToUpper(guess[0])}| ");
            }
            #endregion

            // vtora bukva
            #region
            if (guess[1] == gm.Choice[1])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"|{char.ToUpper(guess[1])}| ");
                Console.ResetColor();

            }
            else if (guess[1] == guess[2] || guess[1] == guess[3] || guess[1] == guess[4])
            {
                Console.Write($"|{char.ToUpper(guess[1])}| ");

            }
            else if (gm.Choice.Contains(guess[1]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"|{char.ToUpper(guess[1])}| ");
                Console.ResetColor();

            }
            else
            {
                Console.Write($"|{char.ToUpper(guess[1])}| ");
            }
            #endregion

            // treta bukva
            #region
            if (guess[2] == gm.Choice[2])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"|{char.ToUpper(guess[2])}| ");
                Console.ResetColor();

            }
            else if (guess[2] == guess[3] || guess[2] == guess[4])
            {
                Console.Write($"|{char.ToUpper(guess[2])}| ");

            }
            else if (gm.Choice.Contains(guess[2]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"|{char.ToUpper(guess[2])}| ");
                Console.ResetColor();

            }
            else
            {
                Console.Write($"|{char.ToUpper(guess[2])}| ");
            }
            #endregion

            // chetvurta bukva
            #region
            if (guess[3] == gm.Choice[3])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"|{char.ToUpper(guess[3])}| ");
                Console.ResetColor();

            }
            else if (guess[3] == guess[4])
            {
                Console.Write($"|{char.ToUpper(guess[3])}| ");

            }
            else if (gm.Choice.Contains(guess[3]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"|{char.ToUpper(guess[3])}| ");
                Console.ResetColor();

            }
            else
            {
                Console.Write($"|{char.ToUpper(guess[3])}| ");
            }
            #endregion

            // peta bukva
            #region
            if (guess[4] == gm.Choice[4])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write($"|{char.ToUpper(guess[4])}| ");
                Console.ResetColor();

            }
            else if (gm.Choice.Contains(guess[4]))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"|{char.ToUpper(guess[4])}| ");
                Console.ResetColor();

            }
            else
            {
                Console.Write($"|{char.ToUpper(guess[4])}| ");
            }
            #endregion
        }
    }
}
