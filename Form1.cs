using Pong.Src;

namespace Pong
{
    public partial class GameForm : Form
    {
        private Ball BallController;
        private Player PlayerA;
        private Player PlayerB;
        private GameController GameController;

        public GameForm()
        {
            KeyPreview = true;
            InitializeComponent();

            PlayerA = new Player(pictureBoxPlayerA);
            PlayerB = new Player(pictureBoxPlayerB);

            GameController = new GameController();

            BallController = new Ball(BallPic, this, PlayerA, PlayerB);
            BallController.GoalScored += HandleGoal;
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
            else if (PlayerA.MovingDown)
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

            if (e.KeyCode == Keys.Up && PlayerA.CanGoUp(this))
            {
                PlayerA.MoveUp();
            }

            if (e.KeyCode == Keys.Down && PlayerA.CanGoDown(this))
            {
                PlayerA.MoveDown();
            }

            if (e.KeyCode == Keys.W && PlayerB.CanGoUp(this))
            {
                PlayerB.MoveUp();
            }

            if (e.KeyCode == Keys.S && PlayerB.CanGoUp(this))
            {
                PlayerB.MoveDown();
            }

        }

        private void ResetPlayerMovings(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
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

        private void HandleGoal(PlayerSide playerSide)
        {
            if (playerSide == PlayerSide.PlayerA)
            {
                GameController.AddScoreGoalA();
                PlayerAScoreLbl.Text = GameController.PlayerAScore.ToString();
            }
            else if (playerSide == PlayerSide.PlayerB)
            {
                GameController.AddScoreGoalB();
                PlayerBScoreLbl.Text = GameController.PlayerBScore.ToString();
            }
            UpdateGame.Stop();
            if (GameController.IsWin())
            {
                PlayAgainBtn.Visible = true;
                WinnerLbl.Text = GameController.WinnerIs();
                WinnerLbl.Location = new Point((this.ClientSize.Width / 2) - (WinnerLbl.Width / 2), (this.ClientSize.Height / 2) - WinnerLbl.Height);
                WinnerLbl.Visible = true;
            }
            else
            {
                GoalLbl.Visible = true;
                ReadyBtn.Visible = true;
            }
        }

        private void StartAgainGame(object sender, EventArgs e)
        {
            BallController.ResetPosition();
            GoalLbl.Visible = false;
            ReadyBtn.Visible = false;
            UpdateGame.Start();
        }

        private void RestartGame(object sender, EventArgs e)
        {
            PlayAgainBtn.Visible = false;
            WinnerLbl.Visible = false;
            GameController.Reset();
            PlayerAScoreLbl.Text = "0";
            PlayerBScoreLbl.Text = "0";
            BallController.ResetPosition();
            UpdateGame.Start();
        }
    }
}
