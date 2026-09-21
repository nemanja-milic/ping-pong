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

        private int WinScore = 5;
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

        public void Reset()
        {
            PlayerAScore = 0;
            PlayerBScore = 0;
        }

        public bool IsWin()
        {
            if(PlayerAScore == WinScore) return true;
            if (PlayerBScore == WinScore) return true;
            return false;
        }

        public string WinnerIs()
        {
            if (PlayerAScore == WinScore) return "Player A Winner";
            if (PlayerBScore == WinScore) return "Player B Winner!";
            return "No winner for now😀";
        }
    }
}
