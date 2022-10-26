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
    public partial class Game4x4 : Form
    {
        public Game4x4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public static string player = " ";
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.Text = player;
            button1.Click -= button1_Click_1;
            if (player == "X") { xCombo.Add(1); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(1); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.Text = player;
            button2.Click -= button2_Click_1;
            if (player == "X") { xCombo.Add(2); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(2); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button3.Text = player;
            button3.Click -= button3_Click_1;
            if (player == "X") { xCombo.Add(3); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(3); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            button4.Text = player;
            button4.Click -= button4_Click_1;
            if (player == "X") { xCombo.Add(4); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(4); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            button5.Text = player;
            button5.Click -= button5_Click_1;
            if (player == "X") { xCombo.Add(5); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(5); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            button6.Text = player;
            button6.Click -= button6_Click_1;
            if (player == "X") { xCombo.Add(6); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(6); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            button7.Text = player;
            button7.Click -= button7_Click_1;
            if (player == "X") { xCombo.Add(7); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(7); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            button8.Text = player;
            button8.Click -= button8_Click_1;
            if (player == "X") { xCombo.Add(8); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(8); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            button9.Text = player;
            button9.Click -= button9_Click_1;
            if (player == "X") { xCombo.Add(9); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(9); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            button10.Text = player;
            button10.Click -= button10_Click_1;
            if (player == "X") { xCombo.Add(10); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(10); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            button11.Text = player;
            button11.Click -= button11_Click_1;
            if (player == "X") { xCombo.Add(11); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(11); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            button12.Text = player;
            button12.Click -= button12_Click_1;
            if (player == "X") { xCombo.Add(12); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(12); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            button13.Text = player;
            button13.Click -= button13_Click_1;
            if (player == "X") { xCombo.Add(13); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(13); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            button14.Text = player;
            button14.Click -= button14_Click_1;
            if (player == "X") { xCombo.Add(14); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(14); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            button15.Text = player;
            button15.Click -= button15_Click_1;
            if (player == "X") { xCombo.Add(15); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(15); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            button16.Text = player;
            button16.Click -= button16_Click_1;
            if (player == "X") { xCombo.Add(16); victory = game.checkForWin(xCombo); if (victory == true) Victory(player); player = "O"; }
            else { oCombo.Add(16); victory = game.checkForWin(oCombo); if (victory == true) Victory(player); player = "X"; }
        }
       
        private void Game4x4_Load(object sender, EventArgs e)
        {
            player = Form1.player;

        }

       
    }
}
