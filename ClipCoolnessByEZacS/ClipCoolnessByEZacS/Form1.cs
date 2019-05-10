using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Totally fantastic code! :D
namespace ClipCoolnessByEZacS
{
    public partial class Form : System.Windows.Forms.Form
    {
        public const string version = "v1.0.1-b1";
        ScoreSystem scoreSystem;
        public Form()
        {
            InitializeComponent();
            scoreSystem = new ScoreSystem(this);
            label9.Text = version;
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void TrackBar1_Scroll(object sender, EventArgs e) // kills
        {
            scoreSystem.Values["kills"] = Kills.Value;
            scoreSystem.updateScore();
            label2.Text = $"{Kills.Value} kill{(Kills.Value == 1 ? "" : "s")}";
        }

        public void SetFinalScore(string value)
        {
            FinalScore.Text = value;
        }

        public void setFinalScoreColor(Color color)
        {
            FinalScore.ForeColor = color;
        }

        private void Form_Load(object sender, EventArgs e)
        {
            
        }

        private void Label3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void CheckBox9_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        // HEHEHH
        private void HeadShots_Scroll(object sender, EventArgs e)
        {
            scoreSystem.Values["headshots"] = HeadShots.Value;
            scoreSystem.updateScore();
            label3.Text = $"{HeadShots.Value} headshot{(HeadShots.Value == 1 ? "" : "s")}";
        }

        private void NoScope_Scroll(object sender, EventArgs e)
        {
            scoreSystem.Values["noscopes"] = NoScope.Value;
            scoreSystem.updateScore();
            label4.Text = $"{NoScope.Value} no scope{(NoScope.Value == 1 ? "" : "s")}";
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            label5.Text = "Alve was here";
        }

        private void WallBang_Scroll(object sender, EventArgs e)
        {
            scoreSystem.Values["wallbangs"] = WallBang.Value;
            scoreSystem.updateScore();
            label5.Text = $"{WallBang.Value} wallbang{(WallBang.Value == 1 ? "" : "s")}";
        }

        private void Collats_Scroll(object sender, EventArgs e)
        {
            scoreSystem.Values["collats"] = Collats.Value;
            scoreSystem.updateScore();
            label6.Text = $"{Collats.Value} collat{(Collats.Value == 1 ? "" : "s")}";
        }

        private void Flick_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["Flick"] = Flick.SelectedIndex;
            scoreSystem.updateScore();
        }

        private void ImpactKill_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["ImpactKill"] = ImpactKill.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void LongDistance_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["longdistance"] = LongDistance.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void InspectWeapon_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["InspectWeapon"] = InspectWeapon.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void CatchGun_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["catchGun"] = CatchGun.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void JumpBug_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["JumpBug"] = JumpBug.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void Surf_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["Surf"] = Surf.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        // Stop reading ples tankss
        private void RunBoost_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["RunBoost"] = RunBoost.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void MidAir_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["MidAir"] = MidAir.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void Bhops_Scroll(object sender, EventArgs e)
        {
            scoreSystem.Values["bhops"] = Bhops.Value;
            if (Bhops.Value != 6)
            {
                scoreSystem.isHacked = false;
            }
            else
                scoreSystem.isHacked = true;
            scoreSystem.updateScore();
            label8.Text = $"{Bhops.Value} bhop{(Bhops.Value == 1 ? "" : "s")}";
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e) // strafe
        {
            scoreSystem.Values["comboBox1"] = Strafe.SelectedIndex;
            scoreSystem.updateScore();
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e) // gamemode
        {
            scoreSystem.Values["gamemode"] = gamemode.SelectedIndex;
            scoreSystem.updateScore();
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["CheckBox5"] = checkBox5.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["CheckBox4"] = checkBox4.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["CheckBox3"] = checkBox3.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["CheckBox2"] = checkBox2.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["CheckBox1"] = checkBox1.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void EnemyVoice_CheckedChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["EnemyVoice"] = EnemyVoice.Checked ? 1 : 0;
            scoreSystem.updateScore();
        }

        private void Quality_SelectedIndexChanged(object sender, EventArgs e)
        {
            scoreSystem.Values["Quality"] = quality.SelectedIndex;
            scoreSystem.updateScore();
        }

        private void Label8_Click(object sender, EventArgs e)
        {
            
        }
    }
}
