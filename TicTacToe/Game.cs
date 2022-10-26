using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Game
    {
        List<int> Combo = new List<int>();
       

        public string selectGame(string x)
        {
            string game = "";

            if (x == "3x3") game = "Game3x3";
            else if (x == "4x4") game = "Game4x4";
            else if (x == "5x5") game = "Game5x5";

            return game;
        }

        public bool checkForWin(List<int> Combo)
        {
            bool victory = false;
            //3x3
            if (Combo.Contains(1) && Combo.Contains(2) && Combo.Contains(3)) victory = true;
            else if (Combo.Contains(4) && Combo.Contains(5) && Combo.Contains(6)) victory = true;
            else if (Combo.Contains(7) && Combo.Contains(8) && Combo.Contains(9)) victory = true;
            else if (Combo.Contains(1) && Combo.Contains(5) && Combo.Contains(9)) victory = true;
            else if (Combo.Contains(1) && Combo.Contains(4) && Combo.Contains(7)) victory = true;
            else if (Combo.Contains(2) && Combo.Contains(5) && Combo.Contains(8)) victory = true;
            else if (Combo.Contains(3) && Combo.Contains(6) && Combo.Contains(9)) victory = true;
            else if (Combo.Contains(3) && Combo.Contains(5) && Combo.Contains(7)) victory = true;
            //4x4
            else if (Combo.Contains(5) && Combo.Contains(9) && Combo.Contains(16)) victory = true;
            else if (Combo.Contains(2) && Combo.Contains(6) && Combo.Contains(12)) victory = true;
            else if (Combo.Contains(4) && Combo.Contains(8) && Combo.Contains(15)) victory = true;
            else if (Combo.Contains(2) && Combo.Contains(3) && Combo.Contains(10)) victory = true;
            else if (Combo.Contains(5) && Combo.Contains(6) && Combo.Contains(11)) victory = true;
            else if (Combo.Contains(8) && Combo.Contains(9) && Combo.Contains(12)) victory = true;
            else if (Combo.Contains(14) && Combo.Contains(15) && Combo.Contains(16)) victory = true;
            else if (Combo.Contains(4) && Combo.Contains(7) && Combo.Contains(13)) victory = true;
            else if (Combo.Contains(5) && Combo.Contains(8) && Combo.Contains(14)) victory = true;
            else if (Combo.Contains(6) && Combo.Contains(9) && Combo.Contains(15)) victory = true;
            else if (Combo.Contains(11) && Combo.Contains(12) && Combo.Contains(16)) victory = true;
            //5x5
            else if (Combo.Contains(3) && Combo.Contains(10) && Combo.Contains(17)) victory = true;
            else if (Combo.Contains(6) && Combo.Contains(11) && Combo.Contains(18)) victory = true;
            else if (Combo.Contains(9) && Combo.Contains(12) && Combo.Contains(19)) victory = true;
            else if (Combo.Contains(15) && Combo.Contains(16) && Combo.Contains(20)) victory = true;
            else if (Combo.Contains(23) && Combo.Contains(24) && Combo.Contains(25)) victory = true;
            else if (Combo.Contains(7) && Combo.Contains(13) && Combo.Contains(21)) victory = true;
            else if (Combo.Contains(8) && Combo.Contains(14) && Combo.Contains(22)) victory = true;
            else if (Combo.Contains(9) && Combo.Contains(15) && Combo.Contains(23)) victory = true;
            else if (Combo.Contains(12) && Combo.Contains(16) && Combo.Contains(24)) victory = true;
            else if (Combo.Contains(19) && Combo.Contains(20) && Combo.Contains(25)) victory = true;
            else if (Combo.Contains(9) && Combo.Contains(16) && Combo.Contains(25)) victory = true;
            else if (Combo.Contains(3) && Combo.Contains(11) && Combo.Contains(19)) victory = true;
            else if (Combo.Contains(6) && Combo.Contains(12) && Combo.Contains(20)) victory = true;
            else if (Combo.Contains(7) && Combo.Contains(14) && Combo.Contains(23)) victory = true;
            else if (Combo.Contains(8) && Combo.Contains(15) && Combo.Contains(24)) victory = true;
            else if (Combo.Contains(18) && Combo.Contains(19) && Combo.Contains(20)) victory = true;
            else if (Combo.Contains(17) && Combo.Contains(18) && Combo.Contains(19)) victory = true;
            else if (Combo.Contains(22) && Combo.Contains(23) && Combo.Contains(24)) victory = true;
            else if (Combo.Contains(21) && Combo.Contains(22) && Combo.Contains(23)) victory = true;
            return victory;
        }
    }
}
