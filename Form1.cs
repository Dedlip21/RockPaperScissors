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

        int rounds = 3;
        int timerPerRound = 6;
        bool gameOver = false;

        string[] CPUchoiceList = {"камень", "ножницы", "бумага", "ножницы", "бумага", "камень" };

        int randomNumber = 0;

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

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void btnRestart_Click(object sender, EventArgs e)
        {

        }

        private void countDownTimerEvent(object sender, EventArgs e)
        {

        }

        private void btnRock_Click(object sender, EventArgs e)
        {

        }

        private void btnScissors_Click(object sender, EventArgs e)
        {

        }
    }
}
//https://www.youtube.com/watch?v=9FSW8qU60x8