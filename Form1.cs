using Pong.Src;

namespace Pong
{
    public partial class GameForm : Form
    {
        private Ball BallController;
        public GameForm()
        {
            InitializeComponent();
            BallController = new Ball(BallPic, this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void UpdateGameTick(object sender, EventArgs e)
        {
            BallController.MovingController();
        }
    }
}
