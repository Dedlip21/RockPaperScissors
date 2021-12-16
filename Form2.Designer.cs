namespace RockPaperScissors
{
    partial class helpWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpWindow));
            this.txtHelp = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHelp
            // 
            this.txtHelp.Enabled = false;
            this.txtHelp.Font = new System.Drawing.Font("Comic Sans MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.txtHelp.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtHelp.Location = new System.Drawing.Point(16, 15);
            this.txtHelp.Margin = new System.Windows.Forms.Padding(4);
            this.txtHelp.Multiline = true;
            this.txtHelp.Name = "txtHelp";
            this.txtHelp.Size = new System.Drawing.Size(516, 513);
            this.txtHelp.TabIndex = 0;
            this.txtHelp.Text = resources.GetString("txtHelp.Text");
            this.txtHelp.TextChanged += new System.EventHandler(this.txtHelp_TextChanged);
            // 
            // back
            // 
            this.back.BackColor = System.Drawing.Color.LightBlue;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.Color.DodgerBlue;
            this.back.Location = new System.Drawing.Point(12, 535);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(520, 74);
            this.back.TabIndex = 1;
            this.back.Text = "Väljuda";
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // helpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(554, 621);
            this.Controls.Add(this.back);
            this.Controls.Add(this.txtHelp);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "helpWindow";
            this.Text = "Help window";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHelp;
        private System.Windows.Forms.Button back;
    }
}