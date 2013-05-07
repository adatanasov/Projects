namespace Minesweeper
{
    public class HighScore
    {
        private string name;
        private int score;

        public HighScore() 
        { 
        }

        public HighScore(string name, int score)
        {
            this.name = name;
            this.score = score;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Score
        {
            get { return this.score; }
            set { this.score = value; }
        }
    }
}
