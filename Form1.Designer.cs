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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btnHelp = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRock.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(75, 208);
            this.btnRock.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(159, 63);
            this.btnRock.TabIndex = 0;
            this.btnRock.Text = "Kivi";
            this.btnRock.UseVisualStyleBackColor = false;
            this.btnRock.Click += new System.EventHandler(this.btnRock_Click);
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnScissors.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnScissors.Location = new System.Drawing.Point(75, 288);
            this.btnScissors.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(159, 63);
            this.btnScissors.TabIndex = 1;
            this.btnScissors.Text = "Käärid";
            this.btnScissors.UseVisualStyleBackColor = false;
            this.btnScissors.Click += new System.EventHandler(this.btnScissors_Click);
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPaper.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnPaper.Location = new System.Drawing.Point(75, 374);
            this.btnPaper.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(159, 63);
            this.btnPaper.TabIndex = 2;
            this.btnPaper.Text = "Paber";
            this.btnPaper.UseVisualStyleBackColor = false;
            this.btnPaper.Click += new System.EventHandler(this.btnPaper_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnRestart.Location = new System.Drawing.Point(1019, 490);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(171, 80);
            this.btnRestart.TabIndex = 3;
            this.btnRestart.Text = "Uuesti";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::RockPaperScissors.Properties.Resources.question;
            this.picPlayer.Location = new System.Drawing.Point(349, 208);
            this.picPlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(243, 229);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 4;
            this.picPlayer.TabStop = false;
            // 
            // picCPU
            // 
            this.picCPU.Image = global::RockPaperScissors.Properties.Resources.question;
            this.picCPU.Location = new System.Drawing.Point(712, 208);
            this.picCPU.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(243, 229);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 5;
            this.picCPU.TabStop = false;
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtPlayer.Location = new System.Drawing.Point(444, 185);
            this.txtPlayer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(64, 17);
            this.txtPlayer.TabIndex = 6;
            this.txtPlayer.Text = "Mängija";
            this.txtPlayer.Click += new System.EventHandler(this.txtPlayer_Click);
            // 
            // txtCPU
            // 
            this.txtCPU.AutoSize = true;
            this.txtCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtCPU.Location = new System.Drawing.Point(811, 185);
            this.txtCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(39, 17);
            this.txtCPU.TabIndex = 7;
            this.txtCPU.Text = "CPU";
            this.txtCPU.Click += new System.EventHandler(this.txtCPU_Click);
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtScore.Location = new System.Drawing.Point(485, 96);
            this.txtScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(332, 39);
            this.txtScore.TabIndex = 8;
            this.txtScore.Text = "Mängija: 0 - CPU: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtScore.Click += new System.EventHandler(this.txtScore_Click);
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtTimer.Location = new System.Drawing.Point(632, 288);
            this.txtTimer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(37, 39);
            this.txtTimer.TabIndex = 9;
            this.txtTimer.Text = "5";
            this.txtTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtTimer.Click += new System.EventHandler(this.txtTimer_Click);
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtRound.Location = new System.Drawing.Point(571, 490);
            this.txtRound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(161, 39);
            this.txtRound.TabIndex = 10;
            this.txtRound.Text = "Ringid: 3";
            this.txtRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtRound.Click += new System.EventHandler(this.txtRound_Click);
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            this.countDownTimer.Tick += new System.EventHandler(this.countDownTimerEvent);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnHelp.Location = new System.Drawing.Point(840, 490);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(171, 80);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "Abi";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1205, 585);
            this.Controls.Add(this.btnHelp);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Kivi, paper, käärid mäng";
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
        private System.Windows.Forms.Button btnHelp;
    }
}

