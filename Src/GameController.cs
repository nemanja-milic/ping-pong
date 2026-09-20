using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong.Src
{
    internal class GameController
    {
        public int PlayerAScore  { get; set; }
        public int PlayerBScore  { get; set; }
        public GameController()
        {
        }

        public void AddScoreGoalA()
        {
            PlayerAScore++;
        }

        public void AddScoreGoalB()
        {
            PlayerBScore++;
        }
    }
}
