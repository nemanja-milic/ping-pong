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
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BallPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerB).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPlayerA
            // 
            pictureBoxPlayerA.BackColor = SystemColors.ActiveCaption;
            pictureBoxPlayerA.Location = new Point(11, 187);
            pictureBoxPlayerA.Name = "pictureBoxPlayerA";
            pictureBoxPlayerA.Size = new Size(35, 149);
            pictureBoxPlayerA.TabIndex = 0;
            pictureBoxPlayerA.TabStop = false;
            // 
            // BallPic
            // 
            BallPic.Image = Properties.Resources.pong_ball_removebg_preview;
            BallPic.Location = new Point(560, 221);
            BallPic.Name = "BallPic";
            BallPic.Size = new Size(72, 63);
            BallPic.SizeMode = PictureBoxSizeMode.StretchImage;
            BallPic.TabIndex = 2;
            BallPic.TabStop = false;
            // 
            // pictureBoxPlayerB
            // 
            pictureBoxPlayerB.BackColor = SystemColors.ActiveCaption;
            pictureBoxPlayerB.Location = new Point(1104, 187);
            pictureBoxPlayerB.Name = "pictureBoxPlayerB";
            pictureBoxPlayerB.Size = new Size(35, 149);
            pictureBoxPlayerB.TabIndex = 3;
            pictureBoxPlayerB.TabStop = false;
            // 
            // UpdateGame
            // 
            UpdateGame.Enabled = true;
            UpdateGame.Tick += UpdateGameTick;
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1151, 611);
            Controls.Add(pictureBoxPlayerB);
            Controls.Add(BallPic);
            Controls.Add(pictureBoxPlayerA);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameForm";
            Text = "Form1";
            Load += Form1_Load;
            KeyDown += MovePlayers;
            KeyUp += ResetPlayerMovings;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerA).EndInit();
            ((System.ComponentModel.ISupportInitialize)BallPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayerB).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBoxPlayerA;
        private PictureBox BallPic;
        private PictureBox pictureBoxPlayerB;
        private System.Windows.Forms.Timer UpdateGame;
    }
}
