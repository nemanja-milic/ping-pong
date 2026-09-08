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
            pictureBox1 = new PictureBox();
            BallPic = new PictureBox();
            pictureBox4 = new PictureBox();
            UpdateGame = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BallPic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(11, 187);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 149);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            // pictureBox4
            // 
            pictureBox4.BackColor = SystemColors.ActiveCaption;
            pictureBox4.Location = new Point(1104, 187);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(35, 149);
            pictureBox4.TabIndex = 3;
            pictureBox4.TabStop = false;
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
            Controls.Add(pictureBox4);
            Controls.Add(BallPic);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "GameForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)BallPic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox BallPic;
        private PictureBox pictureBox4;
        private System.Windows.Forms.Timer UpdateGame;
    }
}
