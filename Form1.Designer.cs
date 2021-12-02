namespace RockPaperScissors
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnRock = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.Label();
            this.txtRound = new System.Windows.Forms.Label();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.Location = new System.Drawing.Point(73, 110);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(75, 23);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Камень";
            this.btnRock.UseVisualStyleBackColor = true;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.Location = new System.Drawing.Point(73, 185);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(75, 23);
            this.btnScissors.TabIndex = 1;
            this.btnScissors.Text = "Ножницы";
            this.btnScissors.UseVisualStyleBackColor = true;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.Location = new System.Drawing.Point(73, 265);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(75, 23);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "Бумага";
            this.btnPaper.UseVisualStyleBackColor = true;
            this.btnPaper.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Location = new System.Drawing.Point(764, 402);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(94, 42);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Заного";
            this.btnRestart.UseVisualStyleBackColor = true;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::RockPaperScissors.Properties.Resources.question;
            this.picPlayer.Location = new System.Drawing.Point(207, 102);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(182, 186);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 4;
            this.picPlayer.TabStop = false;
            // 
            // picCPU
            // 
            this.picCPU.Image = global::RockPaperScissors.Properties.Resources.question;
            this.picCPU.Location = new System.Drawing.Point(676, 102);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(182, 186);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 5;
            this.picCPU.TabStop = false;
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.Location = new System.Drawing.Point(278, 83);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(38, 13);
            this.txtPlayer.TabIndex = 6;
            this.txtPlayer.Text = "Игрок";
            // 
            // txtCPU
            // 
            this.txtCPU.AutoSize = true;
            this.txtCPU.Location = new System.Drawing.Point(750, 83);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(29, 13);
            this.txtCPU.TabIndex = 7;
            this.txtCPU.Text = "CPU";
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtScore.Location = new System.Drawing.Point(414, 102);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(246, 31);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "Игрок: 0 - CPU: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtTimer.Location = new System.Drawing.Point(504, 216);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(30, 31);
            this.txtTimer.TabIndex = 9;
            this.txtTimer.Text = "5";
            this.txtTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtRound.Location = new System.Drawing.Point(414, 359);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(121, 31);
            this.txtRound.TabIndex = 10;
            this.txtRound.Text = "Раунд 1";
            this.txtRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 475);
            this.Controls.Add(this.txtRound);
            this.Controls.Add(this.txtTimer);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.txtCPU);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.picCPU);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnPaper);
            this.Controls.Add(this.btnScissors);
            this.Controls.Add(this.btnRock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.Label txtCPU;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.Label txtRound;
        private System.Windows.Forms.Timer countDownTimer;
    }
}

