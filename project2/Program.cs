namespace project2
{
    internal class Program
    {

        static void Main(string[] args)
        {

            //List s vsichki dumi s 5 bukvi
            // https://github.com/cheaderthecoder/5-Letter-words/blob/main/words.txt

            string location = "C:\\Users\\User\\source\\repos\\project2\\project2\\bin\\words.txt";
            StreamReader sr = new StreamReader(location); //which pupal
            string txt = sr.ReadToEnd();
            string[] words = txt.Split('\n');
            int i = 0;
            words[5757] = "chime";
            foreach (string word in words)
            {
                    words[i] = word.Substring(0, 5);
            }
            View view = new View();
            view.Wordle();
            
            Gameplay gm = new Gameplay();
            gm.ChooseWord(words);
            view.WriteWord(gm, view.Try(gm));
            view.WriteWord(gm, view.Try(gm));
            view.WriteWord(gm, view.Try(gm));
            view.WriteWord(gm, view.Try(gm));
            view.WriteWord(gm, view.Try(gm));
            view.WriteWord(gm, view.Try(gm));
            Console.WriteLine(gm.Choice);


        }
    }
}
