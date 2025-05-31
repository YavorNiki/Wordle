namespace project2
{
    class Gameplay
    {
        private Player player;
        private List<char> yellowLetters;
        private List<char> greenLetters;
        private char[] choice;
        public Gameplay() { }

        public List<char> YellowLetters { get => yellowLetters; set => yellowLetters = value; }
        public List<char> GreenLetters { get => greenLetters; set => greenLetters = value; }
        public Player Player { get => player; set => player = value; }
        public char[] Choice { get => choice; set => choice = value; }

        public void ChooseWord(string[] words)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, 5757);
            string chosenWord = words[randomNumber];
            this.choice = chosenWord.ToCharArray();
        }
        public void Comparer(string word, char[] letters) //ne bachka
        {
            for (int i = 0; i < 5; i++)
            {
                if (word[i] == letters[i])
                {
                    this.greenLetters.Add(letters[i]);
                }
                else if (letters.Contains(word[i]) && word[i] != letters[i])
                {
                    this.yellowLetters.Add(letters[i]);
                }
            }
        }

    }
}
