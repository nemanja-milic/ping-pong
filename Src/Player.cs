using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Src
{
    internal class Player
    {
        private PictureBox PlayerPicBox;
        public bool MovingUp { get; private set; } = false;
        public bool MovingDown { get; private set; } = false;

        private int Speed = 30;

        public Player(PictureBox picBox) 
        {
            PlayerPicBox = picBox;
        }

        public void MoveUp()
        {
            PlayerPicBox.Top = PlayerPicBox.Top - Speed;
        }

        public void MoveDown()
        {
            PlayerPicBox.Top = PlayerPicBox.Top + Speed;
        }

        public void StartMovingUp()
        {
            MovingUp = true;
        }

        public void StartMovingDown()
        {
            MovingDown = true;
        }

        public void StopMovingUp()
        {
            MovingUp = false;
        }

        public void StopMovingDown()
        {
            MovingDown = false;
        }
    }
}
