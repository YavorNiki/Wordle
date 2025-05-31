using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    internal class Player
    {
        private string name;
        private int guesses;
        public Player() { }
        public Player(int id) { }

        public string Name { get => name; set => name = value; }
        public int Guesses { get => guesses; set => guesses = value; }
    }
}
