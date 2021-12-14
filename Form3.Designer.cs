namespace RockPaperScissors
{
    partial class Form3
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
            this.btnHelp = new System.Windows.Forms.Button();
            this.txtRound = new System.Windows.Forms.Label();
            this.txtTimer = new System.Windows.Forms.Label();
            this.txtScore = new System.Windows.Forms.Label();
            this.txtCPU = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.Label();
            this.picCPU = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnPaper = new System.Windows.Forms.Button();
            this.btnScissors = new System.Windows.Forms.Button();
            this.btnRock = new System.Windows.Forms.Button();
            this.countDownTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnHelp.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnHelp.Location = new System.Drawing.Point(632, 396);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(128, 65);
            this.btnHelp.TabIndex = 23;
            this.btnHelp.Text = "Помощь";
            this.btnHelp.UseVisualStyleBackColor = false;
            // 
            // txtRound
            // 
            this.txtRound.AutoSize = true;
            this.txtRound.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtRound.Location = new System.Drawing.Point(408, 400);
            this.txtRound.Name = "txtRound";
            this.txtRound.Size = new System.Drawing.Size(161, 31);
            this.txtRound.TabIndex = 22;
            this.txtRound.Text = "Раундов: 3";
            this.txtRound.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTimer
            // 
            this.txtTimer.AutoSize = true;
            this.txtTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtTimer.Location = new System.Drawing.Point(476, 232);
            this.txtTimer.Name = "txtTimer";
            this.txtTimer.Size = new System.Drawing.Size(30, 31);
            this.txtTimer.TabIndex = 21;
            this.txtTimer.Text = "5";
            this.txtTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtScore
            // 
            this.txtScore.AutoSize = true;
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtScore.Location = new System.Drawing.Point(366, 76);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(246, 31);
            this.txtScore.TabIndex = 20;
            this.txtScore.Text = "Игрок: 0 - CPU: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCPU
            // 
            this.txtCPU.AutoSize = true;
            this.txtCPU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtCPU.Location = new System.Drawing.Point(610, 148);
            this.txtCPU.Name = "txtCPU";
            this.txtCPU.Size = new System.Drawing.Size(32, 13);
            this.txtCPU.TabIndex = 19;
            this.txtCPU.Text = "CPU";
            // 
            // txtPlayer
            // 
            this.txtPlayer.AutoSize = true;
            this.txtPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtPlayer.Location = new System.Drawing.Point(335, 148);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(43, 13);
            this.txtPlayer.TabIndex = 18;
            this.txtPlayer.Text = "Игрок";
            // 
            // picCPU
            // 
            this.picCPU.Image = global::RockPaperScissors.Properties.Resources.question;
            this.picCPU.Location = new System.Drawing.Point(536, 167);
            this.picCPU.Name = "picCPU";
            this.picCPU.Size = new System.Drawing.Size(182, 186);
            this.picCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCPU.TabIndex = 17;
            this.picCPU.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.Image = global::RockPaperScissors.Properties.Resources.question;
            this.picPlayer.Location = new System.Drawing.Point(264, 167);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(182, 186);
            this.picPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPlayer.TabIndex = 16;
            this.picPlayer.TabStop = false;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnRestart.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnRestart.Location = new System.Drawing.Point(766, 396);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(128, 65);
            this.btnRestart.TabIndex = 15;
            this.btnRestart.Text = "Заного";
            this.btnRestart.UseVisualStyleBackColor = false;
            // 
            // btnPaper
            // 
            this.btnPaper.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnPaper.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnPaper.Location = new System.Drawing.Point(58, 302);
            this.btnPaper.Name = "btnPaper";
            this.btnPaper.Size = new System.Drawing.Size(119, 51);
            this.btnPaper.TabIndex = 14;
            this.btnPaper.Text = "Бумага";
            this.btnPaper.UseVisualStyleBackColor = false;
            // 
            // btnScissors
            // 
            this.btnScissors.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnScissors.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.btnScissors.Location = new System.Drawing.Point(58, 232);
            this.btnScissors.Name = "btnScissors";
            this.btnScissors.Size = new System.Drawing.Size(119, 51);
            this.btnScissors.TabIndex = 13;
            this.btnScissors.Text = "Ножницы";
            this.btnScissors.UseVisualStyleBackColor = false;
            // 
            // btnRock
            // 
            this.btnRock.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRock.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRock.Location = new System.Drawing.Point(58, 167);
            this.btnRock.Name = "btnRock";
            this.btnRock.Size = new System.Drawing.Size(119, 51);
            this.btnRock.TabIndex = 12;
            this.btnRock.Text = "Камень";
            this.btnRock.UseVisualStyleBackColor = false;
            // 
            // countDownTimer
            // 
            this.countDownTimer.Interval = 1000;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 475);
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
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Label txtRound;
        private System.Windows.Forms.Label txtTimer;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label txtCPU;
        private System.Windows.Forms.Label txtPlayer;
        private System.Windows.Forms.PictureBox picCPU;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Button btnPaper;
        private System.Windows.Forms.Button btnScissors;
        private System.Windows.Forms.Button btnRock;
        private System.Windows.Forms.Timer countDownTimer;
    }
}