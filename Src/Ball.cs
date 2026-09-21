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
        int ballSpeed = 30;
        int TicksBeforeIncreaseSpeed = 100;
        int CounterOfTicks = 0;
        public event Action<PlayerSide>? GoalScored;
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
            Console.WriteLine(ballSpeed);
            ShouldIncreaseBallSpeed();

            CheckCollision();

            MoveHorizontally();

            MoveVertical();

            CounterOfTicks++;
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

            if(BallPicture.Right > MainForm.Width)
            {
                GoalScored?.Invoke(PlayerSide.PlayerA);
            }

            if (BallPicture.Left < 0)
            {
                GoalScored?.Invoke(PlayerSide.PlayerB);
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

            if (PlayerA.HitHead(BallPicture.Top))
            {
                if (velocityY == 0)
                {
                    velocityY = ballSpeed;
                }
                Console.WriteLine("hit head");
                velocityX = Math.Abs(velocityX);
                velocityY = velocityY * -1;
            }

            if (PlayerA.HitCenter(BallPicture.Top))
            {
                Console.WriteLine("Hit center");
                velocityX = Math.Abs(velocityX);
                velocityY = 0;
                return;
            }

            if (PlayerA.HitTail(BallPicture.Top))
            {
                Console.WriteLine("hit tail");
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

            if (PlayerA.HitHead(BallPicture.Top))
            {
                if (velocityY == 0)
                {
                    velocityY = ballSpeed;
                }
                velocityX = Math.Abs(velocityX);
                velocityY = velocityY * -1;
                Console.WriteLine("Hit head");
            }

            if (PlayerB.HitCenter(BallPicture.Top))
            {
                Console.WriteLine("hit center");
                velocityX = -Math.Abs(velocityX);
                velocityY = 0;
            }

            if (PlayerB.HitTail(BallPicture.Top))
            {

                Console.WriteLine("Hit tail");
                if (velocityY == 0)
                {
                    velocityY = ballSpeed;
                }
                velocityY = Math.Abs(velocityY);
                velocityX = -Math.Abs(velocityX);
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

        public void ResetPosition()
        {
            BallPicture.Location = new Point(MainForm.ClientSize.Width / 2, MainForm.ClientSize.Height / 2);
        }

        private void ShouldIncreaseBallSpeed()
        {
            if(CounterOfTicks == TicksBeforeIncreaseSpeed)
            {
                IncreaseBallSpeed();
                CounterOfTicks = 0;
            }
        }

        private void IncreaseBallSpeed()
        {
            ballSpeed += 5;
        }
    }
}
