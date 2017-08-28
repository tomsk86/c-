using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EatME
{
    class In_GameControl : BoardGame
    {
        private int playerPositionY = 2, playerPositionX = 1;
        Messages attention = new Messages();
        IntroduceYourself sign = new IntroduceYourself();

        public In_GameControl()
        {
            t[playerPositionX, playerPositionY] = sign.GetPawnPattern();
        }

        public int GetPlayerPositionY()
        {
            return playerPositionY;
        }
        public int GetPlayerPositionX()
        {
            return playerPositionX;
        }
        public Tuple<int, int> ResetPosition()
        {
            return Tuple.Create(playerPositionY = 1, playerPositionX = 2);
        }

        #region Directions
        public void Up()
        {
            if (GetBoard()[playerPositionY - 1, playerPositionX] == '█') attention.Attention();
            else playerPositionY--;
        }
        public void Down()
        {
            if (GetBoard()[playerPositionY + 1, playerPositionX] == '█') attention.Attention();
            else playerPositionY++;
        }
        public void Left()
        {
            if (GetBoard()[playerPositionY, playerPositionX - 1] == '█') attention.Attention();
            else playerPositionX--;            
        }
        public void Right()
        {
            if (GetBoard()[playerPositionY, playerPositionX + 1] == '█') attention.Attention();
            else playerPositionX++;
        }
        #endregion
    }
}
