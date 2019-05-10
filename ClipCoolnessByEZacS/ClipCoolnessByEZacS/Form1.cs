using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClipCoolnessByEZacS
{
    public partial class Form : System.Windows.Forms.Form
    {

        public Form()
        {
            InitializeComponent();
            Score.instance = this;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {
            Score.Value = trackBar1.Value;
        }

        public void SetFinalScore(string value)
        {
            FinalScore.Text = value;
        }
    }

    public static class Score
    {
        public static Form instance;
        private static int _score;
        public static int Value {
            get => _score;
            set
            {
                _score = value;
                instance.SetFinalScore($"Score: {value}p");
            }
        }
    }
}
