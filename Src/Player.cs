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

        private int SectionHeight = 0;

        public int MiddleEnd 
            {
                get
                {
                    
                    return (PicBox.Height / 3) * 2;
                }
            }

        public int MiddleStart
        {
            get
            {
                return PicBox.Height / 3;
            }
        }


        public Player(PictureBox picBox) 
        {
            PicBox = picBox;

            SectionHeight = PicBox.Height / 3;
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

        public bool HitTail(int ballCenterY)
        {
            int fromMiddleEndToTopForm = PicBox.Top + MiddleEnd;
            if(fromMiddleEndToTopForm <= ballCenterY && PicBox.Bottom > ballCenterY)
            {
                return true;
            }

            return false;
        }

        public bool HitCenter(int ballCenterY)
        {
            int fromMiddleEndToTopForm = PicBox.Top + MiddleEnd;
            int fromMiddleStartToTopForm = PicBox.Top + MiddleStart;
            if (ballCenterY >= fromMiddleStartToTopForm && fromMiddleEndToTopForm > ballCenterY)
            {
                return true;
            }

            return false;
        }

        public bool HitHead(int ballCenterY)
        {
            int fromMiddleStartToTopForm = PicBox.Top + MiddleStart;
            if (fromMiddleStartToTopForm > ballCenterY && PicBox.Top > ballCenterY)
            {
                return true;
            }

            return false;
        }

    }
}
