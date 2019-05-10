using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ClipCoolnessByEZacS
{
    class ScoreSystem
    {

        public Dictionary<string, int> Values = new Dictionary<string, int>();
        public bool isHacked = false;
        private double score;
        public double Score
        {
            get
            {
                score = getFullScore();
                return score;
            }
            set
            {
                score = getFullScore();

            }
        }
        private protected Form instance;

        public ScoreSystem(Form instance)
        {
            this.instance = instance;
        }

        int getFullScore()
        {
            
            int tmp = 0;
            foreach (int value in Values.Values)
            {
                tmp += value;
            }
            return tmp;
        }

        public void updateScore()
        {
            Score = 0;
            setFinalScore();
        }

        void setFinalScore()
        {
            if (!isHacked)
                instance.SetFinalScore($"Score: {Score}p{(Score >= 8 && !isHacked ? ", Franzj-approved" : "")}");
            else
                instance.SetFinalScore($"Score: Hacker! ({Score}p)");

            if (Score >= 8 && !isHacked)
                instance.setFinalScoreColor(Color.Lime);
            else if (isHacked)
                instance.setFinalScoreColor(Color.Crimson);
            else
                instance.setFinalScoreColor(SystemColors.ControlText);
            
        }

    }
}
