using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nerdzee;

    public class ScoresForThrows
    {
        private string name;
        private int[] roll;
        public void setScoreAs(string name)
        {
            this.name = name;
        }

        public void setRoll(int[] roll)
        {
            this.roll = roll;
        }

        public int score()
        {
            var game = new Game();
            return game.Score(Rule.Create(name), roll);
        }
    }
