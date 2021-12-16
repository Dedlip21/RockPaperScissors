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
    public partial class Form1 : Form
    {

        public int rounds = 3;
        public int timerPerRound = 6;
        bool gameOver = false;

        string[] CPUchoiceList = { "rock", "paper", "scissors", "rock", "scissors", "paper" };

        public int randomNumber = 0;

        Random rnd = new Random();

        string CPUChoice;

        string playerChoice;

        int playerScore;
        int CPUScore;

        public Form1()
        {
            InitializeComponent();

            countDownTimer.Enabled = true;

            playerChoice = "none";

            txtTimer.Text = "5";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            CPUScore = 0;
            rounds = 3;
            txtScore.Text = "Mängija: " + playerScore + " - " + "CPU: " + CPUScore;

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

            txtRound.Text = "Ringid: " + rounds;

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
                        MessageBox.Show("Mängija võitis mängu");
                    }
                    else if (playerScore < CPUScore)
                    {
                        MessageBox.Show("CPU võitis mängu");
                    }
                    else
                    {
                        MessageBox.Show("Viik");
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
            if(playerChoice== "rock" && CPUChoice == "paper")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU võitis, paper kattis kivi");
            }

            else if (playerChoice == "paper" && CPUChoice == "scissors")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU võitis, käärid lõikasid paberit");
            }

            else if (playerChoice == "scissors" && CPUChoice == "rock")
            {
                CPUScore += 1;

                rounds -= 1;

                MessageBox.Show("CPU võitis, kivi murdis käärid");
            }

            //Player wins

            else if (playerChoice == "paper" && CPUChoice == "rock")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Mängija võitis, paper kattis kivi");
            }

            else if (playerChoice == "scissors" && CPUChoice == "paper")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Mängija võitis, käärid lõikasid paberit");
            }

            else if (playerChoice == "rock" && CPUChoice == "scissors")
            {
                playerScore += 1;

                rounds -= 1;

                MessageBox.Show("Mängija võitis, kivi murdis käärid");
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
                MessageBox.Show("Otsust langetama!");
            }

            else
            {
                MessageBox.Show("Viik!");
            }

            startNextRound();

        }


        private void startNextRound()
        {

            if (gameOver==true)
            {
                return;
            }

            txtScore.Text = "Mängija: " + playerScore + " - " + "CPU: " + CPUScore;

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
            this.Hide();
            countDownTimer.Enabled = false;
        }
    }
}