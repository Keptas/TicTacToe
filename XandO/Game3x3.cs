using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TicTacToe;
namespace XandO
{
    public partial class Game3x3 : Form
    {
        public Game3x3()
        {
            InitializeComponent();
        }
        public static string player = "X";
        List<int> xCombo = new List<int>();
        List<int> oCombo = new List<int>();
        Game game = new Game();
        public static bool victory = false;

        private void Victory(string player)
        {
            MessageBox.Show("Laimejo " + player);

            this.Hide();
            Form1 start = new Form1();
            start.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = player;
            button1.Click -= button1_Click;
            if (player == "X") { xCombo.Add(1); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(1); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Text = player;
            button2.Click -= button2_Click;
            if (player == "X") { xCombo.Add(2); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(2); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Text = player;
            button3.Click -= button3_Click;
            if (player == "X") { xCombo.Add(3); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(3); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Text = player;
            button4.Click -= button4_Click;
            if (player == "X") { xCombo.Add(4); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(4); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Text = player;
            button5.Click -= button5_Click;
            if (player == "X") { xCombo.Add(5); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(5); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Text = player;
            button6.Click -= button6_Click;
            if (player == "X") { xCombo.Add(6); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(6); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Text = player;
            button7.Click -= button7_Click;
            if (player == "X") { xCombo.Add(7); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(7); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Text = player;
            button8.Click -= button8_Click;
            if (player == "X") { xCombo.Add(8); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(8); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Text = player;
            button9.Click -= button9_Click;
            if (player == "X") { xCombo.Add(9); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(9); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void Game3x3_Load(object sender, EventArgs e)
        {
            player = Form1.player;

        }
    }
}
