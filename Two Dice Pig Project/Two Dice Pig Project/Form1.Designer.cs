namespace WindowsFormsApp1
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
            this.gbPlayerOne = new System.Windows.Forms.GroupBox();
            this.txtP1TotalScore = new System.Windows.Forms.TextBox();
            this.lblP1TotalScore = new System.Windows.Forms.Label();
            this.lblP1TurnTotal = new System.Windows.Forms.Label();
            this.txtP1TurnTotal = new System.Windows.Forms.TextBox();
            this.btnP1Hold = new System.Windows.Forms.Button();
            this.btnP1Roll = new System.Windows.Forms.Button();
            this.gbPlayerTwo = new System.Windows.Forms.GroupBox();
            this.txtP2TotalScore = new System.Windows.Forms.TextBox();
            this.btnP2Hold = new System.Windows.Forms.Button();
            this.lblP2TotalScore = new System.Windows.Forms.Label();
            this.btnP2Roll = new System.Windows.Forms.Button();
            this.lblP2TurnTotal = new System.Windows.Forms.Label();
            this.txtP2TurnTotal = new System.Windows.Forms.TextBox();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.pbDiceTwo = new System.Windows.Forms.PictureBox();
            this.pbDiceOne = new System.Windows.Forms.PictureBox();
            this.linkLblHowToPlay = new System.Windows.Forms.LinkLabel();
            this.gbPlayerOne.SuspendLayout();
            this.gbPlayerTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceOne)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPlayerOne
            // 
            this.gbPlayerOne.Controls.Add(this.txtP1TotalScore);
            this.gbPlayerOne.Controls.Add(this.lblP1TotalScore);
            this.gbPlayerOne.Controls.Add(this.lblP1TurnTotal);
            this.gbPlayerOne.Controls.Add(this.txtP1TurnTotal);
            this.gbPlayerOne.Controls.Add(this.btnP1Hold);
            this.gbPlayerOne.Controls.Add(this.btnP1Roll);
            this.gbPlayerOne.Location = new System.Drawing.Point(24, 105);
            this.gbPlayerOne.Name = "gbPlayerOne";
            this.gbPlayerOne.Size = new System.Drawing.Size(260, 143);
            this.gbPlayerOne.TabIndex = 1;
            this.gbPlayerOne.TabStop = false;
            this.gbPlayerOne.Text = "Player One";
            // 
            // txtP1TotalScore
            // 
            this.txtP1TotalScore.Location = new System.Drawing.Point(134, 105);
            this.txtP1TotalScore.Name = "txtP1TotalScore";
            this.txtP1TotalScore.ReadOnly = true;
            this.txtP1TotalScore.Size = new System.Drawing.Size(111, 20);
            this.txtP1TotalScore.TabIndex = 3;
            // 
            // lblP1TotalScore
            // 
            this.lblP1TotalScore.AutoSize = true;
            this.lblP1TotalScore.Location = new System.Drawing.Point(7, 105);
            this.lblP1TotalScore.Name = "lblP1TotalScore";
            this.lblP1TotalScore.Size = new System.Drawing.Size(117, 13);
            this.lblP1TotalScore.TabIndex = 4;
            this.lblP1TotalScore.Text = "Player One Total Score";
            // 
            // lblP1TurnTotal
            // 
            this.lblP1TurnTotal.AutoSize = true;
            this.lblP1TurnTotal.Location = new System.Drawing.Point(7, 82);
            this.lblP1TurnTotal.Name = "lblP1TurnTotal";
            this.lblP1TurnTotal.Size = new System.Drawing.Size(111, 13);
            this.lblP1TurnTotal.TabIndex = 3;
            this.lblP1TurnTotal.Text = "Player One Turn Total";
            // 
            // txtP1TurnTotal
            // 
            this.txtP1TurnTotal.Location = new System.Drawing.Point(134, 79);
            this.txtP1TurnTotal.Name = "txtP1TurnTotal";
            this.txtP1TurnTotal.ReadOnly = true;
            this.txtP1TurnTotal.Size = new System.Drawing.Size(111, 20);
            this.txtP1TurnTotal.TabIndex = 2;
            // 
            // btnP1Hold
            // 
            this.btnP1Hold.BackColor = System.Drawing.Color.DimGray;
            this.btnP1Hold.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnP1Hold.Location = new System.Drawing.Point(134, 20);
            this.btnP1Hold.Name = "btnP1Hold";
            this.btnP1Hold.Size = new System.Drawing.Size(111, 44);
            this.btnP1Hold.TabIndex = 1;
            this.btnP1Hold.Text = "Hold";
            this.btnP1Hold.UseVisualStyleBackColor = false;
            this.btnP1Hold.Click += new System.EventHandler(this.btnP1Hold_Click);
            // 
            // btnP1Roll
            // 
            this.btnP1Roll.BackColor = System.Drawing.Color.DimGray;
            this.btnP1Roll.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnP1Roll.Location = new System.Drawing.Point(7, 20);
            this.btnP1Roll.Name = "btnP1Roll";
            this.btnP1Roll.Size = new System.Drawing.Size(111, 44);
            this.btnP1Roll.TabIndex = 0;
            this.btnP1Roll.Text = "Roll";
            this.btnP1Roll.UseVisualStyleBackColor = false;
            this.btnP1Roll.Click += new System.EventHandler(this.btnP1Roll_Click);
            // 
            // gbPlayerTwo
            // 
            this.gbPlayerTwo.Controls.Add(this.txtP2TotalScore);
            this.gbPlayerTwo.Controls.Add(this.btnP2Hold);
            this.gbPlayerTwo.Controls.Add(this.lblP2TotalScore);
            this.gbPlayerTwo.Controls.Add(this.btnP2Roll);
            this.gbPlayerTwo.Controls.Add(this.lblP2TurnTotal);
            this.gbPlayerTwo.Controls.Add(this.txtP2TurnTotal);
            this.gbPlayerTwo.Location = new System.Drawing.Point(24, 264);
            this.gbPlayerTwo.Name = "gbPlayerTwo";
            this.gbPlayerTwo.Size = new System.Drawing.Size(260, 148);
            this.gbPlayerTwo.TabIndex = 2;
            this.gbPlayerTwo.TabStop = false;
            this.gbPlayerTwo.Text = "Player Two";
            // 
            // txtP2TotalScore
            // 
            this.txtP2TotalScore.Location = new System.Drawing.Point(134, 100);
            this.txtP2TotalScore.Name = "txtP2TotalScore";
            this.txtP2TotalScore.ReadOnly = true;
            this.txtP2TotalScore.Size = new System.Drawing.Size(111, 20);
            this.txtP2TotalScore.TabIndex = 3;
            // 
            // btnP2Hold
            // 
            this.btnP2Hold.BackColor = System.Drawing.Color.DimGray;
            this.btnP2Hold.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnP2Hold.Location = new System.Drawing.Point(134, 20);
            this.btnP2Hold.Name = "btnP2Hold";
            this.btnP2Hold.Size = new System.Drawing.Size(111, 44);
            this.btnP2Hold.TabIndex = 1;
            this.btnP2Hold.Text = "Hold";
            this.btnP2Hold.UseVisualStyleBackColor = false;
            this.btnP2Hold.Click += new System.EventHandler(this.btnP2Hold_Click);
            // 
            // lblP2TotalScore
            // 
            this.lblP2TotalScore.AutoSize = true;
            this.lblP2TotalScore.Location = new System.Drawing.Point(7, 100);
            this.lblP2TotalScore.Name = "lblP2TotalScore";
            this.lblP2TotalScore.Size = new System.Drawing.Size(118, 13);
            this.lblP2TotalScore.TabIndex = 8;
            this.lblP2TotalScore.Text = "Player Two Total Score";
            // 
            // btnP2Roll
            // 
            this.btnP2Roll.BackColor = System.Drawing.Color.DimGray;
            this.btnP2Roll.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnP2Roll.Location = new System.Drawing.Point(7, 20);
            this.btnP2Roll.Name = "btnP2Roll";
            this.btnP2Roll.Size = new System.Drawing.Size(111, 44);
            this.btnP2Roll.TabIndex = 0;
            this.btnP2Roll.Text = "Roll";
            this.btnP2Roll.UseVisualStyleBackColor = false;
            this.btnP2Roll.Click += new System.EventHandler(this.btnP2Roll_Click);
            // 
            // lblP2TurnTotal
            // 
            this.lblP2TurnTotal.AutoSize = true;
            this.lblP2TurnTotal.Location = new System.Drawing.Point(7, 77);
            this.lblP2TurnTotal.Name = "lblP2TurnTotal";
            this.lblP2TurnTotal.Size = new System.Drawing.Size(112, 13);
            this.lblP2TurnTotal.TabIndex = 7;
            this.lblP2TurnTotal.Text = "Player Two Turn Total";
            // 
            // txtP2TurnTotal
            // 
            this.txtP2TurnTotal.Location = new System.Drawing.Point(134, 74);
            this.txtP2TurnTotal.Name = "txtP2TurnTotal";
            this.txtP2TurnTotal.ReadOnly = true;
            this.txtP2TurnTotal.Size = new System.Drawing.Size(111, 20);
            this.txtP2TurnTotal.TabIndex = 2;
            // 
            // btnNewGame
            // 
            this.btnNewGame.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNewGame.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnNewGame.Location = new System.Drawing.Point(24, 23);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(260, 66);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = false;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // pbDiceTwo
            // 
            this.pbDiceTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceTwo.Location = new System.Drawing.Point(562, 23);
            this.pbDiceTwo.Name = "pbDiceTwo";
            this.pbDiceTwo.Size = new System.Drawing.Size(230, 230);
            this.pbDiceTwo.TabIndex = 1;
            this.pbDiceTwo.TabStop = false;
            // 
            // pbDiceOne
            // 
            this.pbDiceOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDiceOne.Location = new System.Drawing.Point(303, 23);
            this.pbDiceOne.Name = "pbDiceOne";
            this.pbDiceOne.Size = new System.Drawing.Size(230, 230);
            this.pbDiceOne.TabIndex = 6;
            this.pbDiceOne.TabStop = false;
            // 
            // linkLblHowToPlay
            // 
            this.linkLblHowToPlay.AutoSize = true;
            this.linkLblHowToPlay.LinkArea = new System.Windows.Forms.LinkArea(6, 4);
            this.linkLblHowToPlay.Location = new System.Drawing.Point(70, 432);
            this.linkLblHowToPlay.Name = "linkLblHowToPlay";
            this.linkLblHowToPlay.Size = new System.Drawing.Size(155, 17);
            this.linkLblHowToPlay.TabIndex = 7;
            this.linkLblHowToPlay.TabStop = true;
            this.linkLblHowToPlay.Text = "Click here to learn how to play";
            this.linkLblHowToPlay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.linkLblHowToPlay.UseCompatibleTextRendering = true;
            this.linkLblHowToPlay.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblHowToPlay_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 458);
            this.Controls.Add(this.linkLblHowToPlay);
            this.Controls.Add(this.pbDiceOne);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.gbPlayerTwo);
            this.Controls.Add(this.gbPlayerOne);
            this.Controls.Add(this.pbDiceTwo);
            this.Name = "Form1";
            this.Text = "Two Dice Pig Game";
            this.gbPlayerOne.ResumeLayout(false);
            this.gbPlayerOne.PerformLayout();
            this.gbPlayerTwo.ResumeLayout(false);
            this.gbPlayerTwo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiceOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbDiceTwo;
        private System.Windows.Forms.GroupBox gbPlayerOne;
        private System.Windows.Forms.GroupBox gbPlayerTwo;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnP1Hold;
        private System.Windows.Forms.Button btnP1Roll;
        private System.Windows.Forms.Button btnP2Hold;
        private System.Windows.Forms.Button btnP2Roll;
        private System.Windows.Forms.TextBox txtP1TotalScore;
        private System.Windows.Forms.Label lblP1TotalScore;
        private System.Windows.Forms.Label lblP1TurnTotal;
        private System.Windows.Forms.TextBox txtP1TurnTotal;
        private System.Windows.Forms.TextBox txtP2TotalScore;
        private System.Windows.Forms.Label lblP2TotalScore;
        private System.Windows.Forms.Label lblP2TurnTotal;
        private System.Windows.Forms.TextBox txtP2TurnTotal;
        private System.Windows.Forms.PictureBox pbDiceOne;
        private System.Windows.Forms.LinkLabel linkLblHowToPlay;
    }
}

