using System.Numerics;
using TicTacToe;
namespace XandO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string player = " ";
        Game3x3 game3x3 = new Game3x3();
        Game4x4 game4x4 = new Game4x4();
        Game5x5 game5x5 = new Game5x5();
        Game game = new Game();
        private void button1_Click(object sender, EventArgs e)
        {
            player = "X";
            label1.Text = "Player 1 X";
            label2.Text = "Player 2 O";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player = "O";
            label1.Text = "Player 1 O";
            label2.Text = "Player 2 X";
              
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string play = game.selectGame(comboBox1.Text);
            if(label1.Text == "Player 1") { MessageBox.Show("Select role"); }
                else if (play == "Game3x3") { this.Hide(); game3x3.Show(); }
                    else if (play == "Game4x4") { this.Hide(); game4x4.Show(); }
                        else if (play == "Game5x5") { this.Hide(); game5x5.Show(); }
                            else { MessageBox.Show("Select game mode"); }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}