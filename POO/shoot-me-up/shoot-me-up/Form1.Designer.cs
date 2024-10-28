using System;

namespace shoot_me_up
{
    partial class Game
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            label1 = new Label();
            scoreCounter = new Label();
            heart1 = new PictureBox();
            heart2 = new PictureBox();
            heart3 = new PictureBox();
            gameOver = new Label();
            gameOverScore = new Label();
            levelButton = new Button();
            powerUpLabel = new Label();
            winLabel = new Label();
            newBestScoreLabel = new Label();
            Ship1 = new Ship(components);
            ((System.ComponentModel.ISupportInitialize)heart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Ship1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(1035, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 32);
            label1.TabIndex = 3;
            label1.Text = "Score";
            // 
            // scoreCounter
            // 
            scoreCounter.AutoSize = true;
            scoreCounter.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            scoreCounter.ForeColor = Color.White;
            scoreCounter.Location = new Point(1104, 9);
            scoreCounter.Name = "scoreCounter";
            scoreCounter.Size = new Size(27, 32);
            scoreCounter.TabIndex = 4;
            scoreCounter.Text = "0";
            // 
            // heart1
            // 
            heart1.Image = (Image)resources.GetObject("heart1.Image");
            heart1.Location = new Point(12, 9);
            heart1.Name = "heart1";
            heart1.Size = new Size(51, 48);
            heart1.SizeMode = PictureBoxSizeMode.Zoom;
            heart1.TabIndex = 5;
            heart1.TabStop = false;
            // 
            // heart2
            // 
            heart2.Image = (Image)resources.GetObject("heart2.Image");
            heart2.Location = new Point(69, 9);
            heart2.Name = "heart2";
            heart2.Size = new Size(51, 48);
            heart2.SizeMode = PictureBoxSizeMode.Zoom;
            heart2.TabIndex = 6;
            heart2.TabStop = false;
            // 
            // heart3
            // 
            heart3.Image = (Image)resources.GetObject("heart3.Image");
            heart3.Location = new Point(126, 9);
            heart3.Name = "heart3";
            heart3.Size = new Size(51, 48);
            heart3.SizeMode = PictureBoxSizeMode.Zoom;
            heart3.TabIndex = 7;
            heart3.TabStop = false;
            // 
            // gameOver
            // 
            gameOver.AutoSize = true;
            gameOver.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            gameOver.ForeColor = Color.White;
            gameOver.Location = new Point(320, 90);
            gameOver.Name = "gameOver";
            gameOver.Size = new Size(597, 128);
            gameOver.TabIndex = 8;
            gameOver.Text = "Game over !";
            // 
            // gameOverScore
            // 
            gameOverScore.AutoSize = true;
            gameOverScore.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            gameOverScore.ForeColor = Color.White;
            gameOverScore.Location = new Point(457, 247);
            gameOverScore.Name = "gameOverScore";
            gameOverScore.Size = new Size(197, 45);
            gameOverScore.TabIndex = 9;
            gameOverScore.Text = "Your score : ";
            // 
            // levelButton
            // 
            levelButton.FlatAppearance.BorderColor = Color.DodgerBlue;
            levelButton.FlatAppearance.BorderSize = 2;
            levelButton.FlatStyle = FlatStyle.Flat;
            levelButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            levelButton.ForeColor = Color.White;
            levelButton.Location = new Point(524, 350);
            levelButton.Name = "levelButton";
            levelButton.Size = new Size(156, 68);
            levelButton.TabIndex = 10;
            levelButton.Text = "Levels";
            levelButton.UseVisualStyleBackColor = true;
            levelButton.Click += homeButton_Click;
            // 
            // powerUpLabel
            // 
            powerUpLabel.AutoSize = true;
            powerUpLabel.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            powerUpLabel.ForeColor = Color.Red;
            powerUpLabel.Location = new Point(380, 7);
            powerUpLabel.Name = "powerUpLabel";
            powerUpLabel.Size = new Size(263, 32);
            powerUpLabel.TabIndex = 11;
            powerUpLabel.Text = "POWER UP ENABLED : ";
            // 
            // winLabel
            // 
            winLabel.AutoSize = true;
            winLabel.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            winLabel.ForeColor = Color.White;
            winLabel.Location = new Point(380, 90);
            winLabel.Name = "winLabel";
            winLabel.Size = new Size(465, 128);
            winLabel.TabIndex = 12;
            winLabel.Text = "You win !";
            // 
            // newBestScoreLabel
            // 
            newBestScoreLabel.AutoSize = true;
            newBestScoreLabel.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point);
            newBestScoreLabel.ForeColor = Color.White;
            newBestScoreLabel.Location = new Point(457, 295);
            newBestScoreLabel.Name = "newBestScoreLabel";
            newBestScoreLabel.Size = new Size(262, 45);
            newBestScoreLabel.TabIndex = 13;
            newBestScoreLabel.Text = "New best score !";
            // 
            // Ship1
            // 
            Ship1.Image = (Image)resources.GetObject("Ship1.Image");
            Ship1.Location = new Point(560, 651);
            Ship1.Margin = new Padding(3, 2, 3, 2);
            Ship1.Name = "Ship1";
            Ship1.Size = new Size(88, 86);
            Ship1.SizeMode = PictureBoxSizeMode.Zoom;
            Ship1.TabIndex = 2;
            // 
            // Game
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1184, 791);
            Controls.Add(Ship1);
            Controls.Add(newBestScoreLabel);
            Controls.Add(winLabel);
            Controls.Add(powerUpLabel);
            Controls.Add(levelButton);
            Controls.Add(gameOverScore);
            Controls.Add(gameOver);
            Controls.Add(heart3);
            Controls.Add(heart2);
            Controls.Add(heart1);
            Controls.Add(scoreCounter);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Game";
            Text = "game";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)heart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart3).EndInit();
            ((System.ComponentModel.ISupportInitialize)Ship1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label scoreCounter;
        private PictureBox heart1;
        private PictureBox heart2;
        private PictureBox heart3;
        private Label gameOver;
        private Label gameOverScore;
        private Button levelButton;
        private Label powerUpLabel;
        private Label winLabel;
        private Label newBestScoreLabel;
        private Ship Ship1;
    }
}