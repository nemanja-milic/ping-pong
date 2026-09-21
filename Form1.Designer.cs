namespace Pong
{
    partial class GameForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBoxPlayerA = new PictureBox();
            BallPic = new PictureBox();
            pictureBoxPlayerB = new PictureBox();
            UpdateGame = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox7 = new PictureBox();
            PlayerAScoreLbl = new Label();
            PlayerBScoreLbl = new Label();
            GoalLbl = new Label();
            ReadyBtn = new Button();
            WinnerLbl = new Label();
            PlayAgainBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BallPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlayerA
            // 
            pictureBoxPlayerA.BackColor = SystemColors.ActiveCaption;
            pictureBoxPlayerA.Location = new Point(12, 189);
            pictureBoxPlayerA.Margin = new Padding(3, 2, 3, 2);
            pictureBoxPlayerA.Name = "pictureBoxPlayerA";
            pictureBoxPlayerA.Size = new Size(20, 120);
            pictureBoxPlayerA.TabIndex = 0;
            pictureBoxPlayerA.TabStop = false;
            // 
            // BallPic
            // 
            BallPic.Image = Properties.Resources.pong_ball_removebg_preview;
            BallPic.Location = new Point(483, 223);
            BallPic.Margin = new Padding(3, 2, 3, 2);
            BallPic.Name = "BallPic";
            BallPic.Size = new Size(25, 25);
            BallPic.SizeMode = PictureBoxSizeMode.StretchImage;
            BallPic.TabIndex = 2;
            BallPic.TabStop = false;
            // 
            // pictureBoxPlayerB
            // 
            pictureBoxPlayerB.BackColor = SystemColors.MenuHighlight;
            pictureBoxPlayerB.Location = new Point(923, 189);
            pictureBoxPlayerB.Margin = new Padding(3, 2, 3, 2);
            pictureBoxPlayerB.Name = "pictureBoxPlayerB";
            pictureBoxPlayerB.Size = new Size(20, 120);
            pictureBoxPlayerB.TabIndex = 3;
            pictureBoxPlayerB.TabStop = false;
            // 
            // UpdateGame
            // 
            UpdateGame.Enabled = true;
            UpdateGame.Tick += UpdateGameTick;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonFace;
            pictureBox1.Location = new Point(483, 9);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(21, 58);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonFace;
            pictureBox2.Location = new Point(483, 86);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(21, 58);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = SystemColors.ButtonFace;
            pictureBox3.Location = new Point(483, 160);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(21, 58);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ButtonFace;
            pictureBox4.Location = new Point(483, 259);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(21, 58);
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = SystemColors.ButtonFace;
            pictureBox5.Location = new Point(483, 336);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(21, 58);
            pictureBox5.TabIndex = 8;
            pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = SystemColors.ButtonFace;
            pictureBox6.Location = new Point(483, 412);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(21, 58);
            pictureBox6.TabIndex = 9;
            pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = SystemColors.ButtonFace;
            pictureBox7.Location = new Point(483, 494);
            pictureBox7.Margin = new Padding(3, 2, 3, 2);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(21, 58);
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // PlayerAScoreLbl
            // 
            PlayerAScoreLbl.AutoSize = true;
            PlayerAScoreLbl.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerAScoreLbl.ForeColor = SystemColors.ActiveCaption;
            PlayerAScoreLbl.Location = new Point(408, 26);
            PlayerAScoreLbl.Name = "PlayerAScoreLbl";
            PlayerAScoreLbl.Size = new Size(31, 32);
            PlayerAScoreLbl.TabIndex = 11;
            PlayerAScoreLbl.Text = "0";
            // 
            // PlayerBScoreLbl
            // 
            PlayerBScoreLbl.AutoSize = true;
            PlayerBScoreLbl.Font = new Font("Stencil", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PlayerBScoreLbl.ForeColor = SystemColors.MenuHighlight;
            PlayerBScoreLbl.Location = new Point(544, 26);
            PlayerBScoreLbl.Name = "PlayerBScoreLbl";
            PlayerBScoreLbl.Size = new Size(31, 32);
            PlayerBScoreLbl.TabIndex = 12;
            PlayerBScoreLbl.Text = "0";
            // 
            // GoalLbl
            // 
            GoalLbl.AutoSize = true;
            GoalLbl.Font = new Font("Stencil", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            GoalLbl.ForeColor = SystemColors.ControlLightLight;
            GoalLbl.Location = new Point(408, 220);
            GoalLbl.Name = "GoalLbl";
            GoalLbl.Size = new Size(192, 42);
            GoalLbl.TabIndex = 13;
            GoalLbl.Text = "GOOOAL!!!";
            GoalLbl.Visible = false;
            // 
            // ReadyBtn
            // 
            ReadyBtn.BackColor = SystemColors.Menu;
            ReadyBtn.Location = new Point(445, 268);
            ReadyBtn.Margin = new Padding(3, 2, 3, 2);
            ReadyBtn.Name = "ReadyBtn";
            ReadyBtn.Size = new Size(105, 30);
            ReadyBtn.TabIndex = 14;
            ReadyBtn.Text = "Ready";
            ReadyBtn.UseVisualStyleBackColor = false;
            ReadyBtn.Visible = false;
            ReadyBtn.Click += StartAgainGame;
            // 
            // WinnerLbl
            // 
            WinnerLbl.AutoSize = true;
            WinnerLbl.Font = new Font("Stencil", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WinnerLbl.ForeColor = Color.ForestGreen;
            WinnerLbl.Location = new Point(418, 238);
            WinnerLbl.Name = "WinnerLbl";
            WinnerLbl.Size = new Size(159, 46);
            WinnerLbl.TabIndex = 15;
            WinnerLbl.Text = "label1";
            WinnerLbl.Visible = false;
            // 
            // PlayAgainBtn
            // 
            PlayAgainBtn.BackColor = Color.DarkSeaGreen;
            PlayAgainBtn.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PlayAgainBtn.Location = new Point(445, 287);
            PlayAgainBtn.Margin = new Padding(3, 2, 3, 2);
            PlayAgainBtn.Name = "PlayAgainBtn";
            PlayAgainBtn.Size = new Size(105, 30);
            PlayAgainBtn.TabIndex = 16;
            PlayAgainBtn.Text = "Play again";
            PlayAgainBtn.UseVisualStyleBackColor = false;
            PlayAgainBtn.Visible = false;
            PlayAgainBtn.Click += RestartGame;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(984, 561);
            Controls.Add(PlayAgainBtn);
            Controls.Add(WinnerLbl);
            Controls.Add(ReadyBtn);
            Controls.Add(GoalLbl);
            Controls.Add(PlayerBScoreLbl);
            Controls.Add(PlayerAScoreLbl);
            Controls.Add(pictureBox7);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBoxPlayerB);
            Controls.Add(BallPic);
            Controls.Add(pictureBoxPlayerA);
            ForeColor = SystemColors.ActiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "GameForm";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += MovePlayers;
            KeyUp += ResetPlayerMovings;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerA).EndInit();
            ((System.ComponentModel.ISupportInitialize)BallPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerB).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxPlayerA;
        private PictureBox BallPic;
        private PictureBox pictureBoxPlayerB;
        private System.Windows.Forms.Timer UpdateGame;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private Label PlayerAScoreLbl;
        private Label PlayerBScoreLbl;
        private Label GoalLbl;
        private Button ReadyBtn;
        private Label WinnerLbl;
        private Button PlayAgainBtn;
    }
}
