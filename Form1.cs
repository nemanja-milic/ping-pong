using Pong.Src;

namespace Pong
{
    public partial class GameForm : Form
    {
        private Ball BallController;
        private Player PlayerA;
        private Player PlayerB;

        public GameForm()
        {
            InitializeComponent();
            BallController = new Ball(BallPic, this);

            PlayerA = new Player(pictureBoxPlayerA);
            PlayerB = new Player(pictureBoxPlayerB);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateGameTick(object sender, EventArgs e)
        {
            BallController.MovingController();

            if (PlayerA.MovingUp) 
            {
                PlayerA.MoveUp();
            }
            else if(PlayerA.MovingDown)
            {
                PlayerA.MoveDown();
            }

            if (PlayerB.MovingUp)
            {
                PlayerB.MoveUp();
            }
            else if (PlayerB.MovingDown)
            {
                PlayerB.MoveDown();
            }

        }

        private void MovePlayers(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                PlayerA.MoveUp();
            }

            if (e.KeyCode == Keys.Down)
            {
                PlayerA.MoveDown();
            }

            if (e.KeyCode == Keys.W)
            {
                PlayerB.MoveUp();
            }

            if (e.KeyCode == Keys.S)
            {
                PlayerB.MoveDown();
            }

        }

        private void ResetPlayerMovings(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                PlayerA.StopMovingUp();
            }

            if (e.KeyCode == Keys.Down)
            {
                PlayerA.StopMovingDown();
            }

            if (e.KeyCode == Keys.W)
            {
                PlayerB.StopMovingUp();
            }

            if (e.KeyCode == Keys.S)
            {
                PlayerB.StopMovingDown();
            }
        }
    }
}
