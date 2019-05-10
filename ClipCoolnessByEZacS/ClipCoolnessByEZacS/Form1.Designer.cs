namespace ClipCoolnessByEZacS
{
    partial class Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Kills = new System.Windows.Forms.TrackBar();
            this.FinalScore = new System.Windows.Forms.Label();
            this.HeadShots = new System.Windows.Forms.TrackBar();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NoScope = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.WallBang = new System.Windows.Forms.TrackBar();
            this.Collats = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ImpactKill = new System.Windows.Forms.CheckBox();
            this.LongDistance = new System.Windows.Forms.CheckBox();
            this.InspectWeapon = new System.Windows.Forms.CheckBox();
            this.CatchGun = new System.Windows.Forms.CheckBox();
            this.Bhops = new System.Windows.Forms.TrackBar();
            this.label8 = new System.Windows.Forms.Label();
            this.JumpBug = new System.Windows.Forms.CheckBox();
            this.Surf = new System.Windows.Forms.CheckBox();
            this.RunBoost = new System.Windows.Forms.CheckBox();
            this.MidAir = new System.Windows.Forms.CheckBox();
            this.Flick = new System.Windows.Forms.ComboBox();
            this.Strafe = new System.Windows.Forms.ComboBox();
            this.gamemode = new System.Windows.Forms.ComboBox();
            this.quality = new System.Windows.Forms.ComboBox();
            this.EnemyVoice = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Kills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadShots)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoScope)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallBang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Collats)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bhops)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "P logger by EZacS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "0 kills";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // Kills
            // 
            this.Kills.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Kills.LargeChange = 1;
            this.Kills.Location = new System.Drawing.Point(12, 91);
            this.Kills.Maximum = 5;
            this.Kills.Name = "Kills";
            this.Kills.Size = new System.Drawing.Size(104, 45);
            this.Kills.TabIndex = 2;
            this.Kills.Scroll += new System.EventHandler(this.TrackBar1_Scroll);
            // 
            // FinalScore
            // 
            this.FinalScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FinalScore.AutoSize = true;
            this.FinalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FinalScore.Location = new System.Drawing.Point(12, 410);
            this.FinalScore.Name = "FinalScore";
            this.FinalScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.FinalScore.Size = new System.Drawing.Size(130, 31);
            this.FinalScore.TabIndex = 3;
            this.FinalScore.Text = "Score: 0p";
            this.FinalScore.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.FinalScore.Click += new System.EventHandler(this.Label3_Click);
            // 
            // HeadShots
            // 
            this.HeadShots.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.HeadShots.LargeChange = 1;
            this.HeadShots.Location = new System.Drawing.Point(12, 169);
            this.HeadShots.Maximum = 5;
            this.HeadShots.Name = "HeadShots";
            this.HeadShots.Size = new System.Drawing.Size(104, 45);
            this.HeadShots.TabIndex = 4;
            this.HeadShots.Scroll += new System.EventHandler(this.HeadShots_Scroll);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "0 headshots";
            this.label3.Click += new System.EventHandler(this.Label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "0 no scopes";
            // 
            // NoScope
            // 
            this.NoScope.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.NoScope.LargeChange = 1;
            this.NoScope.Location = new System.Drawing.Point(255, 170);
            this.NoScope.Maximum = 5;
            this.NoScope.Name = "NoScope";
            this.NoScope.Size = new System.Drawing.Size(104, 45);
            this.NoScope.TabIndex = 6;
            this.NoScope.Scroll += new System.EventHandler(this.NoScope_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(132, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "0 wallbangs";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // WallBang
            // 
            this.WallBang.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.WallBang.LargeChange = 1;
            this.WallBang.Location = new System.Drawing.Point(137, 176);
            this.WallBang.Maximum = 3;
            this.WallBang.Name = "WallBang";
            this.WallBang.Size = new System.Drawing.Size(104, 45);
            this.WallBang.TabIndex = 8;
            this.WallBang.Scroll += new System.EventHandler(this.WallBang_Scroll);
            // 
            // Collats
            // 
            this.Collats.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Collats.LargeChange = 1;
            this.Collats.Location = new System.Drawing.Point(128, 91);
            this.Collats.Maximum = 2;
            this.Collats.Name = "Collats";
            this.Collats.Size = new System.Drawing.Size(104, 45);
            this.Collats.TabIndex = 11;
            this.Collats.Scroll += new System.EventHandler(this.Collats_Scroll);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(125, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "0 collats";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(251, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Flick";
            // 
            // ImpactKill
            // 
            this.ImpactKill.AutoSize = true;
            this.ImpactKill.Location = new System.Drawing.Point(18, 216);
            this.ImpactKill.Name = "ImpactKill";
            this.ImpactKill.Size = new System.Drawing.Size(123, 17);
            this.ImpactKill.TabIndex = 14;
            this.ImpactKill.Text = "Impact kill(grenades)";
            this.ImpactKill.UseVisualStyleBackColor = true;
            this.ImpactKill.CheckedChanged += new System.EventHandler(this.ImpactKill_CheckedChanged);
            // 
            // LongDistance
            // 
            this.LongDistance.AutoSize = true;
            this.LongDistance.Location = new System.Drawing.Point(18, 239);
            this.LongDistance.Name = "LongDistance";
            this.LongDistance.Size = new System.Drawing.Size(93, 17);
            this.LongDistance.TabIndex = 15;
            this.LongDistance.Text = "Long distance";
            this.LongDistance.UseVisualStyleBackColor = true;
            this.LongDistance.CheckedChanged += new System.EventHandler(this.LongDistance_CheckedChanged);
            // 
            // InspectWeapon
            // 
            this.InspectWeapon.AutoSize = true;
            this.InspectWeapon.Location = new System.Drawing.Point(18, 262);
            this.InspectWeapon.Name = "InspectWeapon";
            this.InspectWeapon.Size = new System.Drawing.Size(136, 17);
            this.InspectWeapon.TabIndex = 16;
            this.InspectWeapon.Text = "inspect before shooting";
            this.InspectWeapon.UseVisualStyleBackColor = true;
            this.InspectWeapon.CheckedChanged += new System.EventHandler(this.InspectWeapon_CheckedChanged);
            // 
            // CatchGun
            // 
            this.CatchGun.AutoSize = true;
            this.CatchGun.Location = new System.Drawing.Point(18, 285);
            this.CatchGun.Name = "CatchGun";
            this.CatchGun.Size = new System.Drawing.Size(97, 17);
            this.CatchGun.TabIndex = 17;
            this.CatchGun.Text = "catching a gun";
            this.CatchGun.UseVisualStyleBackColor = true;
            this.CatchGun.CheckedChanged += new System.EventHandler(this.CatchGun_CheckedChanged);
            // 
            // Bhops
            // 
            this.Bhops.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Bhops.LargeChange = 1;
            this.Bhops.Location = new System.Drawing.Point(252, 91);
            this.Bhops.Maximum = 6;
            this.Bhops.Name = "Bhops";
            this.Bhops.Size = new System.Drawing.Size(104, 45);
            this.Bhops.TabIndex = 19;
            this.Bhops.Scroll += new System.EventHandler(this.Bhops_Scroll);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 24);
            this.label8.TabIndex = 18;
            this.label8.Text = "0 bhops";
            this.label8.Click += new System.EventHandler(this.Label8_Click);
            // 
            // JumpBug
            // 
            this.JumpBug.AutoSize = true;
            this.JumpBug.Location = new System.Drawing.Point(442, 351);
            this.JumpBug.Name = "JumpBug";
            this.JumpBug.Size = new System.Drawing.Size(136, 17);
            this.JumpBug.TabIndex = 20;
            this.JumpBug.Text = "Jump bug/ surf of edge";
            this.JumpBug.UseVisualStyleBackColor = true;
            this.JumpBug.CheckedChanged += new System.EventHandler(this.JumpBug_CheckedChanged);
            // 
            // Surf
            // 
            this.Surf.AutoSize = true;
            this.Surf.Location = new System.Drawing.Point(442, 285);
            this.Surf.Name = "Surf";
            this.Surf.Size = new System.Drawing.Size(57, 17);
            this.Surf.TabIndex = 21;
            this.Surf.Text = "surfing";
            this.Surf.UseVisualStyleBackColor = true;
            this.Surf.CheckedChanged += new System.EventHandler(this.Surf_CheckedChanged);
            // 
            // RunBoost
            // 
            this.RunBoost.AutoSize = true;
            this.RunBoost.Location = new System.Drawing.Point(442, 305);
            this.RunBoost.Name = "RunBoost";
            this.RunBoost.Size = new System.Drawing.Size(70, 17);
            this.RunBoost.TabIndex = 22;
            this.RunBoost.Text = "run boost";
            this.RunBoost.UseVisualStyleBackColor = true;
            this.RunBoost.CheckedChanged += new System.EventHandler(this.RunBoost_CheckedChanged);
            // 
            // MidAir
            // 
            this.MidAir.AutoSize = true;
            this.MidAir.Location = new System.Drawing.Point(442, 328);
            this.MidAir.Name = "MidAir";
            this.MidAir.Size = new System.Drawing.Size(99, 17);
            this.MidAir.TabIndex = 23;
            this.MidAir.Text = "mid air/ running";
            this.MidAir.UseVisualStyleBackColor = true;
            this.MidAir.CheckedChanged += new System.EventHandler(this.MidAir_CheckedChanged);
            // 
            // Flick
            // 
            this.Flick.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Flick.FormattingEnabled = true;
            this.Flick.Items.AddRange(new object[] {
            "less than 30°(you\'re bad)",
            "30°",
            "90°",
            "180°"});
            this.Flick.Location = new System.Drawing.Point(255, 236);
            this.Flick.Name = "Flick";
            this.Flick.Size = new System.Drawing.Size(141, 21);
            this.Flick.TabIndex = 12;
            this.Flick.SelectedIndexChanged += new System.EventHandler(this.Flick_SelectedIndexChanged);
            // 
            // Strafe
            // 
            this.Strafe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Strafe.FormattingEnabled = true;
            this.Strafe.Items.AddRange(new object[] {
            "bad",
            "Cool strafes",
            "Even cooler stafes"});
            this.Strafe.Location = new System.Drawing.Point(647, 227);
            this.Strafe.Name = "Strafe";
            this.Strafe.Size = new System.Drawing.Size(141, 21);
            this.Strafe.TabIndex = 26;
            this.Strafe.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // gamemode
            // 
            this.gamemode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gamemode.FormattingEnabled = true;
            this.gamemode.Items.AddRange(new object[] {
            "Other",
            "Matchmaking",
            "Fpl",
            "Pro league"});
            this.gamemode.Location = new System.Drawing.Point(647, 169);
            this.gamemode.Name = "gamemode";
            this.gamemode.Size = new System.Drawing.Size(141, 21);
            this.gamemode.TabIndex = 27;
            this.gamemode.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // quality
            // 
            this.quality.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.quality.FormattingEnabled = true;
            this.quality.Items.AddRange(new object[] {
            "Shadowplay",
            "Demo",
            "Demo with motionblur"});
            this.quality.Location = new System.Drawing.Point(647, 115);
            this.quality.Name = "quality";
            this.quality.Size = new System.Drawing.Size(141, 21);
            this.quality.TabIndex = 28;
            this.quality.SelectedIndexChanged += new System.EventHandler(this.Quality_SelectedIndexChanged);
            // 
            // EnemyVoice
            // 
            this.EnemyVoice.AutoSize = true;
            this.EnemyVoice.Location = new System.Drawing.Point(442, 97);
            this.EnemyVoice.Name = "EnemyVoice";
            this.EnemyVoice.Size = new System.Drawing.Size(128, 17);
            this.EnemyVoice.TabIndex = 29;
            this.EnemyVoice.Text = "Enemy voice reaction";
            this.EnemyVoice.UseVisualStyleBackColor = true;
            this.EnemyVoice.CheckedChanged += new System.EventHandler(this.EnemyVoice_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(442, 120);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(111, 17);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Facecam reaction";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(442, 143);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(138, 17);
            this.checkBox2.TabIndex = 31;
            this.checkBox2.Text = "sneaking behind enemy";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.CheckBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(442, 166);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(128, 17);
            this.checkBox3.TabIndex = 32;
            this.checkBox3.Text = "being on enemy head";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.CheckBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(442, 189);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(124, 17);
            this.checkBox4.TabIndex = 33;
            this.checkBox4.Text = "confusing the enemy";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.CheckBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(442, 212);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(121, 17);
            this.checkBox5.TabIndex = 34;
            this.checkBox5.Text = "staring at the enemy";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.CheckBox5_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(746, 428);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Version";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(643, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 24);
            this.label10.TabIndex = 36;
            this.label10.Text = "Gamemode";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(643, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 24);
            this.label11.TabIndex = 37;
            this.label11.Text = "Quality";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(643, 200);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 24);
            this.label12.TabIndex = 38;
            this.label12.Text = "Cool strafes";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.EnemyVoice);
            this.Controls.Add(this.quality);
            this.Controls.Add(this.gamemode);
            this.Controls.Add(this.Strafe);
            this.Controls.Add(this.MidAir);
            this.Controls.Add(this.RunBoost);
            this.Controls.Add(this.Surf);
            this.Controls.Add(this.JumpBug);
            this.Controls.Add(this.Bhops);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CatchGun);
            this.Controls.Add(this.InspectWeapon);
            this.Controls.Add(this.LongDistance);
            this.Controls.Add(this.ImpactKill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Flick);
            this.Controls.Add(this.Collats);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.WallBang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.NoScope);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.HeadShots);
            this.Controls.Add(this.FinalScore);
            this.Controls.Add(this.Kills);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Form";
            this.Text = "P logger by EZacS";
            this.Load += new System.EventHandler(this.Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Kills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HeadShots)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoScope)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WallBang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Collats)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bhops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar Kills;
        private System.Windows.Forms.Label FinalScore;
        private System.Windows.Forms.TrackBar HeadShots;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar NoScope;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar WallBang;
        private System.Windows.Forms.TrackBar Collats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ImpactKill;
        private System.Windows.Forms.CheckBox LongDistance;
        private System.Windows.Forms.CheckBox InspectWeapon;
        private System.Windows.Forms.CheckBox CatchGun;
        private System.Windows.Forms.TrackBar Bhops;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox JumpBug;
        private System.Windows.Forms.CheckBox Surf;
        private System.Windows.Forms.CheckBox RunBoost;
        private System.Windows.Forms.CheckBox MidAir;
        private System.Windows.Forms.ComboBox Flick;
        private System.Windows.Forms.ComboBox Strafe;
        private System.Windows.Forms.ComboBox gamemode;
        private System.Windows.Forms.ComboBox quality;
        private System.Windows.Forms.CheckBox EnemyVoice;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}

