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
        private int velocityX = 0;
        private int velocityY = 0;
        private Form MainForm;
        private Player PlayerA;
        private Player PlayerB;
        int ballSpeed = 15;
        public Ball(PictureBox BallPic, Form MainForm, Player PlayerA, Player PlayerB) 
        {
            BallPicture = BallPic;
            this.MainForm = MainForm;
            this.PlayerB = PlayerB;
            this.PlayerA = PlayerA;

            velocityY = -ballSpeed;
            velocityX = -ballSpeed;

        }

        public void MovingController()
        {
            CheckCollision();

            MoveHorizontally();

            MoveVertical();

        }

        private void CheckCollision()
        {
            if(velocityY != 0 && velocityX != 0 && BallPicture.Top <= 0)
            {
                UpWallCollision();
            }
            if (velocityY != 0 && velocityX != 0 && BallPicture.Bottom >= (MainForm.Height - BallPicture.Height)) // adjusting for bettr bouncing of the wall
            {
                DownWallCollision();
            }
            if (BallPicture.Bounds.IntersectsWith(PlayerA.PicBox.Bounds))
            {
                PlayerACollision();
            }
            if(BallPicture.Bounds.IntersectsWith(PlayerB.PicBox.Bounds))
            {
                PlayerBCollision();
            }
        }

        private void UpWallCollision()
        {
            if (velocityX < 0 && velocityY < 0)
            {
                velocityY = velocityY * -1;
                return;
            }

            if (velocityX > 0 && velocityY < 0)
            {
                velocityY = velocityY * -1;
                return;
            }
        }
        private void DownWallCollision()
        {
            if(velocityX > 0 && velocityY > 0)
            {
                velocityY = velocityY * -1;
                return;
            }

            if(velocityX < 0 && velocityY > 0)
            {
                velocityY = velocityY * -1;
                return;
            }
        }

        private void PlayerACollision()
        {
            if (PlayerA.HitCenter(BallPicture.Top))
            {
                velocityX = velocityX * -1;
                velocityY = 0;
                return;
            }

            if(PlayerA.HitHead(BallPicture.Top))
            {
                velocityX = Math.Abs(velocityX);
                velocityY = velocityY * -1;
            }


            if (PlayerA.HitTail(BallPicture.Top))
            {
                if (velocityY == 0)
                {
                    velocityY = ballSpeed;
                }
                velocityY = Math.Abs(velocityY);
                velocityX = Math.Abs(velocityX);
                return;
            }

        }

        private void PlayerBCollision()
        {
            if (PlayerB.HitTail(BallPicture.Top))
            {
                if (velocityY == 0)
                {
                    velocityY = ballSpeed;
                }
                velocityY = velocityY * -1;
                velocityX = velocityX * -1;
            }

            if (PlayerB.HitCenter(BallPicture.Top))
            {
                velocityX = velocityX * -1;
                velocityY = 0;
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
