using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Src
{
    internal class Player
    {
        public PictureBox PicBox;
        public bool MovingUp { get; private set; } = false;
        public bool MovingDown { get; private set; } = false;

        private int Speed = 30;

        private int SpaceFromForm = 40;

        public Player(PictureBox picBox) 
        {
            PicBox = picBox;
        }

        public void MoveUp()
        {
            PicBox.Top = PicBox.Top - Speed;
        }

        public void MoveDown()
        {
            PicBox.Top = PicBox.Top + Speed;
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

        public bool CanGoUp(Form form)
        {
            if(PicBox.Top <= SpaceFromForm)
            {
                return false;
            }
            return true;
        }

        public bool CanGoDown(Form form)
        {
            if (PicBox.Bottom >= form.ClientSize.Height - SpaceFromForm)
            {
                return false;
            }
            return true;
        }

    }
}
