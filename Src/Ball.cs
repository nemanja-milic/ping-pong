using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Src
{
    internal class Ball
    {
        private PictureBox BallPicture;
        public int SpeedByPxPerSeconds = 10;
        private int velocityX = +15;
        private int velocityY = +15;
        private Form MainForm;
        public Ball(PictureBox BallPic, Form MainForm) 
        {
            BallPicture = BallPic;
            this.MainForm = MainForm;
        }

        public void MovingController()
        {
            MoveHorizontally();

            MoveVertical();

            CheckCollision();

        }

        private void CheckCollision()
        {
            // up wall
            if(BallPicture.Top <= 0 && velocityY < 0)
            {
                velocityY = velocityY * -1;
                velocityX = velocityX * -1;
            }
            
            // down wall
            if(BallPicture.Bottom >= (MainForm.Height - BallPicture.Height) && velocityY > 0)
            {
                velocityY = velocityY * -1;
                velocityX = velocityX * -1;
            }
        }
        public void MoveVertical()
        {
            int newValueOfY = BallPicture.Location.Y + velocityY;
            BallPicture.Location = new Point(BallPicture.Location.X, newValueOfY);
        }

        public void MoveHorizontally()
        {
            int newValueOfX = BallPicture.Location.X + velocityX;
            BallPicture.Location = new Point(newValueOfX, BallPicture.Location.Y);
        }
    }
}
