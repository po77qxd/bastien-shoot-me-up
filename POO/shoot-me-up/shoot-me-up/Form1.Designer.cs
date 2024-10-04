using System;

namespace shoot_me_up
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Ship1 = new Ship(components);
            label1 = new Label();
            scoreCounter = new Label();
            heart1 = new PictureBox();
            heart2 = new PictureBox();
            heart3 = new PictureBox();
            gameOver = new Label();
            gameOverScore = new Label();
            homeButton = new Button();
            ((System.ComponentModel.ISupportInitialize)Ship1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)heart3).BeginInit();
            SuspendLayout();
            // 
            // Ship1
            // 
            Ship1.BackColor = Color.Transparent;
            Ship1.Image = (Image)resources.GetObject("Ship1.Image");
            Ship1.Location = new Point(555, 555);
            Ship1.Name = "Ship1";
            Ship1.Size = new Size(90, 92);
            Ship1.SizeMode = PictureBoxSizeMode.Zoom;
            Ship1.TabIndex = 2;
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
            // homeButton
            // 
            homeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            homeButton.Location = new Point(523, 338);
            homeButton.Name = "homeButton";
            homeButton.Size = new Size(156, 68);
            homeButton.TabIndex = 10;
            homeButton.Text = "Accueil";
            homeButton.UseVisualStyleBackColor = true;
            homeButton.Click += homeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(1184, 861);
            Controls.Add(homeButton);
            Controls.Add(gameOverScore);
            Controls.Add(gameOver);
            Controls.Add(heart3);
            Controls.Add(heart2);
            Controls.Add(heart1);
            Controls.Add(scoreCounter);
            Controls.Add(label1);
            Controls.Add(Ship1);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Ship1).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart2).EndInit();
            ((System.ComponentModel.ISupportInitialize)heart3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Ship Ship1;
        private Label label1;
        private Label scoreCounter;
        private PictureBox heart1;
        private PictureBox heart2;
        private PictureBox heart3;
        private Label gameOver;
        private Label gameOverScore;
        private Button homeButton;
    }
}