using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class Form3 : Form
    {

        public int rounds = 3;
        public int timerPerRound = 6;
        bool gameOver = false;

        string[] CPUchoiceList = { "rock", "paper", "scissor", "rock", "scissor", "paper" };

        public int randomNumber = 0;
        string command;

        Random rnd = new Random();

        string CPUChoice;

        string playerChoice;

        int playerScore;
        int CPUScore;

        public Form3()
        {
            InitializeComponent();

            countDownTimer.Enabled = true;

            playerChoice = "none";

            txtTimer.Text = "5";
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            CPUScore = 0;
            rounds = 3;
            txtScore.Text = "Игрок: " + playerScore + " - " + "CPU: " + CPUScore;

            playerChoice = "none";

            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.question;
            picCPU.Image = Properties.Resources.question;

            gameOver = false;
        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {
            timerPerRound--;

            txtTimer.Text = timerPerRound.ToString();

            txtRound.Text = "Раундов: " + rounds;

            if (timerPerRound < 1)
            {
                countDownTimer.Enabled = false;

                timerPerRound = 6;

                randomNumber = rnd.Next(0, CPUchoiceList.Length);

                CPUChoice = CPUchoiceList[randomNumber];

                switch (CPUChoice)
                {
                    case "rock":
                        picCPU.Image = Properties.Resources.stone;
                        break;

                    case "paper":
                        picCPU.Image = Properties.Resources.paper;
                        break;

                    case "scissors":
                        picCPU.Image = Properties.Resources.scissors;
                        break;
                }

                if (rounds > 0)
                {
                    checkGame();
                }
                else
                {
                    if (playerScore > CPUScore)
                    {
                        MessageBox.Show("Игрок выиграл игру");
                    }
                    else if (playerScore < CPUScore)
                    {
                        MessageBox.Show("CPU выиграл игру");
                    }
                    else
                    {
                        MessageBox.Show("Ничья");
                    }

                    gameOver = true;
                }
            }

        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            playerChoice = "rock";
            picPlayer.Image = Properties.Resources.stone;
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            playerChoice = "scissors";
            picPlayer.Image = Properties.Resources.scissors;
        }

        private void txtScore_Click(object sender, EventArgs e)
        {

        }

        private void txtRound_Click(object sender, EventArgs e)
        {

        }

        private void txtTimer_Click(object sender, EventArgs e)
        {

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            playerChoice = "paper";
            picPlayer.Image = Properties.Resources.paper;
        }


        private void checkGame()
        {
            // CPU wins
            if (playerChoice == "rock" && CPUChoice == "paper")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU выиграл, бумага накрыла камень");
            }

            else if (playerChoice == "paper" && CPUChoice == "scissors")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU выиграл, ножницы разрезали бумагу");
            }

            else if (playerChoice == "scissors" && CPUChoice == "rock")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU выиграл, камень сломал ножницы");
            }

            //Player wins

            else if (playerChoice == "paper" && CPUChoice == "rock")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Игрок выиграл, бумага накрыла камень");
            }

            else if (playerChoice == "scissors" && CPUChoice == "paper")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Игрок выиграл, ножницы разрезали бумагу");
            }

            else if (playerChoice == "rock" && CPUChoice == "scissors")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Игрок выиграл, камень сломал ножницы");
            }

            /*Ties
            else if (playerChoice == "rock" && CPUChoice == "rock")
            {
                rounds -= 1;

                MessageBox.Show("Ничья!!!");
            }

            else if (playerChoice == "paper" && CPUChoice == "paper")
            {
                rounds -= 1;

                MessageBox.Show("Ничья!!!");
            }

            else if (playerChoice == "scissors" && CPUChoice == "scissors")
            {
                rounds -= 1;

                MessageBox.Show("Ничья!!!");
            }*/

            else if (playerChoice == "none")
            {
                MessageBox.Show("Сделай выбор!");
            }

            else
            {
                MessageBox.Show("Ничья!");
            }

            startNextRound();

        }


        private void startNextRound()
        {

            if (gameOver == true)
            {
                return;
            }

            txtScore.Text = "Игрок: " + playerScore + " - " + "CPU: " + CPUScore;

            playerChoice = "none";

            countDownTimer.Enabled = true;

            picPlayer.Image = Properties.Resources.question;
            picCPU.Image = Properties.Resources.question;

        }

        private void txtCPU_Click(object sender, EventArgs e)
        {

        }

        private void txtPlayer_Click(object sender, EventArgs e)
        {

        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            helpWindow help = new helpWindow();
            help.Show();
        }

        private void btnEesti_Click(object sender, EventArgs e)
        {
            Form3 eesti = new Form3();
            eesti.Show();
            this.Hide();
            countDownTimer.Enabled = false;
        }
    }
}
/* https://www.youtube.com/watch?v=9FSW8qU60x8 */