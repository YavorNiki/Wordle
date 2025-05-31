namespace project2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //List s vsichki dumi s 5 bukvi
            // https://github.com/cheaderthecoder/5-Letter-words/blob/main/words.txt

            string location = "words.txt"; // smenih streamReader, zashtoto neshto ne stavashe da razpoznava dali dumata q ima i chatgpt mi predloji tova da izpolzvam
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
            view.Wordle();

            Gameplay gm = new Gameplay();
            gm.ChooseWord(words);
            for (int j = 0; j < 6; j++)
            {
                view.WriteWord(gm, view.Try(gm, words));
            }

            Console.WriteLine(gm.Choice);


        }
    }
}
