namespace project2
{
    class Gameplay
    {
        private Player player;
        private List<char> yellowLetters;
        private List<char> greenLetters;
        private char[] choice;
        private List<char> grayLetters = new List<char>();
        public Gameplay()
        {
            this.greenLetters = new List<char>();
            this.yellowLetters = new List<char>();
            this.player = new Player();
        }

        public List<char> YellowLetters { get => yellowLetters; set => yellowLetters = value; }
        public List<char> GreenLetters { get => greenLetters; set => greenLetters = value; }
        public List<char> GrayLetters { get => grayLetters; set => grayLetters = value; }
        public Player Player { get => player; set => player = value; }
        public char[] Choice { get => choice; set => choice = value; }

        public void ChooseWord(string[] words)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 5757);
            string chosenWord = words[randomNumber];
            this.choice = chosenWord.ToCharArray();
        }


        public void Comparer(string guess)
        {
            for (int i = 0; i < 5; i++)
            {
                if (guess[i] == choice[i])
                {
                    if (!greenLetters.Contains(guess[i]))
                        greenLetters.Add(guess[i]);
                }
                else if (choice.Contains(guess[i]))
                {
                    if (!yellowLetters.Contains(guess[i]) && !greenLetters.Contains(guess[i]))
                        yellowLetters.Add(guess[i]);
                }
                else
                {
                    if (!grayLetters.Contains(guess[i]) && !greenLetters.Contains(guess[i]) && !yellowLetters.Contains(guess[i]))
                        grayLetters.Add(guess[i]);
                }
            }
        }


    }
}
